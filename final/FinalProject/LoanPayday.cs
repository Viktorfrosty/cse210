namespace Inversions
{

    public class PaydayLoan: Loan
    {

        private double _fees;

        public PaydayLoan(double amount, double fees, double rate, string registrationDate, string lapseOfTime, int duration, string description): base(amount, rate, registrationDate, lapseOfTime, duration, description)
        {

            _subType = "Payday";

            _fees = fees;

        }
        public override string GetElementDetails()
        {

            return $"{_subType} {_type}\n   Date: {_registrationDate}\n   Amount: $ {_amount}\n   Fees: $ {_fees}\n   Term: {_duration} {_lapseOfTime}\n   Short description: {_description}\n";

        }

        public override string GetStringElement()
        {

            return $"{_subType} {_type}‖{_registrationDate}‖{_amount}‖{_rate}‖{_lapseOfTime}‖{_duration}‖{_description}‖{_fees}";

        }

        protected override void ShowCalculationDetails()
        {

            Console.WriteLine($"Amount: $ {_amount}\nFees: $ {_fees}\nDuration: {_duration} {_lapseOfTime}.\n");

        }

        public override void Evaluation()
        {

            Console.Clear();

            ShowCalculationDetails();

            _calculation = Math.Round((_fees / _amount / _duration) * 365 * 100, 2);

            LoanOperations();

        }

        protected override void LoanOperations()
        {

            _amountGenerated = Math.Round(_amount + _fees, 2);

            Console.WriteLine($"Total debt: $ {_amountGenerated}\nAnnual Percentage Rate (APR): {_calculation}%\n");

        }

        public override void Update()
        {
            GeneralEditor();

            FeeEditor();

        }

        private void FeeEditor()
        {

            while (true)
            {
                Console.Write($"Current fee amount: {_fees}\nNew fee amount: ");

                bool updateValidation = double.TryParse(Console.ReadLine(), out double newFees);

                if (updateValidation)
                {

                    if (newFees < 0.0)
                    {

                        Console.Clear();

                        Console.WriteLine($"The value is lower than the expected.\n");

                    }

                    else
                    {

                        Console.Clear();

                        _fees = newFees;

                        break;
                    }

                }

                else
                {

                    Console.Clear();

                    Console.WriteLine("Please insert a valid number.\n");

                }

            }
        }

    }

}