namespace Aula4_FuncoesString {
    internal class Program {
        static void Main(string[] args) {

            string original = "abcde FGHIJ ABC abc DEFG   ";

            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim(); //apaga espaços em branco das pontas

            int n1 = original.IndexOf("bc"); //procurar posicao
            int n2 = original.LastIndexOf("bc");

            string s4  = original.Substring(3); //corta os 3 primeiros valores
            string s5 = original.Substring(3, 5); //pegar os 5 caractares a partir da posicao 3

            string s6 = original.Replace('a', 'x'); //trocar a por x
            string s7 = original.Replace("abc", "xy");

            bool b1 = String.IsNullOrEmpty(original); //verificar se o conteúdo é nulo ou vazio
            bool b2 = String.IsNullOrWhiteSpace(original); //verificar se o conteúdo é nulo ou se tem espaço em branco

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper: -" + s1 + "-");
            Console.WriteLine("ToLower: -" + s2 + "-");
            Console.WriteLine("Trim: -" + s3 + "-");
            Console.WriteLine("IndeOf('bc'): " + n1);
            Console.WriteLine("LastIndeOf('bc'): " + n2);
            Console.WriteLine("Substring(3): -" + s4 + "-");
            Console.WriteLine("Substring(3, 5): -" + s5 + "-");
            Console.WriteLine("Replace('a', 'x'): -" + s6 + "-");
            Console.WriteLine("Replace('abc', 'xy'): -" + s7 + "-");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

        }
    }
}