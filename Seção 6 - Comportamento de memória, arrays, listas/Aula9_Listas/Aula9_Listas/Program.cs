using System.Collections.Generic;
using System.Reflection;

namespace Aula9_Listas {
    internal class Program {
        static void Main(string[] args) {

            //começa vazia e adiciona elementos
            //acesso sequencial = percorrer nodo por nodo (desvantagem)

            //List<string> list2 = new List<string> { "Maria", "Alex" };

            List<string> list = new List<string>();
            //add adiciona, insert posição 
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");
            list.Insert(2, "Marco");

            foreach (string obj in list) {
                Console.WriteLine(obj);
            }
            Console.WriteLine("List count: " + list.Count);

            string s1 = list.Find(x => x[0] == 'A'); //EXPRESSÃO LAMBIDA / primeira letra
            Console.WriteLine("First 'A': " + s1);

            string s2 = list.FindLast(x => x[0] == 'A'); //última letra
            Console.WriteLine("Last 'A': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("--------------------");
            foreach (string obj in list2) {
                Console.WriteLine(obj);
            }

            list.Remove("Alex"); //se não encontrar o objeto, não faz nada
            Console.WriteLine("--------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("--------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveAt(1);
            Console.WriteLine("--------------------");
            foreach (string obj in list) {
                Console.WriteLine(obj);
            }

            list.RemoveRange(2, 2); //A partir da posição dois, remova 2

        }
    }
}