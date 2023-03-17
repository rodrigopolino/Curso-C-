namespace Aula1_Struct {
    internal class Program {
        static void Main(string[] args) {

            Point p; //não é obrigado a por new igual a classe
            p.X = 10;
            p.Y = 20;

            Console.WriteLine(p);

            p = new Point();
            Console.WriteLine(p);

        }
    }
}