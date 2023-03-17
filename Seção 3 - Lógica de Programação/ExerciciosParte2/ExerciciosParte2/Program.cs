using System;
using System.Globalization;

namespace ExerciciosParte2 {
    internal class Program {
        static void Main(string[] args) {
            
            //Exercício 1

            int z = int.Parse(Console.ReadLine());

            if (z < 0) {
                Console.WriteLine("NEGATIVO");
            }
            else {
                Console.WriteLine("NAO NEGATIVO");
            }

            //Exercício 2
            if (z % 2 == 0) {
                Console.WriteLine("PAR");
            }
            else {
                Console.WriteLine("ÍMPAR");
            }

            //Exercício 3

            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("Sao Multiplos");
            }
            else {
                Console.WriteLine("Nao sao Multiplos");
            }

            //Exercício 4

            string[] hora = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(hora[0]);
            int horaFinal = int.Parse(hora[1]);

            int horaTotal = 0;
            if (horaInicial < horaFinal) {
                horaTotal = horaFinal - horaInicial; 
            }
            else {
                horaTotal = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + horaTotal + " HORA(S)");

            //Exercício 5

            string[] lanche = Console.ReadLine().Split(' ');
            int codigo = int.Parse(lanche[0]);
            int quantidade = int.Parse(lanche[1]);

            double preco = 0;
            if (codigo == 1) {
                preco = 4.00 * quantidade;
            }
            else if (codigo == 2) {
                preco = 4.50 * quantidade;
            }
            else if (codigo == 3) {
                preco = 5.00 * quantidade;
            }
            else if (codigo == 4) {
                preco = 2.00 * quantidade;
            }
            else if (codigo == 5) {
                preco = 1.50 * quantidade; 
            }
            else {
                Console.WriteLine("Você digitou um código inválido!");
            }

            Console.WriteLine("Total: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));

            //Exercício 6
            double number = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (number >= 0 && number < 25) {
                Console.WriteLine("Intervalo [0, 25]");
            }
            else if (number >= 25 && number < 50) {
                Console.WriteLine("Intervalo [25, 50]");
            }
            else if (number >= 50 && number < 75) {
                Console.WriteLine("Intervalo [50, 75]");
            }
            else if (number >= 75 && number <= 100) {
                Console.WriteLine("Intervalo [75, 100]");
            }
            else {
                Console.WriteLine("Fora de intervalo");
            }

            //Exercício 7

            string[] pontos = Console.ReadLine().Split(' ');
            double x = double.Parse(pontos[0], CultureInfo.InvariantCulture);
            double y = double.Parse(pontos[1], CultureInfo.InvariantCulture);

            if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            }
            else if (x < 0.0 && y > 0) {
                Console.WriteLine("Q2");
            }
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else if (x > 0.0 && y < 0.0) {
                Console.WriteLine("Q4");
            }
            else if (x == 0.0 && y == 0.0) {
                Console.WriteLine("Origem");
            } 
            else if (x == 0.0) {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0.0) {
                Console.WriteLine("Eixo X");
            }

            //Exercício 8
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double imposto = 0.0;
            if (renda >= 0.00 && renda <= 2000.00) {
                imposto = 0.00;
                Console.WriteLine();
            }
            else if (renda >= 2000.01 && renda <= 3000.00) {
                imposto = (renda - 2000) * 0.08;
            }
            else if (renda >= 3000.01 && renda <= 4500.00) {
                imposto = (renda - 3000.0) * 0.18 + 1000 * 0.08;
            }
            else {
                imposto = (renda - 4500) * 0.28 + 1500 * 0.18 + 1000 * 0.08;
            }

            if (imposto == 0.00) {
                Console.WriteLine("Isento");
            }
            else {
                Console.WriteLine("R$ " + imposto.ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}