using System;
using System.Runtime.InteropServices;

namespace QuartoProjetoCourse {
    internal class Program {
        static void Main(string[] args) {

            int a = 10;
            Console.WriteLine(a);

            a += 2;
            Console.WriteLine(a);

            a *= 3;
            Console.WriteLine(a);

            a /= 4;
            Console.WriteLine(a);

            string s = "ABC";
            Console.WriteLine(s);

            s += "DEF";
            Console.WriteLine(s); // s = s + DEF


            int b = 10;
            b++;
            Console.WriteLine(b);

            int c = 20;
            c--;
            Console.WriteLine(c);

            int d = 30;
            int e = d++;
            Console.WriteLine(d);
            Console.WriteLine(e);

            int f = 40;
            int g = ++f;
            Console.WriteLine(f);
            Console.WriteLine(g);

        }
    }
}