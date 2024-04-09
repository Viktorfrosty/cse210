namespace Inversions
{

    public class CompoundSaving: Saving
    {

        private int _interestCompound;

        public CompoundSaving(double amount, double rate, int interestCompound, string registrationDate, string lapseOfTime, int duration, string description): base(amount, rate, registrationDate, lapseOfTime, duration, description)
        {

            _subType = "Compound";

            _interestCompound = interestCompound;

        }

        public override string GetElementDetails()
        {

            return $"{_subType} {_type}\n   Date: {_registrationDate}\n   Amount: $ {_amount}\n   Interest rate: {_rate}%, the interest is compounded {_interestCompound} times during a year.\n   Duration: {_duration} {_lapseOfTime}\n   Short description: {_description}\n";

        }

        public override string GetStringElement()
        {

            return $"{_subType} {_type}‖{_registrationDate}‖{_amount}‖{_rate}‖{_lapseOfTime}‖{_duration}‖{_description}‖{_interestCompound}";

        }

        protected override void ShowCalculationDetails()
        {

            Console.WriteLine($"Amount: $ {_amount}\nInterest rate: {_rate}%, compounded {_interestCompound} times in a year.\nDuration: {_duration} {_lapseOfTime}.\n");

        }

        public override void Evaluation()
        {

            Console.Clear();

            ShowCalculationDetails();

            double durationIntervail = DurationIntervail();

            _calculation = _amount * Math.Pow((1 + ((_rate / 100) / _interestCompound)), _interestCompound * durationIntervail);

            SavingsOperations();

        }

        public override void Update()
        {

            GeneralEditor();

            CompoundEditor();

        }

        private void CompoundEditor()
        {

            while (true)
            {
                Console.Write($"Current times that the rate is compounded in a year: {_interestCompound}\nNew compounding cicle value: ");

                bool updateValidation = int.TryParse(Console.ReadLine(), out int newInterestCompound);

                if (updateValidation)
                {

                    if (newInterestCompound < 2)
                    {

                        Console.Clear();

                        Console.WriteLine($"The value is lower than the expected.\n");

                    }

                    else
                    {

                        Console.Clear();

                        _interestCompound = newInterestCompound;

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