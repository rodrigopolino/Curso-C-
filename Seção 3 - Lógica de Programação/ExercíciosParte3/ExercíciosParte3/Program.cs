using System;
using System.Security.Cryptography.X509Certificates;

namespace ExercíciosParte3 {
    internal class Program {
        static void Main(string[] args) {
            //Exercício 1

            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha Inválida");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

            //Exercício 2

            string[] pontos = Console.ReadLine().Split(' ');
            int x = int.Parse(pontos[0]);
            int y = int.Parse(pontos[1]);

            while (x != 0 && y != 0) {
                if (x > 0 && y > 0) {
                    Console.WriteLine("primeiro");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("segudo"); 
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("terceiro");
                }
                else {
                    Console.WriteLine("quarto");
                }
                pontos = Console.ReadLine().Split(' ');
                x = int.Parse(pontos[0]);
                y = int.Parse(pontos[1]);
            }


            // Exercício 3

            int codigo = int.Parse(Console.ReadLine());

            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            while (codigo != 4) {
                if (codigo == 1) {
                    alcool += 1;
                }
                else if (codigo == 2) {
                    gasolina += 1;
                }
                else if (codigo == 3) { 
                    diesel += 1;
                }
                else {
                    Console.WriteLine("Código Inválido! Digite um código válido!");
                }
                codigo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: " + alcool);
            Console.WriteLine("Gasolina: " + gasolina);
            Console.WriteLine("Diesel: " + diesel);

        }
    }
}