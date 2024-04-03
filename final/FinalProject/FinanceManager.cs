namespace Inversions
{

    public class FinanceManager
    {

        protected string _type;

        protected double _amount;

        protected double _apr;

        protected string _startingDate;

        protected string _dateFormat = "yyyy/MM/dd";

        public FinanceManager(double amount, double apr, string startingDate)
        {

            _type = "Finance Element";

            _amount = amount;

            _apr = apr;

            _startingDate = startingDate;

        }

        public virtual DateTime StringToDate(string dateString)
        {;

            DateTime date = DateTime.ParseExact(dateString, _dateFormat, null);

            return date;

        }

        public virtual string GetElementDetails()
        {

            return $"{_type}, Date: {_startingDate}, APR: {_apr}%, Amount: ${_amount}";

        }

        public virtual void Evaluation()
        {

            //

        }

    }

}