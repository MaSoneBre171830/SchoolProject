using System;
using System.Reflection.Metadata.Ecma335;

namespace ArbeitsAuftrag
{
    class Program
    {
        static void Main(string[] args)
        {
        Restart:

            int Number;
            //reapeats the asking the user for the "Number" if the number is <= 0
            do
            {
                // asks the user for a number to be converted later
                Console.Write("Input a number to convert to a Roman numeral: ");
                Number = Convert.ToInt32(Console.ReadLine());

                // error message if the "Number"  is <= 0
                if (Number <= 0)
                {
                    // the error message
                    Console.WriteLine("ALOOOO BREE!!!");
                    Console.WriteLine("Please put a number greater then 0!!");  

                    // clears the console to ask the user again
                    Thread.Sleep(3000);
                    Console.Clear();
                }

            } while (Number <= 0);

            // calls the NumToRoman funktion and prints the result
            // using the nmber that the user inputed
            Console.WriteLine(NumToRoman(Number));

            // asks the user if they want to restart the program
            Console.WriteLine("Do you want to try again? Y/N"); 
            string input = Console.ReadLine();

            //check the user input and restart from the top again
            if (input.ToUpper() == "Y")
            {
                Console.Clear(); goto Restart;
            }
            else { Console.WriteLine("------------END!!!------------"); }
                

        }

        static string NumToRoman(int number) 
        {

            Dictionary<string, int> RomanNums = new Dictionary<string, int>
            {
                {"M", 1000 },
                {"CM", 900 },
                {"D", 500 },
                {"CD", 400 },
                {"C", 100 },
                {"XC", 90 },
                {"L", 50 },
                {"XL", 40 },
                {"X", 10 },
                {"IX", 9 },
                {"V", 5 },
                {"IV", 4 },
                {"I", 1 }
            };

            // an empty string variable to store the roman numerals
            string Result = "";

            // goes through the dictionary
            foreach (var rom in RomanNums)
            {
                // stops the program from going to negative numbers
                // and stops it from printing the wrong roman numeral
                while (number >= rom.Value)
                {
                    // saves the roman numeral('M', 'X', 'I', etc...) in the "Result" string
                    Result += rom.Key;
                    // makes "number" smaller so the program finishes 
                    // and stop the program to keep printing the same roman numeral 
                    number -= rom.Value;
                }
            }

            // return the result(roman numerals)
            return Result;
        }
    }
}
