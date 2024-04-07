namespace Inversions
{

    public class CompoundSaving: Saving
    {

        private int _interestCompound;

        public CompoundSaving(double amount, double rate, int interestCompound, string registrationDate, string lapseOfTime, int duration, string description): base(amount, rate, registrationDate, lapseOfTime, duration, description)
        {

            _type = "Compound Saving";

            _interestCompound = interestCompound;

        }

        public override string GetElementDetails()
        {

            return $"{_type}, Date: {_registrationDate}, Amount: ${_amount}, rate: {_rate}%, times the interest is compounded yearly: {_interestCompound}, Description: {_description}";

        }

        public override string GetStringElement()
        {

            return $"{_type}‖{_registrationDate}‖{_rate}‖{_amount}‖{_description}‖{_interestCompound}";

        }

        public override void Evaluation()// W.I.P.
        {

            Console.Clear();

            Console.WriteLine("Compound saving evaluation placeholder.\n");

        }


    }

}