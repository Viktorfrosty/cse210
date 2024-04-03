namespace Inversions
{

    public class CompoundSaving: Saving
    {

        public CompoundSaving(double amount, double apr, string startingDate): base(amount, apr, startingDate)
        {

            _type = "Compound Saving";

        }

    }

}