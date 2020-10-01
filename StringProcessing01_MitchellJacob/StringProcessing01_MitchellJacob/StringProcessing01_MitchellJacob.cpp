// StringProcessing01_MitchellJacob.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>

int main()
{
	std::string input, word, direction;

	while (input != "x") {
		input = "";
		word = "";
		direction = "";
		std::cout << "Please input a word or a variety of characters, a Space, followed by \"forward\" or \"backward\".\nPress X to Exit!\n";
		std::getline(std::cin, input);

		//Splits the input into two variables dictated by the space
		for (int i = 0; i < input.length(); i++) {
			if (input[i] == ' ') {
				for (int j = 0; j < i; j++) {
					word += input[j];
				}
				for (int k = i + 1; k < input.length(); k++) {
					direction += input[k];
				}
			}
		}
		//Leave the loop if user enters x
		if (input == "x") {
			break;
		}

		//Logic Forwards
		if (direction == "forward" || direction == "Forward") {
			for (int i = 0; i < word.length(); i++) {
				if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U') {
					std::cout << word[i] << "*" << std::endl;
				}
				else {
					std::cout << word[i] << std::endl;
				}
			}
		}
		//Logic Backwards
		else if(direction == "backward" || direction == "Backward"){
			for (int i = word.length(); i > -1; i--) {
				if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u' || word[i] == 'A' || word[i] == 'E' || word[i] == 'I' || word[i] == 'O' || word[i] == 'U') {
					std::cout << word[i] << "*" << std::endl;
				}
				else {
					std::cout << word[i] << std::endl;
				}
			}
		}
		//Logic if anything else
		else {
			std::cout << direction;
			std::cout << "\nPlease Input the correct spelling of the direction and try again.\n";
		}
	}
	system("pause");
	return 0;
}

//AUTHOR:			JACOB MITCHELL
//ID:				3170605
//DATE:				28 JANUARY 2020
//DESCRIPTION:		PROGRAM THAT ALLOWS THE USER TO INPUT A WORD AND A DIRECTION AND OUTPUTS IT LETTER PER LINE WHAT THEY INPUT + IF ITS A VOWEL ADDS AN ASTRICT
