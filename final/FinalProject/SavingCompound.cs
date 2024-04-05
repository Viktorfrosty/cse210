namespace Inversions
{

    public class CompoundSaving: Saving
    {

        public CompoundSaving(double amount, double rate, string startingDate, string description, int duration): base(amount, rate, startingDate, description, duration)
        {

            _type = "Compound Saving";

        }

    }

}