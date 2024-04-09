namespace Inversions
{

    public class PersonalLoan: Loan
    {

        private int _nPayments;

        private double _termPaymentValue;

        public PersonalLoan(double amount, int nPayments, double rate, string registrationDate, string lapseOfTime, int duration, string description): base(amount, rate, registrationDate, lapseOfTime, duration, description)
        {

            _subType = "Personal";

            _nPayments = nPayments;

        }

        protected override void ShowCalculationDetails()
        {

            Console.WriteLine($"Amount: $ {_amount}\nInterest rate: {_rate}%\nDuration: {_duration} {_lapseOfTime}.\nQuantity of amortizations: {_nPayments}\n");

        }

        public override string GetElementDetails()
        {

            return $"{_subType} {_type}\n   Date: {_registrationDate}\n   Amount: $ {_amount}\n   Interest rate: {_rate}%\n   Quantity of amortizations: {_nPayments}\n   Duration: {_duration} {_lapseOfTime}\n   Short description: {_description}\n";

        }

        public override string GetStringElement()
        {

            return $"{_subType} {_type}‖{_registrationDate}‖{_amount}‖{_rate}‖{_lapseOfTime}‖{_duration}‖{_description}‖{_nPayments}";

        }

        public override void Evaluation()
        {

            Console.Clear();

            ShowCalculationDetails();

            double durationIntervail = DurationIntervail();
            
            _calculation = ((_rate * 0.01 / 12) * _amount) / (1 - Math.Pow(1 + (_rate * 0.01 / 12), -(_nPayments)));

            LoanOperations();

        }

        protected override void LoanOperations()
        {

            _amountGenerated = Math.Round(_calculation + _amount, 2);

            _interestGenerated = Math.Round(_calculation, 2);

            _termPaymentValue = Math.Round(_amountGenerated / _nPayments, 2);

            Console.WriteLine($"Interest generated: $ {_interestGenerated}\nTotal debt: $ {_amountGenerated}\nEstimated amortization per term: $ {_termPaymentValue}\n");

        }

        public override void Update()
        {
            GeneralEditor();

            AmortizationEditor();

        }

        private void AmortizationEditor()
        {

            while (true)
            {
                Console.Write($"Current quantity of amortizations: {_nPayments}\nNew amortization quantity: ");

                bool updateValidation = int.TryParse(Console.ReadLine(), out int newNPayments);

                if (updateValidation)
                {

                    if (newNPayments < 1)
                    {

                        Console.Clear();

                        Console.WriteLine($"The value is lower than the expected.\n");

                    }

                    else
                    {

                        Console.Clear();

                        _nPayments = newNPayments;

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