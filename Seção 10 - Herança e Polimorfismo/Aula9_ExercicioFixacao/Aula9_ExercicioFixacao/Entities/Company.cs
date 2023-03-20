using System;

namespace Aula9_ExercicioFixacao.Entities
{
    class Company : TaxPayer
    {

        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (NumberOfEmployees <= 10)
            {
                return tax = AnualIncome * 0.16;
            }
            else
            {
                return tax = AnualIncome * 0.14;
            }
        }
    }
}
