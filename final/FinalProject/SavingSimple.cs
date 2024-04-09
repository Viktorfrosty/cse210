namespace Inversions
{

    public class SimpleSaving: Saving
    {

        public SimpleSaving(double amount, double rate, string registrationDate, string lapseOfTime, int duration, string description): base(amount, rate, registrationDate, lapseOfTime, duration, description)
        {

            _subType = "Simple";

        }

        public override void Evaluation()
        {

            Console.Clear();

            ShowCalculationDetails();

            double durationIntervail = DurationIntervail();

            _calculation = _amount * (1 + (_rate / 100) * durationIntervail);

            SavingsOperations();
            
        }

    }

}