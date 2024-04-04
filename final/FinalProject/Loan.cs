namespace Inversions
{

    public class Loan: FinanceManager
    {

        protected string _finishingDate;

        public Loan(double amount, double rate, string startingDate, string finishingDate): base(amount, rate, startingDate)
        {

            _finishingDate = finishingDate;

        }

    }

}