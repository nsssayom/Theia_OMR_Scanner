//includes
#include "opencv2/imgcodecs.hpp"
#include "opencv2/highgui.hpp"
#include "opencv2/imgproc.hpp"
#include "opencv2/opencv.hpp"
#include <iostream>
#include <algorithm>
#include <vector>
#include <cmath>
#include <string>
#include <fstream>
#include <Windows.h>
#include "picosha2.h"

//namespaces
using namespace std;
using namespace cv;
using namespace picosha2;

//global variables
int edgeThresh = 1;
int lowThreshold;
int const max_lowThreshold = 100;
int ratio = 3;
int kernel_size = 3;
int ArrayIndex = 0;
static int counter = 0;
int fillerRatio = 30;

//function prototypes
double distance(Point p, int mood);
bool readCircle(Mat image, int xLoc, int yLoc, int radius = 5);
int readPixel(Mat image, int x, int y);
bool comp_l_r_b(const Point& lhs, const Point& rhs);
Mat CannyThreshold(Mat src_gray, int, void*);
wstring ReadRegValue(HKEY root, wstring key, wstring name);

//class of the contures
class foundContour {
public:
	Point left;
	Point right;
	Point poi;
	int type; //type 0 = triangle, type 1 = square
	bool isVarified;
	Mat image;
	static int ID_gen;
	int ID;
	int i;
	double archLength;

	foundContour(Mat img) { image = img; ID = ++ID_gen; type = -1; } //constructor

};

//static int variable initialization 
int foundContour::ID_gen = 0;

//class for the reference points
class refPoint {
public:
	Point poi;
	int ID;
	int type;
	int mainRef; //1-4 for point 1,2,3,4; anything else for none;
	double archLength;
	void printPointInfo() {
		cout << "ID: " << ID << endl;
		cout << "Identification Point: " << poi << endl;
		cout << "Type: ";
		type == 0 ? cout << "Triangle" << endl << endl : cout << "Square" << endl << endl;
	}
	refPoint() { mainRef = -1; }
	refPoint(Point poi, int type, int ID) { 
		this->mainRef = -1;
		this->poi = poi;
		this->type = type;
		this->ID = ID;
	}
};

//Class of Roll Number
class OMRSheet {
public:
	//int xLocRoll[8] = {36, 51, 65, 79, 94, 108, 122, 137};
	//int yLocRoll[10]= {14, 31, 47, 64, 80, 98, 114, 131, 148, 165};

	int xLocRoll[8], yLocRoll[10];
	int arr_x_roll;
	int arr_y_roll;

	int xLocRow[4][4], yLocRow[25];
	int arr_x_row0;
	int arr_x_row1;
	int arr_x_row2;
	int arr_x_row3;
	int arr_y_row;

	OMRSheet() {
		arr_x_roll = 0;
		arr_y_roll = 0;
		arr_x_row0 = 0;
		arr_x_row1 = 0;
		arr_x_row2 = 0;
		arr_x_row3 = 0;
		arr_y_row = 0;
	}

	void readLayout() {
		int i;
		int row = -1;
		string line;
		ifstream layoutFile("files/new.layout");
		int f = 0;
		for (i = 0; i<66; i++) {
			getline(layoutFile, line);
			if (i>0 && i<9) {
				xLocRoll[arr_x_roll++] = atoi(line.c_str());
				//cout<<"X: "<<xLocRoll[0]<<endl;
			}
			else if (i>9 && i<20) {
				yLocRoll[arr_y_roll++] = atoi(line.c_str());
			}
			else if (i>20 && i<25) {
				row = 0;
				xLocRow[row][arr_x_row0++] = atoi(line.c_str());
				//cout<<"X: "<<xLocRow[0][f++]<<endl;
			}
			else if (i>25 && i<30) {
				row = 1;
				xLocRow[row][arr_x_row1++] = atoi(line.c_str());
				//cout<<"X: "<<xLocRow[1][f++]<<endl;
			}
			else if (i>30 && i<35) {
				row = 2;
				xLocRow[row][arr_x_row2++] = atoi(line.c_str());
				//cout<<"X: "<<xLocRow[f++]<<endl;				
			}
			else if (i>35 && i<40) {
				row = 3;
				xLocRow[row][arr_x_row3++] = atoi(line.c_str());
				//cout<<"X: "<<xLocRow[f++]<<endl;				
			}
			else if (i>40 && i<66) {
				yLocRow[arr_y_row++] = atoi(line.c_str());
				//cout<<"Y: "<<yLocRow[f++]<<endl;
			}
		}

		layoutFile.close();
	}


