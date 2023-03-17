namespace OitavoProjetoCourse {
    internal class Program {
        static void Main(string[] args) {
            //Estrutura condicional

            int x = 10;

            Console.WriteLine("Bom dia");

            if (x < 5) {
                Console.WriteLine("Boa tarde");
            }
            else {
                Console.WriteLine("Boa noite");
            }

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Entre com um número inteiro: ");
            int y = int.Parse(Console.ReadLine());

            if (y % 2 == 0) {
                Console.WriteLine("Par!");
            }
            else {
                Console.WriteLine("Ímpar!");
            }

            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12) {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18) {
                Console.WriteLine("Boa tarde!");
            }
            else {
                Console.WriteLine("Boa noite!");
            }
            //Chaves são opcionais com um comando
        }
    }
}