using System;

namespace Firstproject

{
   class HelloWorld
{
        static void Main(string[] args)
        {
        //Operator example 3
            int a = 6;
            int b = 5;
            int c = 4;
            int d = 3;
            int e = 2;

            int result = a-- * --b + e++ / c - ++d / a * b++ - --e * c;
            Console.WriteLine("Initial value {0} {1} {2} {3} {4}", a, b, c, d, e);
            Console.WriteLine("Result:" + result);

    }
    }

}



