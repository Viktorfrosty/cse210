namespace Inversions
{

    public class MortgageLoan: Loan
    {

        public MortgageLoan(double amount, double rate, string startingDate, string description): base(amount, rate, startingDate, description)
        {

            _type = "Mortgage Loan";

        }

        public override void Evaluation()// W.I.P.
        {

            Console.WriteLine("placeholder");

        }


    }

}