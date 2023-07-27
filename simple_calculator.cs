using System;

namespace Firstproject

{
   class HelloWorld
{
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Calculator!");

            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operation type (+, -, *, /): ");
            char operation = Convert.ToChar(Console.ReadLine());

            double result = 0;

            switch (operation)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                        result = num1 / num2;
                    else
                        Console.WriteLine("This is wrong!");
                    break;
                default:
                    Console.WriteLine("You are entered wrong operation type");
                    break;
            }

            Console.WriteLine("Result: " + result);

            Console.WriteLine("Press ENTER to exit the calculator.");
            Console.ReadLine();

        }

    }
    }




