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
}
}