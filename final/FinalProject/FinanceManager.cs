namespace Inversions
{

    public class FinanceManager
    {

        protected string _type;

        protected double _amount;

        protected double _rate;

        protected string _startingDate;

        protected string _description;

        protected string _dateFormat = "yyyy/MM/dd";

        public FinanceManager(double amount, double rate, string startingDate, string description)
        {

            _type = "Finance Element";

            _amount = amount;

            _rate = rate;

            _startingDate = startingDate;

            _description = description;

        }

        public virtual DateOnly StringToDate(string dateString)// W.I.P.
        {;

            DateOnly date = DateOnly.ParseExact(dateString, _dateFormat, null);

            return date;

        }

        public virtual string GetElementDetails()
        {

            return $"{_type}, Date: {_startingDate}, Amount: ${_amount}, rate: {_rate}%, Description: {_description}";

        }

        public virtual string GetStringElement()
        {

            return $"{_type}‖{_startingDate}‖{_rate}‖{_amount}‖{_description}";

        }

        public virtual void Evaluation()// W.I.P.
        {

            Console.WriteLine("placeholder");

        }

    }

}