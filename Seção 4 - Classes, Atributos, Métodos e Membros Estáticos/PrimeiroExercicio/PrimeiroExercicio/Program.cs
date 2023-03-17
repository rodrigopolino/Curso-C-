using System;
using System.Globalization;

namespace PrimeiroExercicio { 
    internal class Program {
        static void Main(string[] args) {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.idade = int.Parse(Console.ReadLine());

            if (p1.idade < p2.idade) {
                Console.WriteLine("Pessoa mais velha: " + p2.nome);
            }
            else {
                Console.WriteLine("Pessoa mais velha: " + p1.nome);
            }

            Console.WriteLine("--------------------------------------------------");

            Funcionario f1 = new Funcionario();
            Funcionario f2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            f1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            f2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            f2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salMedio = (f1.salario + f2.salario) / 2.0;

            Console.WriteLine("Salário médio: " + salMedio.ToString("F2", CultureInfo.InvariantCulture));


        }
    }   
}