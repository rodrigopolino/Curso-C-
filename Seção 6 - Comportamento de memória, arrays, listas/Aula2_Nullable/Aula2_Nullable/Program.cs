using System;

namespace Aula2_Nullable {
    internal class Program {
        static void Main(string[] args) {

            double? x = null; // Nullable<double> x = null;
            double? y = 10.0; //opcional?

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue); //se dentro de x, existe ou não valor
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
                Console.WriteLine(x.Value);
            else
                Console.WriteLine("X is null");

            if (y.HasValue) 
                Console.WriteLine(y.Value);
            else 
                Console.WriteLine("Y is null");

            double? a = x ?? 5; // se x valor nulo, a = 5
            double b = y ?? 5;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}