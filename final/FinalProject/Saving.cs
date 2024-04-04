namespace Inversions
{

    public class Saving: FinanceManager
    {

        protected int _duration; 

        public Saving(double amount, double rate, string startingDate, int duration): base(amount, rate, startingDate)
        {

            _duration = duration;

        }

    }

}