// OOP_HTML_MitchellJacob.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>
#include <fstream>

std::ofstream outfileHTML("OUTPUT_PART1_HMTL_MitchellJacob.html", std::ofstream::out | std::ofstream::app);
std::ofstream outfileHTML2("OUTPUT_PART2_HMTL_MitchellJacob.html", std::ofstream::out | std::ofstream::app);
std::ofstream outfileDebugLog("OUTPUT_PART1_DebugLog_MitchellJacob.txt", std::ofstream::out | std::ofstream::app);
std::ofstream outfileDebugLog2("OUTPUT_PART2_DebugLog_MitchellJacob.txt", std::ofstream::out | std::ofstream::app);
std::ifstream infile;
std::string h1FromAssignment = "C++ Programming / HTML Generator";
std::string pFromAssignment = "The HTML behind this web page was created by a C++ program!";
std::string objectOrientedProgramming = "Object Oriented Programming is a programming concept that uses objects that contain data about themselves and can include functions to be worked with. When you're working with objects, each instance of an object can have unique values for its attributes. Object oriented programming differs from procedural as you can make your own types and have several objects that are the same thing, but are different. For instance, you can have two rectangle objects. Both are rectangles, but each has different attributes and unique lengths and widths. Procedural programming moreso refers to a sequential route of programming. A code runs from top to bottom and then finishes.";
std::string inheritance = "Inheritence is when you a class is based off of an existing class or object of another class. ";
std::string polymorphism = "An instance of Polymorphism would be like a class for a vehicle, a truck, and a boat. You have a class, vehicle, that holds data manufacturer, year made, and maybe some other data. A truck is a vehicle, a thus inherits from the vehicle class. A boat does the same thing. However, a truck and a boat are very different while both are vehicles. A boat is a vehicle but a boat isn't a truck and vice versa. Polymorphism uses an \"is a\" type of relationship";
std::string cppVscs = "C++ and C# are very similar languages by nature. C++ was actually the first programming language I learned and practiced, which seems opposite to most of my peers. My intorduction ot programming was in c++. I learned c++ in a terminal environment and used it to write small odd tasks. The biggest difference I see between the two is that C# is inherently based on object oriented programing. In c++ I never needed to convert an integer to a string to output it, I just output it. I also worked a lot in c++ working with pointers and memory locations, and even making programs where I reference objects and variabls based on pointers to their memory location rather than their names. In c#, you can't even access the memory location, which is safer, really.";
int numRecords = 0;

class table {
private: 
	std::string th[4];
	std::string td[200];

public:
	table() {

	}
	table(std::string headers[], std::string data[]) {

	}

	void createTh(std::string content[]) {
		for (int i = 0; i < 4; i++) {
			th[i] = content[i];

		}
	}

	std::string tableBegin() {
		std::string output;
		output = " <table>";
		outfileDebugLog2 << "Beginning of table generated.\n";
		return output;
	}
		std::string tableEnd() {
		std::string output;
		output = " </table>";
		outfileDebugLog2 << "End of table generated.\n";

		return output;
	}
	std::string trBegin() {
			std::string output = "<tr>";
			return output;
	}
	std::string trEnd() {
			std::string output = "</tr>";
			return output;
	}
	std::string generateTh() {
		std::string output;
		for (int i = 0; i < 4; i++) {
			output += "<th> " + th[i] + " </th>";
		}
		outfileDebugLog2 << "Header of table generated.\n";

		return output;
	}
	void createTd(std::string input[]) {
		int counter = 0;


		for (int i = 4; i < 200; i++) {
			if (counter % 4 == 0) {
				td[i] = "<tr> <td> " + input[i] + "</td>";
				counter++;
				numRecords++;
				outfileDebugLog2 << "Row of table generated.\n";
			}
			else if (i % 4 == 0) {
				td[i] = "<td> " + input[i] + "</td> </tr>";
				counter++;
				numRecords++;

				outfileDebugLog2 << "End of table row generated.\n";

			}
			else {
				td[i] = "<td> " + input[i] + "</td>";
				counter++;
				numRecords++;
				outfileDebugLog2 << "Data of table generated.\n";

			}

		}

	}
	
	std::string generateTd() {
		std::string output;
		for (int i = 0; i < 200; i++) {
			output += td[i] + " ";
		}
		return output;
	}
	~table() {

	}
};
class html {
private:
	std::string p;
	std::string h1;


public:

