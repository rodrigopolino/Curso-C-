namespace Aula8_Foreach {
    internal class Program {
        static void Main(string[] args) {

            string[] vect = new string[] { "Maria", "Bob", "Alex" };

            //tamanho do vetor = vect.Lenght
            for (int i = 0; i < vect.Length; i++) {
                Console.WriteLine(vect[i]);
            }


            foreach (string obj in vect) { //obj = apelido a cada elemento(obj) no vetor
                Console.WriteLine(obj);
            }

        }
    }
}