	string readRoll(Mat image) {
		stringstream rollStream;
		int i, j;
		int radius = 5;

		int markCount = -1;

		for (i = 0; i < 8; i++) {
			markCount = 0;
			for (j = 0; j < 10; j++) {
				if ((readCircle(image, xLocRoll[i], yLocRoll[j], radius)) == true) {
					markCount++;
					rollStream << (j);
				}
				if (markCount > 1) {
					return "Error Roll";
				}
			}
		}
		return rollStream.str();
	}

	string readAnswers(Mat image) {
		int i, j, counter = -1, row;
		stringstream ansStream;
		for (row = 0; row < 4; row++) {
			for (i = 0; i < 25; i++) {
				counter = 0;
				for (j = 0; j < 4; j++) {
					if ((readCircle(image, xLocRow[row][j], yLocRow[i], 5)) == true) {
						counter++;
						if (counter > 1) {
							ansStream << ",";
						}
						ansStream << (char)(65 + j);
					}

				}
				if (counter < 1) {
					ansStream << "-";
				}
				ansStream << "|";
			}
		}
		//cout<< ansStream.str() <<endl;
		return ansStream.str();
	}

};

double distance(Point p, int mood) {
	switch (mood) {
	case 1:	return sqrt((pow(p.x, 2.0)) + (pow(p.y, 2.0)));
		break;
	case 2:	return sqrt((pow(499 - p.x, 2.0)) + (pow(p.y, 2.0)));
		break;
	case 3: return sqrt((pow(499 - p.x, 2.0)) + (pow(699 - p.y, 2.0)));
		break;
	case 4: return sqrt((pow(p.x, 2.0)) + (pow(699 - p.y, 2.0)));
		break;

	}
	return -1;
}


bool readCircle(Mat image, int xLoc, int yLoc, int radius) {
	vector<Mat> channels;
	Rect boundingRect(xLoc - radius, yLoc - radius, radius * 2 + 1, radius * 2 + 1);
	Mat circleROI(image, boundingRect);
	split(circleROI, channels);
	double avgVal = mean(channels[0]).val[0];
	if (avgVal < fillerRatio) {
		circle(circleROI, Point(radius, radius), radius, Scalar(0, 0, 255), 2);
		return true;
	}
	else {
		circle(circleROI, Point(radius, radius), radius, Scalar(255, 0, 0), 2);
		return false;
	}

}


bool comp_l_r_b(const Point& lhs, const Point& rhs) {
	return (lhs.x < rhs.x && lhs.y > rhs.y);
}

int readPixel(Mat image, int x, int y) {
	return image.at<uchar>(Point(x, y));
}

Mat CannyThreshold(Mat src_gray, int, void*)
{
	// Reduce noise with a kernel 3x3
	Mat detected_edges, dst;
	blur(src_gray, detected_edges, Size(3, 3));
	// Canny detector
	Canny(detected_edges, detected_edges, lowThreshold, lowThreshold*ratio, kernel_size);

	// Using Canny's output as a mask, we display our result
	dst = Scalar::all(0);
	src_gray.copyTo(dst, detected_edges);
	return dst;
}

wstring ReadRegValue(HKEY root, wstring key, wstring name)
{
	HKEY hKey;
	if (RegOpenKeyEx(root, key.c_str(), 0, KEY_READ, &hKey) != ERROR_SUCCESS)
		throw "Could not open registry key";

	DWORD type;
	DWORD cbData;
	if (RegQueryValueEx(hKey, name.c_str(), NULL, &type, NULL, &cbData) != ERROR_SUCCESS)
	{
		RegCloseKey(hKey);
		throw "Could not read registry value";
	}

	if (type != REG_SZ)
	{
		RegCloseKey(hKey);
		throw "Incorrect registry value type";
	}

	wstring value(cbData / sizeof(wchar_t), L'\0');
	if (RegQueryValueEx(hKey, name.c_str(), NULL, NULL, reinterpret_cast<LPBYTE>(&value[0]), &cbData) != ERROR_SUCCESS)
	{
		RegCloseKey(hKey);
		throw "Could not read registry value";
	}

	RegCloseKey(hKey);

	size_t firstNull = value.find_first_of(L'\0');
	if (firstNull != string::npos)
		value.resize(firstNull);

	return value;
}


