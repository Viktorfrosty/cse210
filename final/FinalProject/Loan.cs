namespace Inversions
{

    public class Loan: FinanceManager
    {

        protected string _finishingDate;

        public Loan(double amount, double apr, string startingDate, string finishingDate): base(amount, apr, startingDate)
        {

            _finishingDate = finishingDate;

        }

    }

}