using System;

namespace SetimoProjetoCourse {
    internal class Program {
        static void Main(string[] args) {

            //Operadores comparativos
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            Console.WriteLine("------------------------------------------------");

            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

            Console.WriteLine("------------------------------------------------");
            //Operadores lógicos
            //Precedência ! > && > ||

            bool d1 = 2 > 3 && 4 != 5; //false
            bool d2 = 2 > 3 || 4 != 5; //true
            bool d3 = !(2 > 3) && 4 != 5; //true

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);

            Console.WriteLine("------------------------------------------------");

            bool d4 = 10 < 5; //false
            bool d5 = d2 || d3 && d4;

            Console.WriteLine(d4);
            Console.WriteLine(d5);


        }
    }
}