	std::string generateHTMLforPtag(std::string contents) {
		std::string pTag;
		pTag = "<p> " + contents + "</p>\n";
		outfileDebugLog << "\nP Tag Generated.\n";
		outfileDebugLog2 << "\nP Tag Generated.\n";
		return pTag;
	}

	std::string generateHTMLforh1tag(std::string contents) {
		std::string h1Tag;
		h1Tag = "<h1> " + contents + "</h1>\n";
		outfileDebugLog << "\nh1 Tag Generated.\n";
		outfileDebugLog2 << "\nh1 Tag Generated.\n";
		return h1Tag;
	}

	/*std::string generateHTMLfortdTag(std::string contents) {
		std::string td;
		td = "<td> " + contents + "</td>\n";
		std::cout << "\nTD Tag Generated.\n";
		outfileDebugLog << "\nTD Tag Generated.\n";
		return td;
	}

	std::string generateHTMLfortrTag(std::string contents) {
		std::string tr;
		tr = "<tr> " + contents + "</tr>\n";
		std::cout << "\nTR Tag Generated.\n";
		outfileDebugLog << "\nTR Tag Generated.\n";

		return tr;
	}

	std::string generateHTMLforTableTag(std::string contents) {
		std::string table;
		table = "<table> " + contents + "</table>\n";
		std::cout << "\nTable Tag Generated.\n";
		outfileDebugLog << "\nTable Tag Generated.\n";
		return table;
	}*/
	~html() {
		
	}
};

class styleSheet {

	private:
		std::string h1fontColor;
		std::string font;
		std::string backGroundColor;

	public:

		//Constructor that makes a style sheet and defaults it to values from the assignment sheet
		styleSheet() {
			h1fontColor = "#FF0000";
			backGroundColor = "#DDDDDD";
			font = "arial, sans-serif";
			outfileDebugLog << "\nUncustomized Style Features Generated.\n";
			outfileDebugLog2 << "\nUncustomized Style Features Generated.\n";

		}

		//Overloaded constructor allowing customization of inputs
		styleSheet(std::string h1ColorInput, std::string bgColorInput, std::string fontInput) {
			h1fontColor = h1ColorInput;
			font = fontInput;
			backGroundColor = bgColorInput;
			outfileDebugLog << "\nCustomized Style Features Generated.\n";
			outfileDebugLog2 << "\nCustomized Style Features Generated.\n";

		}

		void setFont(std::string fontInput) { font = fontInput; std::cout << "\nFont Updated\n"; }
		std::string getFont() { return font; }

		void seth1FontColor(std::string colorInput) { h1fontColor = colorInput;  std::cout << "\nH1 Color Updated\n";
		}
		std::string geth1FontColor() { return h1fontColor; }

		void setBackgroundColor(std::string bgInput) { backGroundColor = bgInput;  std::cout << "\nBackground Color Updated\n";
		}
		std::string getBackGroundColor() { return backGroundColor; }

		//Returns a string of a finished style tag based off of what the values saved in the a=object are.
		std::string generateStyle() {
			std::string style;
			style = "<style>\n body {font-family: " + font + "; font-size: 12px;}\n h1 {font-weight: normal; font-size: 14px; color: " + h1fontColor +
					"; }\n\n table {border-collapse: collapse; width: 100%;}\ntd,th {border: 1px solid #CCCCCC; text-align: left;" +
					" padding: 8px; }\n\n tr:nth-child(even){\n background-color: " + backGroundColor + ";\n" +
					"}\n</style>";
			outfileDebugLog << "\nFull Style Tag Generated.\n";
			outfileDebugLog2 << "\nFull Style Tag Generated.\n";
			return style;
		}
		~styleSheet(){

		}
};

