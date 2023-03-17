namespace Aula7_ModificadorParamsRef_Out {
    internal class Program {
        static void Main(string[] args) {

            int a = 10;

            Calculator.Triple(ref a); //ref exige que a variável seja iniciada
            Console.WriteLine(a);

            int b = 10;
            int tripli;
            Calculator.Tripli(b, out tripli);
            Console.WriteLine(tripli);

        }
    }
}