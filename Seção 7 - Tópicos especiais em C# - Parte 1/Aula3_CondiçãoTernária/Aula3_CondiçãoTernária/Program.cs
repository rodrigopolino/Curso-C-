using System;
using System.Globalization; 

namespace Aula3_CondiçãoTernária {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo cf = CultureInfo.InvariantCulture;

            //( condição ) ? valor_se_verdadeiro : valor_se_falso

            double preco = double.Parse(Console.ReadLine(), cf);

            double desconto = (preco < 20.0) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(desconto);

            /*if (preco < 20.0) {
                desconto = preco * 0.1;
            }
            else {
                desconto = preco * 0.05;
            }*/

        }
    }
}