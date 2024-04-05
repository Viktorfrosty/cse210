namespace Inversions
{

    public class PersonalLoan: Loan
    {

        public PersonalLoan(double amount, double rate, string startingDate, string description): base(amount, rate, startingDate, description)
        {

            _type = "Personal Loan";

        }

        public override void Evaluation()// W.I.P.
        {

            Console.WriteLine("placeholder");

        }


    }

}