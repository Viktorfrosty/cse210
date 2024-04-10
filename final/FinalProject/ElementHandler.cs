namespace Inversions
{

    public class ElementHandler
    {

        private DateOnly _date = DateOnly.FromDateTime(DateTime.Now);

        private List<Saving> _savings;

        private List<Loan> _loans;

        public ElementHandler(List<Saving> savings, List<Loan> loans)
        {

            _savings = savings;

            _loans = loans;

        }

        public void GetDetails(int listSelection)
        {

            Console.Clear();

            int teoricListIndex = 0;

            switch (listSelection)
            {

                case 1:

                    if (_savings.Count > 0)
                    {

                        Console.WriteLine("Savings:\n");

                        foreach (Saving register in _savings)
                        {

                            teoricListIndex++;

                            Console.WriteLine($"{teoricListIndex}: {register.GetElementDetails()}");

                        }

                    }

                    else
                    {
                        
                        Console.WriteLine("No Savings found.\n");

                    }

                    break;

                case 2:

                    if (_loans.Count > 0)
                    {

                        Console.WriteLine("Loans:\n");

                        foreach (Loan register in _loans)
                        {

                            teoricListIndex++;

                            Console.WriteLine($"{teoricListIndex}: {register.GetElementDetails()}");

                        }

                    }

                    else
                    {
                        
                        Console.WriteLine("No Loans found.\n");
                        
                    }

                    break;

            }

        }
        
        public void NewElement(int listSelection)
        {

            Console.Clear();

            if (listSelection != 0)
            {

                string element = null;
                    
                string type = null;

                bool creationRunning = true;

                while (creationRunning == true)
                {

                    int userSelection = 0;

                    bool consoleInput;
                    
                    double amount;

                    double fees = 0;

                    int nPayments = 1;

                    double rate = -1;

                    int interestCompound = 0;

                    string lapseOfTime = null;

                    int duration;

                    string description;

                    string registrationDate = _date.ToString();

                    bool TypeSelection = true;

                    Console.Clear();

                    while (TypeSelection == true)
                    {

                        switch (listSelection)
                        {
                            
                            case 1:
                        
                                Console.Write("Type of Savings:\n1: Simple.\n2: Compound.\n\nSelection: ");

                                break;
                            
                            case 2:
                        
                                Console.Write("Type of Loan:\n1: Personal.\n2: Payday.\n\nSelection: ");

                                break;

                        }

                        bool userInput = int.TryParse(Console.ReadLine(), out userSelection);

                        if (userInput)
                        {

                            switch (userSelection)
                            {
                                
                                default:

                                    ShowInvalidSelectionMessage();

                                    break;

                                case 1:

                                    TypeSelection = false;

                                    break;

                                case 2:

                                    TypeSelection = false;

                                    break;
                                
                            }
                            
                        }

                        else
                        {

                            ShowInvalidInputMessage();

                        }

                    }

                    if(listSelection == 2 && userSelection == 1)
                    {

                        Console.Clear();

                        while (true)
                        {
                            Console.Write("Quantity of amortizations: ");

                            consoleInput = int.TryParse(Console.ReadLine(), out int nPaymentsInput);

                            if (consoleInput)
                            {

                                if (nPaymentsInput >= 1)
                                {

                                    nPayments = nPaymentsInput;

                                    break;

                                }

                                else
                                {
                                    Console.WriteLine("The value is lower than the expected, introduce a higher value.\n");
                                }

                            }
                            
                            else
                            {

                                ShowInvalidInputMessage();

                            }

                        }

                    }

                    Console.Clear();

                    while (true)
                    {

                        Console.Write("Amount of money (do not include the '$' symbol): ");

                        consoleInput = double.TryParse(Console.ReadLine(), out double amountInput);

                        if (consoleInput)
                        {

                            amount = amountInput;

                            break;

                        }

                        else
                        {

                            ShowInvalidInputMessage();    
                        
                        }

                    }

                    if (listSelection == 1 && userSelection == 2)
                    {

                        Console.Clear();

                        while (true)
                        {

                            Console.Clear();

                            Console.Write("Times the interest is compounded yearly: ");
                            
                            consoleInput = int.TryParse(Console.ReadLine(), out int durationInput);

                            if (consoleInput)
                            {

                                if (durationInput >= 2)
                                {

                                    interestCompound = durationInput;

                                    break;

                                }

                                else
                                {
                                    
                                    Console.WriteLine("Yearly compound should be 2 at minimum.\n");

                                }

                            }

                            else
                            {

                                ShowInvalidInputMessage();    
                            
                            }

                        }

                    }

                    Console.Clear();
                    if (listSelection == 2 && userSelection == 2)
                    {

                        lapseOfTime = "Days";

                        Console.Clear();

                        while (true)
                        {

                            Console.Write("Fee amount (do not include the '$' symbol): ");

                            consoleInput = double.TryParse(Console.ReadLine(), out double feeInput);

                            if (consoleInput)
                            {

                                fees = feeInput;

                                break;

                            }

                            else
                            {
                                
                                ShowInvalidInputMessage();

                            }                            
                        
                        }

                        Console.Clear();

                        while (true)
                        {
                    
                            Console.Write($"Duration (Number of {lapseOfTime}): ");

                            consoleInput = int.TryParse(Console.ReadLine(), out int durationInput);

                            if (consoleInput)
                            {

                                duration = durationInput;

                                break;

                            }

                            else
                            {

                                ShowInvalidInputMessage();    
                            
                            }

                        }

                    }
                    
                    else
                    {

                        bool lapseSelection = true;

                        Console.Clear();

                        while (true)
                        {
                        
                            Console.Write("Rate of interest (do not include the '%' symbol): ");

                            consoleInput = double.TryParse(Console.ReadLine(), out double rateInput);

                            if (consoleInput)
                            {

                                rate = rateInput;

                                break;

                            }

                            else
                            {

                                ShowInvalidInputMessage();    
                            
                            }

                        }

                        Console.Clear();

                        while (lapseSelection == true)
                        {

                            Console.Write("Lapse of time:\n  1: Days.\n  2: Weeks.\n  3: Months.\n  4: Years.\n\nSelection: ");

                            consoleInput = int.TryParse(Console.ReadLine(), out int durationInput);

                            if (consoleInput)
                            {

                                switch (durationInput)
                                {
                                    default:

                                        ShowInvalidSelectionMessage();

                                        break;
                                    
                                    case 1:

                                        lapseOfTime = "Days";

                                        lapseSelection = false;

                                        break;
                                    
                                    case 2:

                                        lapseOfTime = "Weeks";

                                        lapseSelection = false;

                                        break;

                                    case 3:

                                        lapseOfTime = "Months";

                                        lapseSelection = false;

                                        break;

                                    case 4:

                                        lapseOfTime = "Years";

                                        lapseSelection = false;

                                        break;

                                }

                            }

                            else
                            {

                                ShowInvalidInputMessage();    
                            
                            }


                        }

                        Console.Clear();

                        while (true)
                        {
                    
                            Console.Write($"Duration (Number of {lapseOfTime}): ");

                            consoleInput = int.TryParse(Console.ReadLine(), out int durationInput);

                            if (consoleInput)
                            {

                                duration = durationInput;

                                break;

                            }

                            else
                            {

                                ShowInvalidInputMessage();    
                            
                            }

                        }

                    }

                    Console.Clear();
                    
                    Console.Write("Short description: ");

                    description = Console.ReadLine();

                    switch (listSelection)
                    {

                        case 1:

                            element = "Saving";

                            switch (userSelection)
                            {

                                case 1:

                                    type = "Simple";

                                    SimpleSaving simpleSaving = new(amount, rate, registrationDate, lapseOfTime, duration, description);

                                    _savings.Add(simpleSaving);

                                    creationRunning = false;

                                    break;

                                case 2:

                                    type = "Compound";

                                    CompoundSaving compoundSaving = new(amount, rate, interestCompound, registrationDate, lapseOfTime, duration, description);

                                    _savings.Add(compoundSaving);

                                    creationRunning = false;

                                    break;
                                
                            }

                            break;
                        
                        case 2:

                            element = "Loan";

                            switch (userSelection)
                            {

                                case 1:

                                    type = "Personal";

                                    PersonalLoan personalLoan = new(amount, nPayments, rate, registrationDate, lapseOfTime, duration, description);

                                    _loans.Add(personalLoan);

                                    creationRunning = false;

                                    break;
                                
                                case 2:

                                    type = "Payday";

                                    PaydayLoan paydayLoan = new(amount, fees, rate, registrationDate, lapseOfTime, duration, description);

                                    _loans.Add(paydayLoan);

                                    creationRunning = false;

                                    break;

                            }
                            
                            break;

                    }

                }

                Console.Clear();

                Console.WriteLine($"New {type} {element} created and registered sucessfully.\n");
                
            }

            else
            {

                Console.Clear();

            }

        }
        
        public void EraseElement(int listSelection)
        {

            switch (listSelection)
            {

                case 0:

                    Console.Clear();

                    break;

                case 1:

                    GetDetails(listSelection);

                    if (_savings.Count > 0)
                    {

                        Console.Write("Select the element that is going to be erased.\n(Select 0 to return to the main menu)\nSelection: ");

                        bool savingsSelection = int.TryParse(Console.ReadLine(), out int elementIndex);

                        elementIndex -= 1;

                        if (savingsSelection)
                        {

                            if (elementIndex == -1)
                            {

                                Console.Clear();

                                break;

                            }
                            
                            else if (_savings.Count >= elementIndex && _savings[elementIndex] != null)
                            {

                                
                                _savings.RemoveAt(elementIndex);

                                Console.Clear();
                                
                                Console.WriteLine("Saving removed from the list.\n");

                            }
                            
                            else
                            {
                                
                                ShowInvalidSelectionMessage();

                            }

                        }

                        else
                        {

                            ShowInvalidInputMessage();

                        }

                    }

                    break;

                case 2:

                    GetDetails(listSelection);

                    if (_loans.Count > 0)
                    {

                        Console.Write("Select the element that is going to be erased.\n(Select 0 to return to the main menu)\nSelection: ");

                        bool loansSelection = int.TryParse(Console.ReadLine(), out int elementIndex);

                        elementIndex -= 1;

                        if (loansSelection)
                        {

                            if (elementIndex == -1)
                            {

                                Console.Clear();

                                break;

                            }
                            
                            else if (_loans.Count >= elementIndex && _loans[elementIndex] != null)
                            {

                                
                                _loans.RemoveAt(elementIndex);

                                Console.Clear();
                                
                                Console.WriteLine("Loan removed from the list.\n");

                            }
                            
                            else
                            {
                                
                                ShowInvalidSelectionMessage();

                            }

                        }
                        
                        else
                        {

                            ShowInvalidInputMessage();

                        }

                    }

                    break;

            }

        }

        public void UpdateElement(int listSelection)
        {

            switch (listSelection)
            {

                case 0:

                    Console.Clear();

                    break;

                case 1:

                    GetDetails(listSelection);

                    if (_savings.Count > 0)
                    {

                        Console.Write("Select the element that is going to be update.\n(Select 0 to return to the main menu)\nSelection: ");

                        bool savingsSelection = int.TryParse(Console.ReadLine(), out int elementIndex);

                        elementIndex -= 1;

                        if (savingsSelection)
                        {

                            if (elementIndex == -1)
                            {

                                Console.Clear();

                                break;

                            }
                            
                            else if (_savings.Count >= elementIndex && _savings[elementIndex] != null)
                            {

                                Saving selectedElement = _savings[elementIndex];

                                Console.Clear();

                                selectedElement.Update();
                                
                                Console.WriteLine("Saving updated.\n");

                            }
                            
                            else
                            {
                                
                                ShowInvalidSelectionMessage();

                            }

                        }

                        else
                        {

                            ShowInvalidInputMessage();

                        }

                    }

                    break;

                case 2:

                    GetDetails(listSelection);

                    if (_loans.Count > 0)
                    {

                        Console.Write("Select the element that is going to be update.\n(Select 0 to return to the main menu)\nSelection: ");

                        bool loansSelection = int.TryParse(Console.ReadLine(), out int elementIndex);

                        elementIndex -= 1;

                        if (loansSelection)
                        {

                            if (elementIndex == -1)
                            {

                                Console.Clear();

                                break;

                            }
                            
                            else if (_loans.Count >= elementIndex && _loans[elementIndex] != null)
                            {

                                Loan selectedElement = _loans[elementIndex];

                                selectedElement.Update();
                                
                                Console.WriteLine("Loan updated.\n");

                            }
                            
                            else
                            {
                                
                                ShowInvalidSelectionMessage();

                            }

                        }
                        
                        else
                        {

                            ShowInvalidInputMessage();

                        }

                    }

                    break;

            }

        }

        public void TeoricProgress(int listSelection)
        {

            switch (listSelection)
            {

                case 0:

                    Console.Clear();

                    break;

                case 1:

                    Console.Clear();

                    GetDetails(listSelection);

                    if (_savings.Count > 0)
                    {

                        Console.Write("Select the element that is going to be evaluated.\n(Select 0 to return to the main menu)\nSelection: ");

                        bool savingsSelection = int.TryParse(Console.ReadLine(), out int elementIndex);

                        elementIndex -= 1;

                        if (savingsSelection)
                        {

                            if (elementIndex == -1)
                            {

                                Console.Clear();

                                break;

                            }
                            
                            else if (_savings.Count >= elementIndex && _savings[elementIndex] != null)
                            {
                                
                                Saving selectedElement = _savings[elementIndex];

                                selectedElement.Evaluation();

                            }
                            
                            else
                            {
                                
                                ShowInvalidSelectionMessage();

                            }

                        }
                        
                        else
                        {

                            ShowInvalidInputMessage();

                        }

                    }

                    break;

                case 2:

                    Console.Clear();

                    GetDetails(listSelection);

                    if (_loans.Count > 0)
                    {

                        Console.Write("Select the element that is going to be evaluated.\n(Select 0 to return to the main menu)\nSelection: ");

                        bool LoansSelection = int.TryParse(Console.ReadLine(), out int elementIndex);

                        elementIndex -= 1;

                        if (LoansSelection)
                        {

                            if (elementIndex == -1)
                            {

                                Console.Clear();

                                break;

                            }
                            
                            else if (_loans.Count >= elementIndex && _loans[elementIndex] != null)
                            {
                                
                                Loan selectedElement = _loans[elementIndex];

                                selectedElement.Evaluation();

                            }
                            
                            else
                            {
                                
                                ShowInvalidSelectionMessage();

                            }

                        }

                        else
                        {

                            ShowInvalidInputMessage();

                        }

                    }

                    break;

            }

            
        }

        public void ShowInvalidInputMessage()
        {

            Console.Clear();

            Console.WriteLine("Selection not valid, please insert a number.\n");
            
        }

        public void ShowInvalidSelectionMessage()
        {

            Console.Clear();

            Console.WriteLine("Select a valid option.\n");
            
        }

    }
    
}