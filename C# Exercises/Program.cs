//Program Name:             Chapter 7 Exercises
//Program Description:      IntReverse, PrimeCheck, Reduce, Power (Programs defined in their method headers)
//Date Written:             10/14/19
//Programmer:               Jacob Mitchell

using System;

namespace MultiProjectTemplateV2
{
    public class Program
    {
        //Change these values to reflect the chapter number
        //you are doing the exercises for and the total
        //number of exercises:
        private const int ChapterNumber = 7;
        private const int NumberOfPrograms = 4;

        private static string programListString = string.Empty;

        public static void Main(string[] args)
        {
            int progNumIn = 0;

            //Hard loop to keep prompting user for program number to run.
            while (true)
            {
                //Display banner for which chapter we are running:
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($" =========================== \n Ch 0{ChapterNumber:n0} Programming Exercises \n =========================== ");

                //Call the static Console ReseColor method to reset the console colors to defaults.
                Console.ResetColor();

                //Prompt the user for the program number they wish to run.  0 lets them clear the screen,
                //-1 lets them exit the program:
                Console.WriteLine("\nAvailable commands:\n");

                //Padding string to use in the numbers string:
                string paddingString = string.Empty;

                //Clear the program list string:
                programListString = string.Empty;

                //Generate program numbers string:
                for (int i = 1; i <= NumberOfPrograms; i++)
                {
                    if (i == 1)
                    {
                        paddingString = string.Empty;
                    }
                    else if (i == NumberOfPrograms)
                    {
                        paddingString = ", or ";
                    }
                    else
                    {
                        paddingString = ", ";
                    }

                    //Build up the program list string:
                    programListString = $"{programListString}{paddingString}{ChapterNumber:n0}{i:n0}";
                }

                //Display menu:
                Console.WriteLine($" > Type a program number ({programListString}) and press 'Enter'.");
                Console.WriteLine($" > Type '0' and press 'Enter' key to clear the screen.");
                Console.WriteLine($" > Type '-1' and press the 'Enter' key to exit the program.");
                Console.Write($"\nPlease choose a command: ");

                //If the input is not an integer, then go back and prompt user again for program number.
                if (!int.TryParse(Console.ReadLine(), out progNumIn))
                {
                    continue;
                }

                //If user enters -1, then break out of the loop, which ends Main (and thus the program).
                //If user enters 0, then clear the screen and continue the loop:
                if (progNumIn == -1)
                {
                    break;
                }
                else if (progNumIn == 0)
                {
                    Console.Clear();
                    continue;
                }
                else if (progNumIn < ((ChapterNumber * 10) + 1) || progNumIn > ((ChapterNumber * 10) + NumberOfPrograms)) //If invalid program number, go back to main menu.
                 {
                    continue;
                }

                //This is pretty crude, but in order to dynamically call the appropriate method from
                //a built-up string, we would have to use System.Reflection, which I really do not
                //want to do here:
                if (progNumIn == ((ChapterNumber * 10) + 1))
                {
                    RunProgram1();
                    continue;
                }
                else if (progNumIn == ((ChapterNumber * 10) + 2))
                {
                    RunProgram2();
                    continue;
                }
                else if (progNumIn == ((ChapterNumber * 10) + 3))
                {
                    RunProgram3();
                    continue;
                }
                else if (progNumIn == ((ChapterNumber * 10) + 4))
                {
                    RunProgram4();
                    continue;
                }
                else //just in case
                {
                    continue;
                }
            }
        }

        //Static method for program 1 code.
        private static void RunProgram1()
        {
            //Change Console Background Color to Blue.
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine($"\n ~~~~~~~~~~~~~~~~~~~~ \n Running Program  {((ChapterNumber * 10) + 1):n0}  \n ~~~~~~~~~~~~~~~~~~~~ \n");
            Console.WriteLine("A Program that reverses the order of an integer value.");
            String length;
            Boolean check = false;
            int num = 0;

                while (!check)
                {
                    Console.WriteLine("Please enter an integer to be reversed:");
                    length = Console.ReadLine();

                    check = int.TryParse(length, out num);
                    if (!check)
                    {
                        Console.WriteLine("Please input an integer value and try again");
                    }
                }
            
            Console.WriteLine("The number input was: " + num.ToString());
            Console.WriteLine("That value in reverse order is: " + ReverseInt(num).ToString());

        }

        public static int ReverseInt(int arg) //A method that inputs an argument and returns that value chronologically reversed
        {;
           //This uses the logic of the mod and division operators for ints. If a number is mod by ten, it is equal to the last number of the inputed number.
           int reverse = 0, temp;

           while(arg != 0)
            {
                temp = arg % 10;
                reverse = reverse * 10 + temp;
                arg /= 10;
            }

            return reverse;
        }

