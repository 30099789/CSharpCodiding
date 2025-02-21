using System;

namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to convert Fahrenheit to Celsius? Enter 1.");
            Console.WriteLine("Or do you want to convert Celsius to Fahrenheit? Enter 2.");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input. Please enter 1 or 2.");
                return;
            }

            Console.WriteLine("Enter the temperature:");
            if (!double.TryParse(Console.ReadLine(), out double temp))
            {
                Console.WriteLine("Invalid temperature input.");
                return;
            }

            if (choice == 1)
            {
                double celsius = (5.0 / 9.0) * (temp - 32);
                Console.WriteLine($"Temperature in Celsius: {celsius:F2}");
            }
            else if (choice == 2)
            {
                double fahr = (temp * 9.0 / 5.0) + 32;
                Console.WriteLine($"Temperature in Fahrenheit: {fahr:F2}");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please restart the program and enter 1 or 2.");
            }
        }
    }
}