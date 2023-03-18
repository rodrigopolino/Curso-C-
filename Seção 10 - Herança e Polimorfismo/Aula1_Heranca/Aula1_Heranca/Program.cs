using Aula1_Heranca.Entities;

namespace Aula1_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);

            // account.Balance = 200; //não consegue mudar porque Program.cs não é uma subclasse de Account
        }
    }
}