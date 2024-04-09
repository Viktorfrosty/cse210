namespace Inversions
{

    public class Saving: FinancesManager
    {

        public Saving(double amount, double rate, string registrationDate, string lapseOfTime, int duration, string description): base(amount, rate, registrationDate, lapseOfTime, duration, description)
        {

            _type = "Saving";

        }

        protected void SavingsOperations()
        {

            _amountGenerated = Math.Round(_calculation, 2);

            _interestGenerated = Math.Round(_calculation - _amount, 2);
            
            _Percent = Math.Round(((_calculation - _amount) / _amount) * 100, 2); 

            Console.WriteLine($"Total generated: $ {_amountGenerated}\nAmount gained: $ {_interestGenerated}\nYour savings will grown {_Percent}% at the end of {_duration} {_lapseOfTime}.\n");

        }

    }


}