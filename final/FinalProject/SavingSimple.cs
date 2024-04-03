namespace Inversions
{

    public class SimpleSaving: Saving
    {

        public SimpleSaving(double amount, double apr, string startingDate): base(amount, apr, startingDate)
        {

            _type = "Simple Saving";

        }

    }

}