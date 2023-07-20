using System;

namespace Firstproject

{
   class HelloWorld
{
        static void Main(string[] args)
        {
        // Calculate Temperature
            Console.WriteLine("Please, enter temperature(C):");
            int temp = Convert.ToInt32(Console.ReadLine());
            double result = CalculateTemperature(temp);
            Console.WriteLine("Temperature is " + result+"F");
        }
         static double CalculateTemperature(int a)
        {
            return a * 73.8;
        }
}
}