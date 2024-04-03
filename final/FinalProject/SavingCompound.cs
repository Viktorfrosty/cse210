namespace Inversions
{

    public class CompoundSaving: Saving
    {

        public CompoundSaving(double amount, double apr, string startingDate, int duration): base(amount, apr, startingDate, duration)
        {

            _type = "Compound Saving";

        }

    }

}