namespace Aula7_PropEOperecoesDateTime {
    internal class Program {
        static void Main(string[] args) {

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);

            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            Console.WriteLine("----------------------------");

            DateTime date = new DateTime(2005, 09, 12, 20, 30, 45);

            string s1 = date.ToLongDateString();
            string s2 = date.ToLongTimeString();
            string s3 = date.ToShortDateString();
            string s4 = date.ToShortTimeString();
            string s5 = date.ToString();

            string s6 = date.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = date.ToString("yyyy-MM-dd HH:mm:ss.fff");

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            Console.WriteLine("------------------------");

            DateTime dataAtual = DateTime.Now;

            DateTime d2 = date.AddHours(2);
            DateTime d3 = date.AddMinutes(3);
            DateTime d4 = dataAtual.AddDays(7);

            Console.WriteLine(date);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(dataAtual);
            Console.WriteLine(d4);

            TimeSpan t = dataAtual.Subtract(date);

            Console.WriteLine(t);
        }
    }
}