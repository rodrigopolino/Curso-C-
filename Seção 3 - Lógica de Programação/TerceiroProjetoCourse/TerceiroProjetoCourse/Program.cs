using System;
using System.Globalization;

namespace TerceiroProjetoCourse { //PascalCase
    internal class Program {
        static void Main(string[] args) {

            //não pode começar variável com dígito
            //não pode ter espaço em branco na variável
            //camelCase
            //PascalCase
            //atributo interno = _saldo


            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";

            Console.Write("Bom dia");
            Console.WriteLine("Boa tarde"); //line = quebrar linha
            Console.WriteLine("Boa noite");
            Console.WriteLine("------------------------------------");
            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine(saldo.ToString("F2")); //2 número de casa
            Console.WriteLine(saldo.ToString("F4"));
            Console.WriteLine(saldo.ToString("F4", CultureInfo.InvariantCulture)); //ponto(.) como separador de decimais

            Console.WriteLine("{0} tem {1} anos e tem saldo igual a {2:F2} reais", nome, idade, saldo); //Placeholder
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo:F2} reais"); //Interpolação
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais"); //Concatenação


        }
    }
}