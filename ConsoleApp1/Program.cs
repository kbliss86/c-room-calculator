using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
Room Calculator

Objectives:
- Strings
- Numbers
- Calculations
- Input

Task:
Calculate the perimeter and area of a room based on user input.
*/

            /*
            What the Application Will Do:
            1. Prompt the user to enter values for the length and width of the room.
            2. Calculate and display the area and perimeter of the room.
            3. Classify the room based on its area:
               - Small (up to and including 250 square feet)
               - Medium (more than 250 but less than 650 square feet)
               - Large (650 square feet or more)
            */

            /*
            Build Specifications:
            - Assume the rooms are rectangular (90-degree corners).
            - Assume the user will enter valid numeric data for length and width.
            - The application should accept decimal entries.
            */

            /*
            Additional Requirements:
            - Ensure you answer the Lab Summary when submitting to the LMS.
            - Deduct 2 points if there are syntax errors or the program does not run (for example, in the Main method).
            */

            /*
            Hints:
            Make sure you use the correct formulas for area and perimeter.
            */

            /*
            Extra Challenges:
            - Calculate the volume of the rooms.
            - Calculate the surface area of the rooms.
            */

            /*
            Example Console Preview:

            Welcome to Grand Circus’ Room Detail Generator!

            Enter Length: {user input here, for example: 24.5}
            Enter Width: {user input here, for example: 20}
            Area: {calculated: 490}
            Perimeter: {calculated: 89}
            {calculated: This is a medium-sized room.}

            Thank you for using the Room Detail Generator!
            */

            //----------Begin Code---------------//
            //Declare Variables
            bool input1;
            bool input2;
            double roomLength;
            double roomWidth;
            //Prompt User
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator");
            //Do while to validate user input at a double
            do
            {
                Console.WriteLine("Please enter the room length: ");
                string userInput = Console.ReadLine();
                //Will "try" to parse the user input and return true if it is, if it is true, then the userInput value is assigned to roomLength variable
                input1 = double.TryParse(userInput, out roomLength);

                if (!input1)
                {
                    Console.WriteLine("Please enter a valid number: ");
                } 

            } while(!input1);
            //Respond with user input
            Console.WriteLine($"You have entered {roomLength} as the length of the room!");
            //Do while to validate user input at a double
            do
            {
                //Prompt User
                Console.WriteLine("Please enter the room width: ");
                string userInput2 = Console.ReadLine();
                //Will "try" to parse the user input and return true if it is, if it is true, then the userInput value is assigned to roomLength variable
                input2 = double.TryParse(userInput2, out roomWidth);

                if (!input2)
                {
                    Console.WriteLine("Please enter a valid number: ");
                }
            } while (!input2);
            //Respond with user input
            Console.WriteLine($"You have entered {roomWidth} as the width of the room");

            //Calculate Area - Length time Width
            double roomArea = roomLength * roomWidth;
            //Calculate Perimeter - add all 4 sides
            double roomPerimeter = (roomLength * 2) + (roomWidth * 2);

            Console.WriteLine($"The Perimeter of the room is {roomPerimeter}!");
             if (roomArea <= 250)
            {
                Console.WriteLine($"A room with an area of {roomArea} is a small room");
            }
             else if (roomArea < 250 && roomArea > 600)
            {
                Console.WriteLine($"A room with an area of {roomArea} is a medium room");
            }
             else
            {
                Console.WriteLine($"A room with an area of {roomArea} is a large room");
            }

             //Calcualte the volume of the room
             //Assuming 9 foot ceilings L * W * H
             double roomVolume = roomLength * roomWidth * 8;
            Console.WriteLine($"The room volume is {roomVolume}!");

            //Calculate the surface are of the room
            //Surface Area is 2WL + 2LH + 2 HW
            double roomSurfaceArea = ((roomWidth * roomLength) * 2) + ((8 * roomLength) * 2) + ((8 * roomWidth) * 2);
            Console.WriteLine($"The room has a surface area of {roomSurfaceArea}!");
            //Stops Code
            Console.ReadLine();

            //----------End Code-----------------//
        }//End Main
    }//End Class
}//End NameSpace
