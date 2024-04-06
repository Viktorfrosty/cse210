namespace Inversions
{

    public class PersonalLoan: Loan
    {

        public PersonalLoan(double amount, double rate, string registrationDate, string lapseOfTime, int duration, string description): base(amount, rate, registrationDate, lapseOfTime, duration, description)
        {

            _type = "Personal Loan";

        }

        public override void Evaluation()// W.I.P.
        {

            //

        }


    }

}