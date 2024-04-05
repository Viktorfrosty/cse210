namespace Inversions
{

    public class AutoLoan: Loan
    {

        public AutoLoan(double amount, double rate, string startingDate, string description): base(amount, rate, startingDate, description)
        {

            _type = "Auto Loan";

        }

        public override void Evaluation()// W.I.P.
        {

            Console.WriteLine("placeholder");

        }


    }

}