        //Static method for program 2 code.
        private static void RunProgram2()
        {
            //Change Console Background Color to DarkGreen.
            Console.BackgroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine($"\n ~~~~~~~~~~~~~~~~~~~~ \n Running Program  {((ChapterNumber * 10) + 2):n0}  \n ~~~~~~~~~~~~~~~~~~~~ \n");
            Console.WriteLine("This program takes an int of 3 or greater and returns an integer array that contains the results of the check.");
            //Very simple client code to test PrimeCheck.

            int testInt = 0;
            string input;
            //Create the reference variable for the array
            //that the PrimeCheck method will return.
            int[] returnedArray;

            //Prompt the user to enter the integer to test.
            Boolean check = false;
            while (!check)
            {
                Console.Write($"Please enter integer to process through PrimeCheck: ");
                input = Console.ReadLine();
                check = int.TryParse(input, out testInt);
                if (!check)
                {
                    Console.WriteLine("Please input an integer value and try again");
                }
            }

            //Call PrimeCheck and load the pointer to the
            //returned array in our array reference variable.
            returnedArray = PrimeCheck(testInt);

            //If the returned array element at index zero is equal
            //to the integer we are testing, the the integer IS PRIME
            //we write out a console message to that effect.
            if (returnedArray[0] == testInt)
            {
                Console.WriteLine($"\nThe integer {testInt:n0} IS PRIME.");

                Console.ReadLine();

                //We are done, so we can return early.
                return;
            }

            //If we get here, then the integer IS NOT PRIME, so we need to iterate
            //through the returned array and write the messagae and divisors to the
            //console.
            Console.Write($"\nThe integer {testInt:n0} IS NOT PRIME, its factors are ");

            for (int i = 0; i < returnedArray.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write($"{returnedArray[i]}"); //Don't print a leading comma if first divisor.
                }
                else
                {
                    Console.Write($", {returnedArray[i]}"); //Print leading comma for all other divisors.
                }
            }

            //Add a period to the end of the console message.
            Console.WriteLine($".");

            Console.ReadLine();
        
        }

