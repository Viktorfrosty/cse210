namespace Inversions
{

    public class CompoundSaving: Saving
    {

        private int _interestCompound;

        public CompoundSaving(double amount, double rate, string registrationDate, string lapseOfTime, int duration, string description): base(amount, rate, registrationDate, lapseOfTime, duration, description)
        {

            _type = "Compound Saving";

        }

        public override void Evaluation()// W.I.P.
        {

            //

        }


    }

}