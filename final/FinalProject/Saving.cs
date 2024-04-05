namespace Inversions
{

    public class Saving: FinanceManager
    {

        protected int _duration; 

        public Saving(double amount, double rate, string startingDate, string description, int duration): base(amount, rate, startingDate, description)
        {

            _duration = duration;

        }

    }

}