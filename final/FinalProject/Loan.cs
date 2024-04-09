namespace Inversions
{

    public class Loan: FinancesManager
    {

        public Loan(double amount, double rate, string registrationDate, string lapseOfTime, int duration, string description): base(amount, rate, registrationDate, lapseOfTime, duration, description)
        {

            _type = "Loan";

        }

        protected virtual void LoanOperations()
        {

            _amountGenerated = Math.Round(_calculation + _amount, 2);

            _interestGenerated = Math.Round(_calculation, 2);

            Console.WriteLine($"Interest generated: $ {_interestGenerated}\nTotal debt: $ {_amountGenerated}\n");

        }

    }

}