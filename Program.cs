
using System;

namespace RoomCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Lab 2.1 Task: 
             Calculate the perimeter and area of various classrooms at Grand Circus
            */

            double length;
            double width;
            double height;
            string input;

            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            Console.WriteLine();

            do
            {
                input = "N";
                Console.WriteLine("Please Enter the Length of the room");
                length = GetMeasurement();
                Console.WriteLine("Please Enter the Width of the room");
                width = GetMeasurement();
                Console.WriteLine("Please Enter the Heigth of the room");
                height = GetMeasurement();

                double area = length * width;
                double perimeter = length * 2 + width * 2;
                double volume = height * area;
                
                PrintOutput(area, perimeter, volume);

                Console.Write("Continue? y/n: ");
                input = Console.ReadLine();
            } while (input == "Y" || input == "y");
            Console.WriteLine();
            Console.WriteLine("Thank you for using the Room Detail Generator!");

        }

        static void PrintOutput(double area, double perimeter, double volume)
        {
            Console.WriteLine($"Area: {area}sqft");
            Console.WriteLine($"Perimeter: {perimeter}ft");
            RoomSize(area);
            Console.WriteLine($"Volume: {volume} cubic feet");
            Console.WriteLine();
        }

        static void RoomSize(double area)
        {
            string Size;
            if (area < 250)
            {
                Size = "small";
            }
            else if (area < 650)
            {
                Size = "medium";
            }
            else
            {
                Size = "large";
            }
            Console.WriteLine($"This is a {Size}-sized Room.");

        }
        static public double GetMeasurement()
        {
            double feet;
            double inches;
            double total;
            Console.Write("Feet: ");
            string Entry = Console.ReadLine();
            feet = double.Parse(Entry);
            Console.Write("Inches: ");
            Entry = Console.ReadLine();
            inches = double.Parse(Entry);

            inches = inches / 12;
            total = feet + inches;
            return total;
        }
    }
}
