using System;

namespace Aula1_Heranca.Entities
{
    class BusinessAccount : Account //BusinessAccount irá ter tudo que a Account tem
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }

        }
    }
}
