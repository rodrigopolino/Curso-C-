using System.Security.Cryptography.X509Certificates;

namespace Aula6_Params {
    internal class Program {
        static void Main(string[] args) {

            int result = Calculator.Sum(10, 20, 30, 40);
            int result2 = Calculator.Sum(2, 7);

            Console.WriteLine(result);
            Console.WriteLine(result2);

        }
    }
}