        public static int[] PrimeCheck(int numToCheck)
        {
            //We can divide the number we are checking by two and use
            //that as the upper limit in our loop because half of
            //the number could possibly be multiplied by two
            //to get the original number, but any value greater than
            //half could only be multiplied by something less than
            //two, and we cannot have a divisor that is less than two.
            int upperDivisorLimit = numToCheck / 2;

            //Counter of divisors to use for the return
            //array length.
            int arrayLength = 0;

            //The reference variable for our return array.
            //Note that all this does is create the reference
            //variable (the "box") that will eventually
            //hold a pointer to the actual array on the heap.
            int[] arrayToReturn;

            //This is the index we will use to load the return
            //array values.  We set it to -1 since the array
            //is zero based and we will just increment it by
            //one each time we load a divisor.  To illustrate,
            //during the first pass where we find a divisor,
            //the index will be -1.  We will increment it by
            //1 and that will make the index -1 + 1 = 0 which
            //is the correct index we need to point to the first
            //array element position.
            int currentIndex = -1;

            //First loop to determine just how many elements
            //the array will hold.  As crude as this is, it is
            //what we need to do here in order to find out how
            //many elements our array should actually contain.
            for (int i = 2; i <= upperDivisorLimit; i++)
            {
                if (numToCheck % i == 0)
                {
                    arrayLength++;
                }
            }

            //If there were no divisors (the integer IS PRIME), then we
            // only need to create an array with one element and load
            //it with the integer we are checking (based on the project instructions).
            if (arrayLength == 0)
            {
                //Create an array object with just one element:
                arrayToReturn = new int[1];


                //Load that first array element with the integer we are checking:
                arrayToReturn[0] = numToCheck;

                //We are done, so we can immediately
                //return the array.
                return arrayToReturn;
            }

            //If we get here, the integer we are checking IS NOT PRIME
            //(has divisors besides 1 and the integer itself) so we
            //create the return array with a size equal to the number
            //of divisors.
            arrayToReturn = new int[arrayLength];

            //Second loop to actually load the divisors into
            //the return array.
            for (int i = 2; i <= upperDivisorLimit; i++)
            {
                if (numToCheck % i == 0)
                {
                    currentIndex++;

                    arrayToReturn[currentIndex] = i;
                }
            }

            //Once we drop out of the second loop, we have fully
            //loaded the return array and we can now return it
            //to the caller.
            return arrayToReturn;
        }
        //Static method for program 3 code.
        private static void RunProgram3()
        {
            //Change Console Background Color to Red.
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine($"\n ~~~~~~~~~~~~~~~~~~~~ \n Running Program  {((ChapterNumber * 10) + 3):n0}  \n ~~~~~~~~~~~~~~~~~~~~ \n");

            Console.WriteLine("A program that checks if an inputed value is reducable and outputs true or false and references the inputed numbers.");

            bool check = false, check2 = false, reducable;
            string first, second;
            int numerator =0, denominator =0;
            while (!check || !check2) /*Data Validation*/
            {
                Console.WriteLine("Please enter a non- zero numerator: ");
                first = Console.ReadLine();
                Console.WriteLine("Please enter a non- zero denominator: ");
                second = Console.ReadLine();

                check = int.TryParse(first, out numerator);
                check2 = int.TryParse(second, out denominator);

                if (!check || numerator == 0)
                {
                    Console.WriteLine("Please enter a nonzero integer value for the numerator and try again.");
                    check = false;
                }
                if (!check2 || denominator == 0)
                {
                    Console.WriteLine("Please enter a nonzero integer value for the denominator and try again.");
                    check2 = false;
                }
            }
            reducable = Reduce(ref numerator, ref denominator);

            if(numerator < 0 && denominator < 0) /*If statement to make it so that if both the numerator and denominator are negative, they become positive*/
            {
                numerator *= -1;
                denominator *= -1;
            }

            if (reducable)/*Outputs the values for a reducable fraction*/
            {
                Console.WriteLine(numerator.ToString() + "/" + denominator.ToString() + " is a reducable fraction.");
            }else if (!reducable)/*Outputs the values for a non-reducable fraction*/
            {
                Console.WriteLine(numerator.ToString() + "/" + denominator.ToString() + " is a not reducable fraction.");
            }




        }
        public static bool Reduce(ref int arg1, ref int arg2) //A method that checks if an inputed value is reducable and outputs true or false and references the inputed numbers.
        {
            int argGreatest = 0;
            bool isReducable = false;
            if (arg1 > arg2) /*Check for the loop to set the value in which marks the highest loop of the for loop*/
            {
                argGreatest = arg1;
            }
            else
            {
                argGreatest = arg2;
            }

            if(argGreatest < 0)
            {
                argGreatest *= -1; /*This is because the foor loop will not work if the greatest arg is negative, but this does not effect referenced parameters*/
            }

            for(int i = 2; i < argGreatest; i++)/*If both integers are modded by i and = 0, they can be reduced*/
            {
                if(arg1 % i == 0 && arg2 % i == 0)
                {
                    arg1 /= i;
                    arg2 /= i;
                    isReducable = true;
                }
            }
            return isReducable;
        }
        //Static method for program 4 code.
        private static void RunProgram4()
        {
            //Change Console Background Color to Red.
            Console.BackgroundColor = ConsoleColor.Red;

            Console.WriteLine($"\n ~~~~~~~~~~~~~~~~~~~~ \n Running Program  {((ChapterNumber * 10) + 4):n0}  \n ~~~~~~~~~~~~~~~~~~~~ \n");

            Console.WriteLine("A method that takes in a base parameter (int >= 1) and an exponent parameter (int >= 1) and returns a LONG that is the base taken to the exponent.");

            string baseCheck, expCheck;
            int pBase = 0, exponent = 0;
            bool check = false, check2 = false;

            while (!check) /*Data validation for inputed data. Must be integer of at least 1.*/
            {
                Console.WriteLine("Please enter a base number: ");
                baseCheck = Console.ReadLine();
                Console.WriteLine("Please enter an exponent: ");
                expCheck = Console.ReadLine();

                check = int.TryParse(baseCheck, out pBase);
                check2 = int.TryParse(expCheck, out exponent);

                if(!check || pBase < 1)
                {
                    Console.WriteLine("Please enter an integer value of at least 1 for the base.");
                    check = false;
                }
                if(!check2 || exponent < 1)
                {
                    Console.WriteLine("Please enter an integer value of at least 1 for the exponent.");
                    check2 = false;
                }

            }
            Console.WriteLine(pBase.ToString() + " to the power of " + exponent.ToString() + " is equal to " + Power(pBase, exponent).ToString() + ".");

        }

        public static long Power(int baseArg, int exponentArg)/*A method that takes a base and an exponent and calculates it. */
        {
            long answer = 1; 
            for(int i = 1; i < exponentArg + 1; i++)
            {
                answer *= (long)baseArg;
            }

            return answer;
        }
    }
}
