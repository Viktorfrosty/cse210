namespace Inversions
{

    public class FinancesManager
    {

        protected string _type;

        protected double _amount;

        protected double _rate;

        protected string _lapseOfTime;

        protected int _duration;

        protected string _registrationDate;

        protected string _description;

        public FinancesManager(double amount, double rate, string registrationDate, string lapseOfTime, int duration, string description)
        {

            _type = "Finance Element";

            _amount = amount;

            _rate = rate;

            _registrationDate = registrationDate;

            _duration = duration;

            _lapseOfTime = lapseOfTime;

            _description = description;

        }

        public virtual string GetElementDetails()
        {

            return $"{_type}, Date: {_registrationDate}, Amount: ${_amount}, rate: {_rate}%, Description: {_description}";

        }

        public virtual string GetStringElement()
        {

            return $"{_type}‖{_registrationDate}‖{_rate}‖{_amount}‖{_description}";

        }

        public virtual void Evaluation()// W.I.P.
        {

            //

        }

    }

}