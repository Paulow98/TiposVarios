using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposVarios
{
    class Program
    {

        static void Main(string[] args)
        { 
            
            uint ui = 12013U;
            int i = 100;
            long l = 123L;
            ulong ul = 3UL;
            Console.WriteLine(ui);
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(ul);       
            Console.WriteLine();

            char a = '\u00BC';
            char b = '\u00A2';
            char c = '\u00B6';
           
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine();

            float fa = 1.3f;
            float fb = 2.4f;
            float fc = 55512.34f;
            double d = 1312;
            decimal de = 3.13m;

            Console.WriteLine(fa);
            Console.WriteLine(fb);
            Console.WriteLine(fc);
            Console.WriteLine(d);
            Console.WriteLine(de);
            Console.WriteLine();

            bool ba = true;
            bool bb = false;

            Console.WriteLine(ba);
            Console.WriteLine(bb);
            Console.WriteLine();

            string sa = "teste1";
            string sb = " \u00BC  = 10 \t \u00BD = 20";
            string sc = "A\tE\tS\tT\tH\tE\tT\tI\tC\tS";
            string sd = @"\n so que nao";

            Console.WriteLine(sa);
            Console.WriteLine(sb);
            Console.WriteLine(sc);
            Console.WriteLine(sd);
            Console.WriteLine();

            string se = "two plus two is " + 4 + " quick maths";
            string sf = $"the value of fc is {fc}";
            string sg = "the sum between " + fa + " and " + fb + $" equals {fa + fb}";

            Console.WriteLine(se);
            Console.WriteLine(sf);
            Console.WriteLine(sg);
            Console.WriteLine();


            Console.ReadKey();
        }
    }
}
