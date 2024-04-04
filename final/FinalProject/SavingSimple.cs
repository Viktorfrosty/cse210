namespace Inversions
{

    public class SimpleSaving: Saving
    {

        public SimpleSaving(double amount, double rate, string startingDate, int duration): base(amount, rate, startingDate, duration)
        {

            _type = "Simple Saving";

        }

        public override void Evaluation()
        {

            Console.WriteLine(_amount * _rate * (_duration/365));
            
        }

    }

}