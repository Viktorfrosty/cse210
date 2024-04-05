namespace Inversions
{

    public class StudentLoan: Loan
    {

        public StudentLoan(double amount, double rate, string startingDate, string description): base(amount, rate, startingDate, description)
        {

            _type = "Student Loan";

        }

        public override void Evaluation()// W.I.P.
        {

            Console.WriteLine("placeholder");

        }


    }

}