
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
                double area = length * width;
                double perimeter = length * 2 + width * 2;

                PrintOutput(area, perimeter);

                Console.Write("Continue? y/n: ");
                input = Console.ReadLine();
            } while (input == "Y" || input == "y");


        }

        static void PrintOutput(double area, double perimeter)
        {
            Console.WriteLine($"Area: {area}");
            Console.WriteLine($"Perimeter: {perimeter}");
            RoomSize(area);
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
            total = feet = inches;
            return total;
        }
    }
}