void combineHTMLText_MitchellJacob(styleSheet styleOutPut, html bodyFeatures, table tableInput) {

	outfileHTML << "<title> Jacob Mitchell </title>\n";
	outfileHTML << "<meta charset = \"UTF-8\">\n";
	outfileHTML << styleOutPut.generateStyle();
	outfileHTML << bodyFeatures.generateHTMLforh1tag(h1FromAssignment);
	outfileHTML << bodyFeatures.generateHTMLforPtag(pFromAssignment);
	outfileHTML << bodyFeatures.generateHTMLforPtag(objectOrientedProgramming);
	outfileHTML << bodyFeatures.generateHTMLforPtag(inheritance);
	outfileHTML << bodyFeatures.generateHTMLforPtag(polymorphism);
	outfileHTML << bodyFeatures.generateHTMLforPtag(cppVscs);
	outfileHTML << "\n<p> Emoji when starting this assignment :  &#128567; Emoji when finishing this assignment: &#129326;</p>\n";

	outfileHTML2 << "<title> Jacob Mitchell </title>\n";
	outfileHTML2 << "<meta charset = \"UTF-8\">\n";
	outfileHTML2 << styleOutPut.generateStyle();
	outfileHTML2 << bodyFeatures.generateHTMLforh1tag(h1FromAssignment);
	outfileHTML2 << bodyFeatures.generateHTMLforPtag(pFromAssignment);
	outfileHTML2 << bodyFeatures.generateHTMLforPtag(objectOrientedProgramming);
	outfileHTML2 << bodyFeatures.generateHTMLforPtag(inheritance);
	outfileHTML2 << bodyFeatures.generateHTMLforPtag(polymorphism);
	outfileHTML2 << bodyFeatures.generateHTMLforPtag(cppVscs);
	outfileHTML2 << "\n<p> Emoji when starting this assignment :  &#128567; Emoji when finishing this assignment: &#129326;</p>\n";
	outfileHTML2 << tableInput.tableBegin();
	outfileHTML2 << tableInput.trBegin();
	outfileHTML2 << tableInput.generateTh();
	outfileHTML2 << tableInput.trEnd();
	outfileHTML2 << tableInput.generateTd();
	outfileHTML2 << tableInput.tableEnd();
	outfileHTML2 << bodyFeatures.generateHTMLforPtag(std::to_string(numRecords) + " entries were processed in this table");


}

int main()
{

	styleSheet style;
	html pageContents;
	table table1;

	//user input of font family, default value tnr
	std::string userFont;
    std::cout << "HTML CREATOR\n" << "Please Input a font-family value to be used in the css style sheet.\n";
    std::cout << "NOTE: Any Incorrect Assignments will default to Times New Roman.\nInput font: ";
	std::getline(std::cin, userFont);
	style.setFont(userFont);

	//user input for h1 color
	std::string userh1Color;
	std::cout << "Please Input a color value (either in the form of '#FFFFFF' or 'colorname') for h1 tags to be used in the css style sheet.\n";
	std::cout << "NOTE: Any Incorrect Assignments will default to Black.\nInput color: ";
	std::getline(std::cin, userh1Color);
	style.seth1FontColor(userh1Color);

	//user input for background color
	std::string userBGColor;
	std::cout << "Please Input a color value (either in the form of '#FFFFFF' or 'colorname') for background to be used in the css style sheet.\n";
	std::cout << "NOTE: Any Incorrect Assignments will default to White.\nInput color: ";
	std::getline(std::cin, userBGColor);
	style.setBackgroundColor(userBGColor);


	std::string heldIn[4];
	std::string contents[200];
	std::string headerInput;
	std::string holdLine;
	int contentCount = 0;
	infile.open("input.csv", std::ifstream::in);
	int i = 0;
	int l = 0;
	if (infile.is_open()) {
		std::string line;
		while (std::getline(infile, line)) {
			
			for (int i = 0; i < 4; i++) {
				heldIn[i] = "";
			}
			if (i == 0) {
				headerInput = line;
				i++;
			}
			else {
				holdLine = line;
				int j = 0;
				for (int k = 0; k < (holdLine.length()); k++) {
					if (holdLine[k] == ',') {
						j++;
						continue;
					}
					else {
						if (j < 4) {
							heldIn[j] += holdLine[k];
						}
					}

				}
			}
			contents[l] = heldIn[0];
			l++;
			contents[l] = heldIn[1];
			l++;
			contents[l] = heldIn[2];
			l++;
			contents[l] = heldIn[3];
			l++;
		}
	}

	std::string header[4];
	std::string headerth;
	int j = 0;
	for (int k = 0; k < headerInput.length(); k++) {
		if (j < 4) {
			if (headerInput[k] == ',') {
				j++;
				continue;
			}
			else {
				header[j] += headerInput[k];
			}
		}

	}

	table1.createTh(header);
	table1.createTd(contents);
	combineHTMLText_MitchellJacob(style, pageContents, table1);

	outfileHTML.close();
	outfileHTML2.close();
	outfileDebugLog.close();
	infile.close();
	system("pause");
	return 0;
}

//Author:			Jacob Mitchell
//ID:				3170506
//Date:				22 April 2020
//Description:		Making HTML Pages through c++ programming and classes