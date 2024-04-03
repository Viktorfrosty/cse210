namespace Inversions
{

    public class Saving: FinanceManager
    {

        protected int _duration; 

        public Saving(double amount, double apr, string startingDate, int duration): base(amount, apr, startingDate)
        {

            _duration = duration;

        }

    }

}