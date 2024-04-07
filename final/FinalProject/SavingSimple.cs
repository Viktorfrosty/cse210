namespace Inversions
{

    public class SimpleSaving: Saving
    {

        public SimpleSaving(double amount, double rate, string registrationDate, string lapseOfTime, int duration, string description): base(amount, rate, registrationDate, lapseOfTime, duration, description)
        {

            _type = "Simple Saving";

        }

        public override void Evaluation()// W.I.P.
        {

            Console.Clear();

            Console.WriteLine("Simple saving evaluation placeholder.\n");
            
        }

    }

}