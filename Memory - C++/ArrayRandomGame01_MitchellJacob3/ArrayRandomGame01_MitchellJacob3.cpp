// ArrayRandomGame01_MitchellJacob3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <string>

int grid[4][4] = { -1, -1, -1, -1,-1, -1, -1, -1,-1, -1, -1, -1,-1, -1, -1, -1 };
std::string displayGuess[4][4] = { "X","X","X","X","X","X","X","X","X","X","X","X","X","X","X","X" };
int numsInArray[8] = { -1, -1, -1, -1, -1, -1, -1, -1 };
std::string matches[8] = { "X","X","X","X","X","X","X","X" };

//Function to display the grid of the users guesses
void displayGuessGrid() {
	int counter = 0;
	std::cout << "            1 2 3 4\n\n";
	for (int i = 0; i < 4; i++) {
		counter = 0;
		std::cout << "       " << i + 1 << "    ";
		for (int j = 0; j < 4; j++) {
			std::cout << displayGuess[i][j] << " ";
			counter++;
			if (counter % 4 == 0) {
				std::cout << std::endl;
			}
		}
	}
}
//function that fills the grid
void fillGrid() {
	bool inArray = false, inGrid = false, inGrid2 = false, running = false;
	int counter = 0, randNum, randX, randY, randX2, randY2;

	while (!running) {
		//Declaration of Variables
		running = true;
		inArray = false;
		inGrid = false;
		inGrid2 = false;

		//Random Number Generation to Put in the Array
		randNum = rand() % 9;

		//If the Random Number is in the array already, a bool will be set true that won't allow the rest of the logic to run | loop starts over
		for (int i = 0; i < 4; i++) {
			for (int j = 0; j < 4; j++) {
				if (randNum == grid[i][j]) {
					inArray = true;
				}
			}
		}

		//Logic that runs if the number is not in the array already
		if (!inArray) {
			//A secondary array that helps keep track of what numbers have been used
			for (int i = 0; i < 8; i++) {
				if (numsInArray[i] == -1) {
					numsInArray[i] = randNum;
					break; //break to ensure that the numbers cant be added more than once. 
				}
			}
			//This logic ensures that each number added to the 2d array will be added twice
			while (!inGrid || !inGrid2) {
				//Random X and Y values for the grid
				randX = rand() % 4;
				randY = rand() % 4;
				randX2 = rand() % 4;
				randY2 = rand() % 4;

				//Validation
				if (grid[randX][randY] == -1 && !inGrid) {
					grid[randX][randY] = randNum;
					inGrid = true;
				}
				if (grid[randX2][randY2] == -1 && !inGrid2) { //Validation 2
					grid[randX2][randY2] = randNum;
					inGrid2 = true;
				}
			}
		}
		//Doesnt let application stop until nothing in the grid is one
		for (int i = 0; i < 8; i++) {
			if (numsInArray[i] == -1) {
				running = false;
			}
		}

	}
}

//outputs the grid to the console window
void outputGrid() {
	int counter = 0;
	std::cout << "            1 2 3 4\n\n";
	for (int i = 0; i < 4; i++) {
		counter = 0;
		std::cout << "       " << i + 1 << "    ";
		for (int j = 0; j < 4; j++) {
			std::cout << grid[i][j] << " ";
			counter++;
			if (counter % 4 == 0) {
				std::cout << std::endl;
			}
		}
	}
}

