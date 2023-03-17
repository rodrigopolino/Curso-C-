using System;
using System.Globalization;

namespace ExerciciosParte1 {
    internal class Program {
        static void Main(string[] args) {
            //Exercício 1
            int x, y, soma;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            soma = x + y;

            Console.WriteLine("SOMA = " + soma);

            //Exercício 2

            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A=" + area.ToString("F4", CultureInfo.InvariantCulture));

            //Exercício 3

            int A, B, C, D, DIFERENCA;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);

            //Exercício 4

            int number = int.Parse(Console.ReadLine());
            int horas = int.Parse(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salary = horas * valor;

            Console.WriteLine("NUMBER = " + number);
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));

            //Exercício 5
            string s1 = Console.ReadLine();
            string[] vet = s1.Split(' ');
            int codigo1 = int.Parse(vet[0]);
            int pecas1 = int.Parse(vet[1]);
            double valor1 = double.Parse(vet[2], CultureInfo.InvariantCulture);

            string s2 = Console.ReadLine();
            string[] vetor = s2.Split(' ');
            int codigo2 = int.Parse(vetor[0]);
            int pecas2 = int.Parse(vetor[1]);
            double valor2 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            double preco = (pecas1 * valor1) + (pecas2 * valor2);

            Console.WriteLine("VALOR A PAGAR: R$ " + preco.ToString("F2", CultureInfo.InvariantCulture));

            //Exercíco 6 

            double a, b, c;

            string[] v = Console.ReadLine().Split(' ');
            a = double.Parse(v[0], CultureInfo.InvariantCulture);
            b = double.Parse(v[1], CultureInfo.InvariantCulture);
            c = double.Parse(v[2], CultureInfo.InvariantCulture);

            double triangulo = (a * c) / 2.0;
            double circulo = 3.14159 * Math.Pow(c, 2);
            double trapezio = ((a + b) * c) / 2.0;
            double quadrado = Math.Pow(b, 2);
            double retangulo = a * b;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QAUDRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}