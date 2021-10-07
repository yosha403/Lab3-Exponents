using System;

//DevBuild Lab3 : Exponents/Powers Table
//Author: Yosha Kunnummal
//Date: 10/07/2021


namespace Exponents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learn your squares and cubes!");
            bool goOn = true;
            while (goOn == true)
            {
                //Try-catch block to catch errors if we enter an invalid input
                try
                {

                    //Getting the user input from console
                    string input = GetInput("\nEnter an integer:");
                    int number = int.Parse(input);

                    //Check whether the entered number is 0 or a negative number
                    if (number > 0)
                    {
                        ulong cubeCheck = (ulong)GetCube(number);

                        //Check whether the cube of the entered number exceeds the maximum value an integer can hold
                        if (cubeCheck < Int32.MaxValue)
                        {
                            Console.WriteLine("\nNumber\t\tSquared\t\tCubed");
                            Console.WriteLine("=======\t\t=======\t\t=======");
                            for (int i = 1; i <= number; i++)
                            {
                                int square = GetSquare(i);
                                int cube = GetCube(i);
                                Console.WriteLine($"{i,5}\t\t{square,5}\t\t{cube,5}");

                            }
                        }
                        else
                        {
                            Console.WriteLine("You entered a number whose cube cannot be stored in an integer variable.Please input a lesser value!");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number\n");
                    }
                    goOn = Continue();
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        //A method to get input from console
        public static string GetInput(string prompt)
        {
            Console.Write(prompt);
            string output = Console.ReadLine().ToLower();

            return output;
        }

        //A method to check whether the user agrees to continue the application
        public static bool Continue()
        {
            string answer = GetInput("\nWould you like to continue? y/n: ");

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                Console.WriteLine("Goodbye!");
                return false;
            }
            else
            {
                Console.WriteLine("\nI'm sorry, I didn't understand ");
                Console.WriteLine("Please try again");

                //This is recursion, calling a method inside itself
                return Continue();
            }
        }

        //A method to find the square of a number
        public static int GetSquare(int number) 
        {        
            int squaredNum = number * number;
            return squaredNum;                       
        }

        //A method to find the cube of a number
        public static int GetCube(int number)
        {
            int cubedNum = number * number * number;
            return cubedNum;
        }
    }
}
