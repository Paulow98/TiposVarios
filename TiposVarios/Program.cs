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
            double d = 1312;
            uint ui = 12013U;
            int i = 100;
            long l = 123L;
            ulong ul = 3UL;
            decimal de = 3.13m;
            Console.WriteLine(d);
            Console.WriteLine(ui);
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(ul);
            Console.WriteLine(de);
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

            Console.WriteLine(fa);
            Console.WriteLine(fb);
            Console.WriteLine(fc);
            Console.WriteLine();

            bool ba = true;
            bool bb = false;

            Console.WriteLine(ba);
            Console.WriteLine(bb);
            Console.WriteLine();

            string sa = "teste1";
            string sb = " \u00BC  = 10 \t \u00A2 = 20";
            string sc = "A\tE\tS\tT\tE\tT\tH\tI\tC\tS";
            string sd = @"\n so que nao";

            Console.WriteLine(sa);
            Console.WriteLine(sb);
            Console.WriteLine(sc);
            Console.WriteLine(sd);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
