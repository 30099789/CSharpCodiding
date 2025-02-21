using System;
using System.Reflection.Metadata.Ecma335;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Math Calculator\n1.Addition\n2.Subtration\n3.Multiplication\n4.Division\n5.Exponentiation\n6.Root\n7.Percentage.\n8.Exit");
                if (!int.TryParse(Console.ReadLine(), out int option) || option < 1 || option > 8)
                {
                    Console.WriteLine("Choose a valid option");
                    continue;
                }
                if (option == 8)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                Console.WriteLine("Set a number:");
                if (!float.TryParse(Console.ReadLine(), out float num1))
                {
                    Console.WriteLine("Set a valid number");
                }
                Console.WriteLine("Set a number:");
                if (!float.TryParse(Console.ReadLine(), out float num2))
                {
                        Console.WriteLine("Set a valid number");
                }
                double res = 0;

                switch (option)
                {
                    case 1:
                        res = num1 + num2;
                        break;

                    case 2:
                        res = num1 - num2;
                        break;

                    case 3:
                        res = num1 * num2;
                        break;

                    case 4:
                        if (num2 == 0)
                        {
                            res = num1 / num2;
                            Console.WriteLine("ERROR");
                        }
                        res = num1 / num2;
                        break;

                    case 5:
                        res = Math.Pow(num1,num2);
                        break;

                    case 6:
                        res = Math.Pow(num1,(1 / num2));
                        break;

                    case 7:
                        res = num1 * (num2 / 100);
                        break;

                }
                Console.WriteLine(res);
            }
        }
        static double GetValidNumber(string prompt)
        {
            double number;
            while (true)
            {
                Console.Write(prompt);
                if (double.TryParse(Console.ReadLine(), out number))
                {
                    return number;
                }
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}