int main(int argc, char *argv[]) {
	
	/*
	Mandatory Arguments:
		argv[0] = executable name
		argv[1] = argc
		argv[2] = file name
		argv[3] = Heil Fuhrer Enigmas 
	Optional Arguments:
		argv[4] = filler Ratio (sensivity)
	*/
	
	
	// Read image
	//Mat sourceImage = imread("files/stu2/5.bmp", CV_LOAD_IMAGE_GRAYSCALE)

	//argument check
	if (argc < 4) {
		cout << "Illegal Request" << endl;
		return 0;
	}

	if (argc > 4) {
		fillerRatio = atoi(argv[4]);
	}

	//Security check

	wstring regValue = ReadRegValue(HKEY_CURRENT_USER, L"Software\\TheiaTemp", L"HeilHitler");
	//wcout << regValue << endl;
	string regValstr (regValue.begin(), regValue.end());

	stringstream keyStream;
	string keyArg = argv[3];
	keyStream << "heil fuhrer" << keyArg << "fuhrer is great";
	string keyString = keyStream.str();
	string hash_hex_str = picosha2::hash256_hex_string(keyString);
	std::transform(hash_hex_str.begin(), hash_hex_str.end(), hash_hex_str.begin(), ::toupper);
	string keyHash = hash_hex_str;
	//cout << regValstr << endl;
	//cout << keyHash << endl;

	if (regValstr != keyHash) {
		cout << "Illegal use of Executable: " << regValstr << "_|_" << keyHash << endl;
		return 0;
	}

	RegDeleteKey(HKEY_CURRENT_USER, L"Software\\TheiaTemp");

	//auto isDeleted = RegDeleteKey(HKEY_CURRENT_USER, L"Software\\TheiaTemp");
	//if (isDeleted != ERROR_SUCCESS) {
	//	cout << "Illegal Request" << endl;
	//	return 0;
	//}

	//-------------------------------------------------------------
	Mat sourceImage = imread(argv[2], CV_LOAD_IMAGE_GRAYSCALE);
	threshold(sourceImage, sourceImage, 0, 255, 3);

	Mat resizedImage;
	Size size(500, 700);
	resize(sourceImage, resizedImage, size);//Resize Image

	Mat thrImage, countouredImage, WarpedImage;
	cvtColor(resizedImage, countouredImage, CV_GRAY2BGR);

	threshold(resizedImage, thrImage, 0, 255, 3);
	std::vector<std::vector<cv::Point> > contours;
	std::vector<cv::Vec4i> hierarchy;

	cv::findContours(thrImage, contours, hierarchy, CV_RETR_LIST, CV_CHAIN_APPROX_SIMPLE);

	std::vector<std::vector<cv::Point> > oHull(contours.size());

	//Array of all found contours
	vector<foundContour>  reference(1, foundContour(resizedImage));
	int init = 0;
	for (unsigned int i = 0; i != contours.size(); i++) {
		if ( init != 0){
			reference.push_back(foundContour(resizedImage));
		}
		init++;

		if (cv::contourArea(contours[i]) > 50 && cv::contourArea(contours[i]) < 100)
		{
			cv::convexHull(contours[i], oHull[i]);
			cv::approxPolyDP(oHull[i], oHull[i], 0.1*cv::arcLength(oHull[i], true), true);
			if (oHull[i].size() == 3)
			{
				++counter;
				reference[i].type = 0;

				Point top = *min_element(contours[i].begin(), contours[i].end(), comp_l_r_b);
				//cout<<"Extreme Top: "<<top<<endl<<endl;
				reference[i].poi = top;
				//circle(countouredImage, top, 1, cv::Scalar(255, 255, 0), 2, 8, 0);				

				//cout<<"isContourConvex: "<<arcLength(contours[i],1)<<endl;

				reference[i].archLength = arcLength(contours[i], 1);

				if (reference[i].archLength < 40) {
					reference[i].isVarified = true;
					circle(countouredImage, top, 1, cv::Scalar(255, 255, 0), 2, 8, 0);
				}
				else {
					reference[i].isVarified = false;
				}
			}
		}

		else if (cv::contourArea(contours[i]) > 120 && cv::contourArea(contours[i]) < 170)
		{
			cv::convexHull(contours[i], oHull[i]);
			cv::approxPolyDP(oHull[i], oHull[i], 0.1*cv::arcLength(oHull[i], true), true);
			if (oHull[i].size() == 4)
			{
				++counter;
				//cout<<"Sqr: "<<++counter<<endl<<"---------"<<endl<<contours[i]<<endl<<
				//"Area: "<<cv::contourArea(contours[i])<<endl<<endl;
				reference[i].type = 1;

				Point top = *min_element(contours[i].begin(), contours[i].end(), comp_l_r_b);
				//cout<<"Extreme Top: "<<top<<endl<<endl;
				reference[i].poi = top;
				reference[i].archLength = arcLength(contours[i], 1);

				if (reference[i].archLength > 30 && reference[i].archLength < 50) {
					reference[i].isVarified = true;
					circle(countouredImage, top, 1, cv::Scalar(255, 255, 0), 2, 8, 0);
				}
				else {
					reference[i].isVarified = false;
				}
			}
		}
	}

	vector<refPoint>  vRefPointArray(1, refPoint());
	//refPoint vRefPointArray[counter];

	int i, j = 0;
	int initV = 0;
	for (i = 0; i < foundContour::ID_gen; i++) {

		if (initV != 0) {
			vRefPointArray.push_back(refPoint());
		}
		initV++;

		if (reference[i].type != -1) {

			if (reference[i].isVarified == true) {
				//cout<<"verified"<<endl;
				ArrayIndex = j++;
				////vRefPointArray.push_back(refPoint(reference[i].poi, reference[i].type, ArrayIndex));
				vRefPointArray[ArrayIndex].poi = reference[i].poi;
				vRefPointArray[ArrayIndex].type = reference[i].type;
				vRefPointArray[ArrayIndex].ID = ArrayIndex;
				//vRefPointArray[ArrayIndex].printPointInfo();
			}
		}
		vRefPointArray.push_back(refPoint(reference[i].poi, reference[i].type, ArrayIndex));
	}

	Point2f corners[4]; //this was supposed to be of size 4. But that throws an error
	Point2f dst_corners[4];

	dst_corners[0] = Point2f(0, 0);
	dst_corners[1] = Point2f(499, 0);
	dst_corners[2] = Point2f(499, 699);
	dst_corners[3] = Point2f(0, 699);



	for (i = 0; i < 4; i++) {

		double dist = 1000;
		int dist_index;
		int n;
		for (n = 0; n < ArrayIndex + 1; n++) {
			if ((distance(vRefPointArray[n].poi, i + 1)) < dist) {
				dist = distance(vRefPointArray[n].poi, i + 1);
				dist_index = n;
			}
		}
		vRefPointArray[n].mainRef = i + 1;
		//cout << "Ref Point : " << dist_index << "|" << vRefPointArray[dist_index].poi << endl;
		corners[i] = (vRefPointArray[dist_index].poi);
		circle(countouredImage, vRefPointArray[dist_index].poi, 1, cv::Scalar(0, 0, 255), 2, 8, 0);
	}


	//cout<<corners[0]<<endl;
	Mat transmtx = getPerspectiveTransform(corners, dst_corners);
	warpPerspective(countouredImage, WarpedImage, transmtx, countouredImage.size());
	//warpPerspective(countouredImage, WarpedImage, transmtx, Size(390, 470));
	threshold(WarpedImage, WarpedImage, 150, 255, 3);


	OMRSheet Roll;

	stringstream outPut;
	string rollOut;
	string AnsOut;

	Roll.readLayout();

	rollOut = Roll.readRoll(WarpedImage);
	AnsOut = Roll.readAnswers(WarpedImage);

	//cout<<rollOut<<endl<<AnsOut<<endl;
	outPut << rollOut << "<>" << AnsOut;
	
	cout << outPut.str();
	fflush(stdout);

	//cv::imshow("Refference Points", countouredImage);
	//cv::waitKey(1);
	//cv::imshow("Warped Image", WarpedImage);
	//cv::waitKey(0);

	return 0;
}