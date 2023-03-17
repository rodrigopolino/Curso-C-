using System;

namespace SegundoProjetoCourse {
    internal class Program {
        static void Main(string[] args) {
            sbyte x = 100; //int, long, float, double, decimal

            Console.WriteLine(x);

            byte n1 = 255;
            n1++; //overflow, volta ao primeiro némero

            int n2 = 1000;
            int n3 = 2147483647;
            long n4 = 2147483648L; //L recomendação do tipo Long
            
            Console.WriteLine(n1); // c + w + tab + tab
            Console.WriteLine(n2);
            Console.WriteLine(n3);
            Console.WriteLine(n4);

            //aula2

            bool completo = false;
            char genero = 'F';   //tambpem pode ver o código pelo site do unicode
            char letra = '\u0041';
            float n5 = 4.5f;
            double n6 = 4.5;
            string nome = "Maria Green"; //string imutável
            object obj1 = "Alex Brow"; //aceita qualquer coisa
            object obj2 = 2.3f;

            int x1 = int.MinValue;
            int x2 = int.MaxValue;
            sbyte x3 = sbyte.MinValue;
            decimal x4 = decimal.MaxValue;

            Console.WriteLine(completo);
            Console.WriteLine(genero);
            Console.WriteLine(letra);
            Console.WriteLine(n5);
            Console.WriteLine(n6);
            Console.WriteLine(nome);
            Console.WriteLine(obj1);
            Console.WriteLine(obj2);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine(x3);
            Console.WriteLine(x4);
        }
    }
}