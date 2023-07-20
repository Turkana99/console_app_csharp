using System;

namespace Firstproject

{
   class HelloWorld
{
        static void Main(string[] args)
        {
        //Calculate Average
            double average;
            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third number:");
            double num3 = Convert.ToDouble(Console.ReadLine());
            average = FindAvarage(num1, num2, num3);
            Console.WriteLine("Avarege is " + average);
        }
           static double FindAvarage(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }
}
}