using System;
using System.Globalization;

namespace ExercíciosParte4 {
    internal class Program {
        static void Main(string[] args) {

            //Exercício 1
            int X = int.Parse(Console.ReadLine());

            int impar = 0;
            if (X >= 1 && X <= 1000) {
                for (int i = 0; i <= X; i++) {
                    if (i % 2 != 0) {
                        Console.WriteLine(i);
                    }
                }
            }
            else {
                Console.WriteLine("Digite um número entre 1 e 1000");
            }

            //Exercício 2
            Console.Write("Digite a quantidade de números que você vai digitar: ");
            int N = int.Parse(Console.ReadLine());

            int numero = 0;
            int somain = 0;
            int somaout = 0;
            for ( int i = 1; i <= N; i++) {
                Console.Write("Digite o número {0}: ", i);
                numero = int.Parse(Console.ReadLine());
                if (numero >= 10 && numero <= 20) {
                    somain += 1;
                }
                else {
                    somaout += 1;
                }
            }

            Console.WriteLine("{0} in", somain);
            Console.WriteLine("{0} out", somaout);

            //Exercício 3
            Console.Write("Digite o número de casos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Digite os 3 números: ");
                string[] numeros = Console.ReadLine().Split(' ');
                double a = double.Parse(numeros[0], CultureInfo.InvariantCulture);
                double b = double.Parse(numeros[1], CultureInfo.InvariantCulture);
                double c = double.Parse(numeros[2], CultureInfo.InvariantCulture);

                double media = (a * 2.0 + b * 3.0 + c * 5.0) / 10.0;

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));

            }

            //Exercício 4
            Console.Write("Digite a quantidade de pares: ");
            int Y = int.Parse(Console.ReadLine());

            double divisao = 0;
            for (int i = 1; i <= Y; i++) {
                Console.Write("Digite o par: ");
                string[] par = Console.ReadLine().Split(' ');
                int a1 = int.Parse(par[0]);
                int a2 = int.Parse(par[1]);

                if (a2 == 0) {
                    Console.WriteLine("Divisão Impossível");
                }
                else {
                    divisao = (double)a1 / a2;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }

            //Exercício 5
            Console.Write("Digite um número para calcular sue fatorial: ");
            int num = int.Parse(Console.ReadLine());

            int fatorial = 1;
            for (int i = 1; i <= num; i++) {
                fatorial *= i; //1*1=1*2=2*3=6*4=24*5
            }
            Console.WriteLine(fatorial);

            //Exercício 6
            Console.WriteLine("Digite um número para ser calculado todos os seus divisiroes: ");
            int r = int.Parse(Console.ReadLine());

            int divisores = 1;
            for (int i = 1; i <= r; i++) {
                if (r % i == 0) {
                    Console.WriteLine(i);
                }
            }

            //Exercício 7
            Console.WriteLine("Digite um valor: ");
            int value = int.Parse(Console.ReadLine());

            for (int i = 1; i <= value; i++) {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;

                Console.WriteLine("{0} {1} {2}", primeiro, segundo, terceiro);

            }


        }
    }
}