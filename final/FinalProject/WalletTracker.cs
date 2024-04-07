using System.IO;

namespace Inversions
{

    public class WalletTracker
    {

        DateOnly _date = DateOnly.FromDateTime(DateTime.Now);

        protected List<Saving> _savings = new();

        protected List<Loan> _loans = new();

        public WalletTracker()
        {

            //

        }

        public void Menu()// W.I.P.
        {

            bool mainMenuRunning = true;

            Console.Clear();

            Console.WriteLine($"Welcome to the personal finance calculator program.\nDate: {_date}\n");

            while (mainMenuRunning == true)
            {

                string actionDescription;

                int menuSelection;

                Console.Write($"Menu Options:\n  1: Show elements registered.\n  2: Add a new element to the registry.\n  3: Erase an element from the registry.\n  4: Update an element from the registry.\n  5: Show the teoric progression of an element.\n  6: Save the registry.\n  7: Load a registry.\n  0: Exit the program.\nSelection: ");

                bool userInput = int.TryParse(Console.ReadLine(), out int userSelection);

                if (userInput)
                {

                    switch (userSelection)
                    {
                        
                        default:

                            ShowInvalidSelectionMessage();

                            break;

                        case 1:

                            ShowList();

                            break;

                        case 2:

                            Console.Clear();

                            Console.WriteLine("Test erase option.\n");

                            actionDescription = "Are you going to add a";

                            menuSelection = ListSelector(actionDescription);

                            NewElement(menuSelection);

                            break;

                        case 3:

                            Console.Clear();

                            actionDescription = "Are you going to erase a";

                            menuSelection = ListSelector(actionDescription);

                            EraseElement(menuSelection);

                            break;
                        
                        case 4:

                            Console.Clear();

                            actionDescription = "Are you going to update a";

                            menuSelection = ListSelector(actionDescription);

                            UpdateElement(menuSelection);

                            break;

                        case 5:

                            Console.Clear();

                            actionDescription = "Are you going to select a";

                            menuSelection = ListSelector(actionDescription);

                            TeoricProgress(menuSelection);

                            break;

                        case 6:// W.I.P.

                            Console.Clear();

                            Console.WriteLine("Save registry option placeholder.\n");

                            // SaveRegistry();

                            break;

                        case 7:// W.I.P.
 
                            Console.Clear();

                            Console.WriteLine("Load registry option placeholder.\n");

                            // GetRegistry();

                            break;

                        case 0:

                            mainMenuRunning = false;

                            Console.Clear();

                            Console.WriteLine("Goodbye.\n");

                            break;

                    }

                }
                else
                {

                    ShowInvalidInputMessage();

                }

            }


        }

        private int ListSelector(string actionDescription)
        {

            int listSelection;

            Console.Clear();

            while (true)
            {

                Console.Write($"{actionDescription}:\n  1: Saving.\n  2: Loan.\n  0: Go back to te main menu.\nSelection: ");

                bool userInput = int.TryParse(Console.ReadLine(), out int userSelection);

                if (userInput)
                {

                    if (userSelection == 0 || userSelection == 1 || userSelection == 2)
                    {

                        listSelection = userSelection;

                        break;

                    }
                    else
                    {

                         Console.Clear();

                        ShowInvalidSelectionMessage();
                        
                    }

                }
                else
                {

                     Console.Clear();

                    ShowInvalidInputMessage();
                    
                }

            }

            return listSelection;

        }

        private void ShowList()
        {

            Console.Clear();

            string actionDescription = "You want to see";

            int menuSelection = ListSelector(actionDescription);

            switch (menuSelection)
            {

                case 0:

                    Console.Clear();

                    break;

                case 1:

                    GetListdetails(menuSelection);

                    break;

                case 2:

                    GetListdetails(menuSelection);

                    break;

            }

        }

        private void GetListdetails(int listSelection)
        {

            Console.Clear();

            int teoricListIndex = 0;

            switch (listSelection)
            {

                case 1:

                    if (_savings.Count > 0)
                    {

                        foreach (Saving register in _savings)
                        {

                            teoricListIndex++;

                            Console.WriteLine($"{teoricListIndex}: {register.GetElementDetails()}");

                        }

                        Console.WriteLine("");

                    }
                    else
                    {
                        
                        Console.WriteLine("No Savings found.\n");

                    }

                    break;

                case 2:

                    if (_loans.Count > 0)
                    {

                        foreach (Loan register in _loans)
                        {

                            teoricListIndex++;

                            Console.WriteLine($"{teoricListIndex}: {register.GetElementDetails()}");

                        }

                        Console.WriteLine("");

                    }
                    else
                    {
                        
                        Console.WriteLine("No Loans found.\n");
                        
                    }

                    break;

            }

        }

