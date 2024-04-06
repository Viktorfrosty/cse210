namespace Inversions
{

    public class PaydayLoan: Loan
    {

        public PaydayLoan(double amount, double rate, string registrationDate, string lapseOfTime, int duration, string description): base(amount, rate, registrationDate, lapseOfTime, duration, description)
        {

            _type = "Payday Loan";

        }

        public override void Evaluation()// W.I.P.
        {

            Console.WriteLine("Payday loan evaluation placeholder.");

        }


    }

}