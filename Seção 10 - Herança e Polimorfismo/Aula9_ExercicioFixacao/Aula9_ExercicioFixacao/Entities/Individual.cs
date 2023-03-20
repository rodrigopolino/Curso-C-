using System;

namespace Aula9_ExercicioFixacao.Entities
{
    class Individual : TaxPayer
    {

        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double tax = 0.0;
            if (AnualIncome < 20000 && HealthExpenditures > 0)
            {
                return tax = (AnualIncome * 0.15) - (HealthExpenditures * 0.50);
            }
            else if (AnualIncome < 20000 && HealthExpenditures == 0)
            {
                return tax = (AnualIncome * 0.15);
            }
            else if (AnualIncome >= 20000 && HealthExpenditures > 0)
            {
                return tax = (AnualIncome * 0.25) - (HealthExpenditures * 0.50);
            }
            else
            {
                return tax = (AnualIncome * 0.25);
            }
        }
    }
}
