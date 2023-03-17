using System.Timers;

namespace Aula8_PropEOperacoesTimeSpan {
    internal class Program {
        static void Main(string[] args) {

            TimeSpan t1 = TimeSpan.MaxValue;
            TimeSpan t2 = TimeSpan.MinValue;
            TimeSpan t3 = TimeSpan.Zero;

            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine("------------------------");
            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine("Seconds: " + t.Seconds);
            Console.WriteLine("Milliseconds: " + t.Milliseconds);
            Console.WriteLine("Ticks: " + t.Ticks);

            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine("TotalMilliseconds: " + t.TotalMilliseconds);

            Console.WriteLine("------------------------");

            TimeSpan time = new TimeSpan(1, 30, 10);
            TimeSpan timef = new TimeSpan(0, 10, 5);

            TimeSpan sum = time.Add(timef);
            TimeSpan dif = time.Subtract(timef);
            TimeSpan mult = timef.Multiply(2.0); //recebe double como argumento
            TimeSpan div = timef.Divide(2.0);

            Console.WriteLine(sum);
            Console.WriteLine(dif);
            Console.WriteLine(mult);
            Console.WriteLine(div);
        }
    }
}