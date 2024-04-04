namespace Inversions
{

    public class CompoundSaving: Saving
    {

        public CompoundSaving(double amount, double rate, string startingDate, int duration): base(amount, rate, startingDate, duration)
        {

            _type = "Compound Saving";

        }

    }

}