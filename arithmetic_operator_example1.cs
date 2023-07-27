using System;

namespace Firstproject

{
   class HelloWorld
{
        static void Main(string[] args)
        {
        //Operator example 1
            int x = 24;
            int y = 13;
            int z = (x+y)/2 + y++ + ++y +2*(x--*4);
            int w = z++ + (w=y) - --w;
            Console.WriteLine("{0} {1} {2} {3}", x,y,z,w);
            Console.ReadLine();
        }

    }
    }




