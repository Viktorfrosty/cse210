namespace Inversions
{

    public class FinancesManager
    {

        protected string _type;

        protected string _subType;

        protected double _amount;

        protected double _rate;

        protected string _lapseOfTime;

        protected int _duration;

        protected string _registrationDate;

        protected string _description;

        protected double _calculation;

        protected double _amountGenerated;

        protected double _interestGenerated;

        protected double _Percent;

        public FinancesManager(double amount, double rate, string registrationDate, string lapseOfTime, int duration, string description)
        {

            _type = "Element";

            _subType = "Finance";

            _amount = amount;

            _rate = rate;

            _registrationDate = registrationDate;

            _duration = duration;

            _lapseOfTime = lapseOfTime;

            _description = description;

        }

        public virtual string GetElementDetails()
        {

            return $"{_subType} {_type}\n   Date: {_registrationDate}\n   Amount: $ {_amount}\n   Interest rate: {_rate}%\n   Duration: {_duration} {_lapseOfTime}\n   Short description: {_description}\n";

        }

        public virtual string GetStringElement()
        {

            return $"{_subType} {_type}‖{_registrationDate}‖{_amount}‖{_rate}‖{_lapseOfTime}‖{_duration}‖{_description}";

        }

        protected virtual void ShowCalculationDetails()
        {

            Console.WriteLine($"Amount: $ {_amount}\nInterest rate: {_rate}%\nDuration: {_duration} {_lapseOfTime}.\n");

        }

        protected double DurationIntervail()
        {

            double durationIntervail = 0;

            switch (_lapseOfTime)
            {

                case "Days":

                    durationIntervail = (1.0 / 365) * _duration;
                
                    break;

                case "Weeks":

                    durationIntervail = (7.0 / 365) * _duration;

                    break;
                
                case "Months":

                    durationIntervail = (1.0 / 12) * _duration;

                    break;

                case "Years":

                    durationIntervail = _duration;

                    break;

            }

            return durationIntervail;

        }

        public virtual void Evaluation()
        {

            Console.Clear();

        }

        public virtual void Update()
        {

            GeneralEditor();

        }

        public void GeneralEditor()
        {

            bool updateValidation;

            string type = "";

            string invalidInput = "Please insert a valid number.\n";

            Console.Clear();

            while (true)
            {

                type = "amount";

                Console.Write($"Current {type}: $ {_amount}\nNew {type}: $ ");

                updateValidation = double.TryParse(Console.ReadLine(), out double newAmount);
                
                if (updateValidation)
                {

                    if (newAmount < 0.100)
                    {

                        Console.Clear();

                        Console.WriteLine($"The {type} is lower than the expected.\n");

                    }

                    else
                    {

                        _amount = newAmount;

                        Console.Clear();

                        break;
                    }

                }

                else
                {

                    Console.Clear();
                    
                    Console.WriteLine(invalidInput);

                }

            }

            if (_rate > -1)
            {

                Console.Clear();

                while (true)
                {
                    
                    type = "rate";

                    Console.Write($"Current {type}: {_rate}%\nNew {type}: % ");

                    updateValidation = double.TryParse(Console.ReadLine(), out double newRate);
                    
                    if (updateValidation)
                    {

                        if (newRate < 0.000)
                        {

                            Console.Clear();

                            Console.WriteLine($"The {type} is lower than the expected.\n");

                        }

                        else
                        {

                            _rate = newRate;

                            Console.Clear();

                            break;
                        }

                    }

                    else
                    {

                        Console.Clear();
                        
                        Console.WriteLine(invalidInput);

                    }

                }
            
            }

            Console.Clear();

            while (true)
            {

                type = "duration";

                Console.Write($"Current {type}: {_duration} {_lapseOfTime}\nNew duration of {_lapseOfTime}: ");

                updateValidation = int.TryParse(Console.ReadLine(), out int newDuration);
                
                if (updateValidation)
                {

                    if (newDuration < 1)
                    {

                        Console.Clear();

                        Console.WriteLine($"The {type} is lower than the expected.\n");

                    }

                    else
                    {

                        _duration = newDuration;

                        break;

                    }

                }

                else
                {

                    Console.Clear();
                    
                    Console.WriteLine(invalidInput);

                }

            }
            
            Console.Clear();

        }

    }

}