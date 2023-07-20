using System;

namespace Firstproject

{
   class HelloWorld
{
        static void Main(string[] args)
        {
        //Conversion method
            int a = 5;
            float b = 4;
            double c= 10.4;
            string d= "test";
            string e = "19";
            bool f = true;
            double n = 9.5;

            double g = Convert.ToDouble(a);
            Console.WriteLine(g);
            int h = Convert.ToInt32(b);
            Console.WriteLine(h);
            //int t = Convert.ToInt32(d);
            //Console.WriteLine(t);
            int y = Convert.ToInt32(e);
            Console.WriteLine(y);
            string s = Convert.ToString(f);
            Console.WriteLine(s);
            string m = Convert.ToString(n);
            Console.WriteLine(m);
        }
}
}