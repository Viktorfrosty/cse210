namespace Inversions
{

    public class SimpleSaving: Saving
    {

        public SimpleSaving(double amount, double rate, string startingDate, string description, int duration): base(amount, rate, startingDate, description, duration)
        {

            _type = "Simple Saving";

        }

        public override void Evaluation()
        {

            Console.WriteLine(_amount * _rate * (_duration/365));
            
        }

    }

}