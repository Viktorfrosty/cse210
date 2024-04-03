namespace Inversions
{

    public class SimpleSaving: Saving
    {

        public SimpleSaving(double amount, double apr, string startingDate, int duration): base(amount, apr, startingDate, duration)
        {

            _type = "Simple Saving";

        }

        public override void Evaluation()
        {

            Console.WriteLine(_amount * _apr * (_duration/365));
            
        }

    }

}