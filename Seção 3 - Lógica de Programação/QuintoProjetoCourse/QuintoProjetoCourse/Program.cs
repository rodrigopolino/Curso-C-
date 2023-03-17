namespace QuintoProjetoCourse {
    internal class Program {
        static void Main(string[] args) {
            //Conversão implícita e casting

            float x = 4.5f;
            double y = x;

            Console.WriteLine(y); //4 bytes cabem em 8 bytes

            double a;
            float b;

            a = 5.1;
            // b = a; 8 bytes não cabe em 4 bytes
            b = (float)a; //casting
            Console.WriteLine(b);

            double c;
            int d;

            c = 8.1;
            d = (int)c;
            Console.WriteLine(d);

            int e = 5;
            int f = 2;

            double resultado = (double) e / f;
            Console.WriteLine(resultado);

        }
    }
}