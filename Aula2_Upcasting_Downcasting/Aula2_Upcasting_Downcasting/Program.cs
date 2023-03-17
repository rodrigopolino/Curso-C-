using Aula1_Heranca.Entities;
using Aula2_Upcasting_Downcasting.Entities;

namespace Aula1_Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Account acc = new Account(1001, "Alex", 0.0);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.0, 500.0);

            //UPCASTING

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1002, "Bob", 0.0, 200.0);
/*superclasse*/Account acc3 = new SavingsAccount(1004, "Anna", 0.0, 0.01); //subclasse

            //DOWNCASTING

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);

            /*BusinessAccount acc5 = (BusinessAccount)acc3; //Vai dar erro pois acc3 é SavingsAccount*/
            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loan(200.0);
                Console.WriteLine("Loan");
            }

            if (acc3 is SavingsAccount) //é uma instancia de
            {
                //SavingsAccount acc5 = (SavingsAccount)acc3;
                SavingsAccount acc5 = acc3 as SavingsAccount;
                acc5.UpdateBalance();
                Console.WriteLine("Update!");

            }


        }
    }
}