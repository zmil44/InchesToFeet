/*Zachary Miller
 * 11/26/2017
 * assignment 4.2
 * The purpose of this program is to take a user input of inches and display that same length in feet and inches
 * InchesToFeet.cs
 * Bellevue University
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assingment_4._2
{
    class InchesToFeet
    {
        static void Main(string[] args)
        {
            int input = getInput();
            int feet = calculateFeet(input);
            int inches = calculateInches(input);
            displayOutput(input, feet, inches);
            Console.Read();
        }

        private static int getInput()
        {
            int inches=0;
            Boolean correctInput;
            
            do
            {
                Console.Write("Please enter a length in inches: ");
                string input = Console.ReadLine();
                try
                {
                    inches = int.Parse(input);
                    correctInput = true;
                }
                catch (FormatException)
                {
                    correctInput = false;
                    Console.WriteLine("\n I'm sorry but the number you entered is invalid. Please enter a valid number greater than 0 in number format. EX: 250. \n");
                }
                catch (OverflowException)
                {
                    correctInput = false;
                    Console.WriteLine("\n I'm sorry but the number you entered is invalid. Please enter a valid number greater than 0 in number format. EX:");
                }
            } while (correctInput == false && inches>0);
            return inches;
        }

        private static int calculateFeet(int input)
        {
            int feet = input / 12;
            return feet;
        }

        private static int calculateInches(int input)
        {
            int inches = input % 12;
            return inches;
        }

        private static void displayOutput(int input, int feet, int inches)
        {
            Console.WriteLine("{0} inches is equivalent to {1} feet {2} inches.", input, feet, inches);
        }
    }
}