int main()
{

	int guessRow =0, guessCol =0, guessRow2=0, guessCol2=0, success=0, attempts = 0, index =0;
	std::string guess = "empty", guess2 = "empty", lastGuess = "empty";
	bool validated = false, alreadyGuessed = false;
	double percent;
	fillGrid();
	//outputGrid();

	while(success < 8){
		alreadyGuessed = false;
		//VALIDATION FOR GUESS 1 AND GUESS 2
		while (!std::cin.fail()) {
			guess = "empty";
			std::cout << "Please Input A Pair as '#row,#col' to Guess Where the Number is Stored in the Grid\n";

			std::getline(std::cin, guess);
			for (int i = 0; i < 3; i++) {
				if (guess[i] == ',') {
					guessRow = (guess[i - 1] - '0');
					guessCol = (guess[i + 1] - '0');
					displayGuess[guessRow - 1][guessCol - 1] = std::to_string(grid[guessRow - 1][guessCol - 1]);
				}
			}
			if (guessRow == 9 && guessCol == 9) { //validation
				outputGrid();
				std::cin.clear();
			//	while (std::cin.get() != '\n');
				break;
			}
			else if(guessRow < 1 || guessRow > 4 || guessCol < 1 || guessCol > 4){
				std::cout << "Please Enter A Valid Input In the Form of '#Row,#Col' and Try Again.\n\n";
				std::cin.clear();
				//while (std::cin.get() != '\n');
			}
			else {
				lastGuess = guess;
				std::cout << "You Entered " << guessRow << "," << guessCol << ".\n";
				displayGuess[guessRow - 1][guessCol - 1] = std::to_string(grid[guessRow - 1][guessCol - 1]);
				displayGuessGrid();
				break;
			}
		}
		while (!std::cin.fail()) {
			guess2 = "empty";
			std::cout << "Please Input Another Pair as '#row,#col' to Guess Where the Number is Stored in the Grid\n";

			std::getline(std::cin, guess2);
			for (int i = 0; i < 3; i++) {
				if (guess2[i] == ',') {
					guessRow2 = (guess2[i - 1] - '0');
					guessCol2 = (guess2[i + 1] - '0');
					displayGuess[guessRow2 - 1][guessCol2 - 1] = std::to_string(grid[guessRow2 - 1][guessCol2 - 1]);
				}
			}
			if (guessRow2 == 9 && guessCol2 == 9) { //validation
				outputGrid();
				std::cin.clear();
			//	while (std::cin.get() != '\n');
				break;
			}
			else if(guessRow2 < 1 || guessRow2 > 4 || guessCol2 < 1 || guessCol2 > 4 || guess2 == lastGuess){
				std::cout << "Please Enter A Valid Different Input In the Form of '#Row,#Col' and Try Again.\n\n";
				std::cin.clear();
				//while (std::cin.get() != '\n');
			}
			else {
				std::cout << "You Entered " << guessRow2 << "," << guessCol2 << ".\n";
				displayGuess[guessRow2 - 1][guessCol2 - 1] = std::to_string(grid[guessRow2 - 1][guessCol2 - 1]);
				displayGuessGrid();
				break;
			}
		}
	
		if (displayGuess[guessRow - 1][guessCol - 1] == displayGuess[guessRow2 - 1][guessCol2 - 1] && displayGuess[guessRow -1][guessCol -1] != "X" && guessRow != 9 && guessCol != 9 && guessRow2 != 9 && guessCol2 != 9) {
			for (int i = 0; i < 8; i++) {
				if (displayGuess[guessRow - 1][guessCol - 1] == matches[i]) {
					std::cout << "You have already guessed this pair.\n";
					alreadyGuessed = true;
					index = i;
				}
			}
			if (!alreadyGuessed) {
				success++;
				attempts++;
				std::cout << "You Have Guessed A Matching Pair!\n";
				for (int i = 0; i < 8; i++) {
					if (matches[i] == "X") {
						matches[i] = displayGuess[guessRow - 1][guessCol - 1];
						break;
					}
				}
			}
			percent = (double)success/(double)attempts; 
			std::cout << "You have succeeded " << success << " time(s) in " << attempts <<" attempts at a " << percent * 100 << "% rate.\n";
			std::cout << "So far you have guessed ";
			int j = 0;
			while (matches[j] != "X" && j < 8) {
				std::cout << matches[j] << ", ";
				j++;
			}
			if (matches[0] == "X") {
				std::cout << "no pairs ";
			}
			std::cout << "correctly.\n";
		}
		else {
			attempts++;
			std::cout << "You Have Guessed Incorrectly :-( \n";
			std::cout << "So far you have guessed ";
			int j = 0;
			while (matches[j] != "X" && j < 8) {
				std::cout << matches[j] << ", ";
				j++;
			}
			if (matches[0]=="X") {
				std::cout << "no pairs ";
			}
			std::cout << "correctly.\n";
			percent = (double)success/(double)attempts; 
			std::cout << "You have succeeded " << success << " time(s) in " << attempts << " attempts at a " << percent * 100 << "% rate.\n";
		}
	}
	std::cout << "CONGRATULATIONS! YOU HAVE GUESSED ALL PAIRS!"; //FINALLLLLLLY
	system("pause");
	return 0;
}
//AUTHOR:			JACOB MITCHELL
//ID:				3170506
//DATE:				2/22/2020
//DESCRIPTION:		A GAME OF MATCHING PAIRS. THE USER INPUTS COORDINATE GRIDS TO GUESS WHERE THE MATCHES ARE UNTIL
//					THEY SUCCESSFULLY GUESS ALL 8