        private void AddElement()// W.I.P.
        {

            // this was not really necessary after all...

        }

        private void NewElement(int listSelection)
        {

            string element = null;
            
            string type = null;

            bool selectionRunning = true;

            bool userInput;

            int userSelection;

            bool consoleInput;
            
            double amount;

            double rate;

            string lapseOfTime;

            int duration;

            string description;

            string registrationDate = _date.ToString();

            Console.Clear();

            if (listSelection != 0)
            {

                while (selectionRunning == true)
                {

                    Console.Write("Amount of money: ");

                    while (true)
                    {

                        consoleInput = double.TryParse(Console.ReadLine(), out double amountIput);

                        if (consoleInput)
                        {

                            amount = amountIput;

                            break;

                        }
                        else
                        {

                            ShowInvalidInputMessage();    
                        
                        }

                    }

                    Console.Clear();
                    
                    Console.Write("Rate of interest (do not include the % symbol): ");

                    while (true)
                    {

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
                    
                    Console.Write("Lapse of time (days/months/years): ");

                    lapseOfTime = Console.ReadLine();

                    Console.Clear();
                
                    Console.Write($"Duration (Number of {lapseOfTime}): ");

                    while (true)
                    {
                        
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

                    Console.Clear();
                    
                    Console.Write("Description: ");

                    description = Console.ReadLine();

                    switch (listSelection)
                    {

                        case 1:

                            element = "Saving";

                            bool savingsTypeSelection = true;

                            while (savingsTypeSelection == true)
                            {

                                Console.Clear();
                                
                                Console.Write("type (1. Simple / 2. Compound): ");

                                userInput = int.TryParse(Console.ReadLine(), out userSelection);

                                if (userInput)
                                {

                                    switch (userSelection)
                                    {
                                        
                                        default:

                                            ShowInvalidSelectionMessage();

                                            break;

                                        case 1:

                                            type = "Simple";

                                            SimpleSaving simpleSaving = new(amount, rate, registrationDate, lapseOfTime, duration, description);

                                            _savings.Add(simpleSaving);

                                            selectionRunning = false;

                                            savingsTypeSelection = false;

                                            break;

                                        case 2:

                                            type = "Compound";

                                            int interestCompound;

                                            while (true)
                                            {

                                                Console.Clear();

                                                Console.Write("Times the interest is compounded yearly: ");
                                                
                                                consoleInput = int.TryParse(Console.ReadLine(), out int durationInput);

                                                if (consoleInput)
                                                {

                                                    interestCompound = durationInput;

                                                    break;

                                                }
                                                else
                                                {

                                                    ShowInvalidInputMessage();    
                                                
                                                }

                                            }

                                            CompoundSaving compoundSaving = new(amount, rate, interestCompound, registrationDate, lapseOfTime, duration, description);

                                            _savings.Add(compoundSaving);

                                            selectionRunning = false;

                                            savingsTypeSelection = false;

                                            break;
                                        
                                    }
                                    
                                }
                                else
                                {

                                    ShowInvalidInputMessage();

                                }

                            }

                            break;

                        case 2:

                            element = "Loan";

                            bool loanTypeSelection = true;

                            while (loanTypeSelection)
                            {

                                Console.Clear();

                                Console.Write("type (1. Personal / 2. Payday): ");

                                userInput = int.TryParse(Console.ReadLine(), out userSelection);

                                if (userInput)
                                {

                                    switch (userSelection)
                                    {
                                        
                                        default:

                                            ShowInvalidSelectionMessage();

                                            break;

                                        case 1:

                                            type = "Personal";

                                            PersonalLoan personalLoan = new(amount, rate, registrationDate, lapseOfTime, duration, description);

                                            _loans.Add(personalLoan);

                                            selectionRunning = false;

                                            loanTypeSelection = false;

                                            break;

                                        case 2:

                                            type = "Payday";

                                            PaydayLoan paydayLoan = new(amount, rate, registrationDate, lapseOfTime, duration, description);

                                            _loans.Add(paydayLoan);

                                            selectionRunning = false;

                                            loanTypeSelection = false;

                                            break;
                                        
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

                Console.Clear();

                Console.WriteLine($"New {type} {element} created and added sucessfully.\n");
                
            }
            else
            {

                Console.Clear();

            }

        }
        
        private void EraseElement(int listSelection)
        {

            switch (listSelection)
            {

                case 0:

                    Console.Clear();

                    break;

                case 1:

                    GetListdetails(listSelection);

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

                    GetListdetails(listSelection);

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

        private void UpdateElement(int listSelection)// W.I.P.
        {

            switch (listSelection)
            {
                
                default:
                    
                    Console.Clear();

                    Console.WriteLine("update option placeholder.\n");

                    break;

                case 0:

                    Console.Clear();

                    break;

            }

        }

        private void TeoricProgress(int listSelection)
        {

            switch (listSelection)
            {

                case 0:

                    Console.Clear();

                    break;

                case 1:

                    Console.Clear();

                    GetListdetails(listSelection);

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
                                
                                Saving evaluatedElement = _savings[elementIndex];

                                evaluatedElement.Evaluation();

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

                    GetListdetails(listSelection);

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
                                
                                Loan evaluatedElement = _loans[elementIndex];

                                evaluatedElement.Evaluation();

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

        private void SaveRegistry()// W.I.P. (Possible moving this to another class)
        {
            
            Console.Clear();

            Console.Write("Save the registry on a CSV file.\n(Do not add the .CSV at the end of the file name.\nFile name: ");

            string fileName = Console.ReadLine()+".csv";

            if (_savings.Count > 0)
            {

                using StreamWriter outputFile = new(fileName);

                foreach (Saving record in _savings)
                {

                    outputFile.WriteLine(record.GetStringElement());

                }

            }
            
            else if (_loans.Count > 0)
            {

                using StreamWriter outputFile = new(fileName);

                foreach (Loan record in _loans)
                {

                    outputFile.WriteLine(record.GetStringElement());

                }

            }

            Console.Clear();

            Console.WriteLine("File saved.\n");

        }

        private void GetRegistry()// W.I.P. (Possible moving this to another class)
        {

            Console.Clear();
            
            Console.Write("Load the registry from a CSV file.\n(Do not add the .CSV at the end of the file name.\nFile name: ");

            string fileName = Console.ReadLine()+".csv";

            if (File.Exists(fileName))
            {

                using StreamReader reader = new(fileName);

                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    try
                    {

                        string[] parts = line.Split("‖");

                        string element = parts[0];

                        string registrationDate = parts[1];

                        double amount = double.Parse(parts[2]);

                        double rate = double.Parse(parts[3]);

                        string lapseOfTime = parts[4];

                        int duration = int.Parse(parts[5]);

                        string description = parts[6];

                        switch (element)
                        {

                            case "Simple Saving":

                                SimpleSaving simpleSaving = new(amount, rate, registrationDate, lapseOfTime, duration, description);

                                _savings.Add(simpleSaving);

                                break;

                            case "Compound Saving":

                                int interestCompound = int.Parse(parts[7]);

                                CompoundSaving compoundSaving = new(amount, rate, interestCompound, registrationDate, lapseOfTime, duration, description);

                                _savings.Add(compoundSaving);

                                break;

                            case "Personal Loan":

                                PersonalLoan personalLoan = new(amount, rate, registrationDate, lapseOfTime, duration, description);

                                _loans.Add(personalLoan);

                                break;

                            case "Payday Loan":

                                PaydayLoan paydayLoan = new(amount, rate, registrationDate, lapseOfTime, duration, description);

                                _loans.Add(paydayLoan);

                                break;

                        }

                        Console.Clear();

                        Console.WriteLine($"File {fileName} loaded succesfully.\n");

                    }
                    catch (Exception)
                    {

                        Console.Clear();

                        Console.WriteLine($"Error: {fileName} File formated inproperly.\n");

                        break;

                    }

                }

            }
            else
            {
                
                Console.Clear();

                Console.WriteLine($"Error: File {fileName} not found.\n");

            }

        }

        private void ShowInvalidInputMessage()
        {

            Console.Clear();

            Console.WriteLine("Selection not valid, please insert a number.\n");
            
        }

        private void ShowInvalidSelectionMessage()
        {

            Console.Clear();

            Console.WriteLine("Select a valid option.\n");
            
        }

    }

}