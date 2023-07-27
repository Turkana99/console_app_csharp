using System;

namespace Firstproject

{
   class HelloWorld
{
        static void Main(string[] args)
        {
        //Operator example 2
            int a = 3;
            int b = 5;
            int c = 7;
            int d = 2;
            int e = 4;

            double result = a++ + --b * c - e-- + ++d / a + b-- * c / e;
            Console.WriteLine("Initial value {0} {1} {2} {3} {4}", a, b, c, d, e);
            Console.WriteLine("Result:" + result);

    }
    }

}

