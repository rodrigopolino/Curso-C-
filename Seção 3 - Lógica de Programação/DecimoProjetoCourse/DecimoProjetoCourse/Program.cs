using System;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace DecimoProjetoCourse {
    internal class Program {
        static void Main(string[] args) {

            //While
            //V:executa e volta F:pula fora
      
            Console.WriteLine("Digite um número: ");
            double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while (x >= 0) {
                double raiz = Math.Sqrt(x);
                Console.WriteLine(raiz.ToString("F3", CultureInfo.InvariantCulture));
                Console.WriteLine("Digite outro número: ");
                x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Número negativo");
           

        }
    }
}