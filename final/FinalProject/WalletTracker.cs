namespace Inversions
{

    public class WalletTracker
    {

        DateOnly date = DateOnly.FromDateTime(DateTime.Now);

        protected List<Saving> _savings = new();

        protected List<Loan> _loans = new();

        public WalletTracker()
        {

            //

        }

        public void Menu()
        {

            bool mainMenuRunning = true;

            Console.Clear();

            Console.WriteLine($"Welcome to the personal finance calculator program.\nDate: {date}\n");

            while (mainMenuRunning == true)
            {

                Console.Write($"Menu Options:\n  1: Show elements registered.\n  2: Add a new element to the registry.\n  3: Erase an element from the registry.\n  4: Update an element.\n  5: Show the teoric progression of an element.\n  6: Save the registry.\n  7: Load a registry.\n  0: Exit the program.\nSelection: ");

                bool userInput = int.TryParse(Console.ReadLine(), out int userSelection);

                if (userInput)
                {

                    switch (userSelection)
                    {
                        
                        default:

                            InvalidSelectionMessage();

                            break;

                        case 1:

                            ShowList();

                            break;

                        case 2:

                            AddElement();

                            break;

                        case 3:

                            EraseElement();

                            break;
                        
                        case 4:

                            //

                            break;

                        case 5:

                            TeoricProgress();

                            break;

                        case 6:

                            //SaveRegistry();

                            break;

                        case 7:

                            //GetRegistry();

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

                    InvalidInputMessage();

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

                        InvalidSelectionMessage();
                        
                    }

                }
                else
                {

                     Console.Clear();

                    InvalidInputMessage();
                    
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

                    GetListdetail(menuSelection);

                    break;

                case 2:

                    GetListdetail(menuSelection);

                    break;

            }

        }

        private void GetListdetail(int listSelection)
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

        private void AddElement()
        {

            Console.Clear();

            string actionDescription = "Are you going to add a";

            int menuSelection = ListSelector(actionDescription);

            switch (menuSelection)
            {

                case 0:

                    Console.Clear();

                    break;

                case 1:

                    NewElement(menuSelection);

                    break;

                case 2:

                    NewElement(menuSelection);

                    break;

            }

        }

        private void NewElement(int listSelection)// W.I.P.
        {

            string element = null;
            
            string type = null;

            bool selectionRunning = true;

            bool userInput;

            bool consoleInput;

            Console.Clear();

            switch (listSelection)
            {

                case 1:

                    element = "Saving";

                    while (selectionRunning == true)
                    {

                        Console.Clear();

                        double amount;

                        double rate;

                        string startingDate;

                        int duration;

                        Console.Write("type");

                        userInput = int.TryParse(Console.ReadLine(), out int userSelection);

                        Console.Write("amount");

                        while (true)
                        {

                            consoleInput = int.TryParse(Console.ReadLine(), out int amountIput);

                            if (consoleInput)
                            {

                                amount = amountIput;

                                break;

                            }
                            else
                            {

                                InvalidInputMessage();    
                            
                            }

                        }

                        Console.Write("rate");

                        while (true)
                        {

                            consoleInput = int.TryParse(Console.ReadLine(), out int rateIput);

                            if (consoleInput)
                            {

                                rate = rateIput;

                                break;

                            }
                            else
                            {

                                InvalidInputMessage();    
                            
                            }

                        }

                        Console.Write("duration");

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

                                InvalidInputMessage();    
                            
                            }

                        }
                        
                        Console.Write("year");

                        while (true)
                        {

                            int year;

                            int month;

                            int day;

                            while (true)
                            {
                                
                                consoleInput = int.TryParse(Console.ReadLine(), out int yearIput);

                                if (consoleInput)
                                {

                                    year = yearIput;

                                    break;

                                }
                                else
                                {

                                    InvalidInputMessage();    
                                
                                }

                            }

                            Console.Write("month");

                            while (true)
                            {
                                
                                consoleInput = int.TryParse(Console.ReadLine(), out int monthIput);

                                if (consoleInput)
                                {

                                    month = monthIput;

                                    break;

                                }
                                else
                                {

                                    InvalidInputMessage();    
                                
                                }

                            }

                            Console.Write("day: ");

                            while (true)
                            {
                                
                                consoleInput = int.TryParse(Console.ReadLine(), out int dayInput);

                                if (consoleInput)
                                {

                                    day = dayInput;

                                    break;

                                }
                                else
                                {

                                    InvalidInputMessage();    
                                
                                }

                            }

                            startingDate = $"{year}/{month}/{day}";

                            break;

                        }

                        if (userInput)
                        {

                            switch (userSelection)
                            {
                                
                                default:

                                    InvalidSelectionMessage();

                                    break;

                                case 1:

                                    type = "Simple";

                                    SimpleSaving simpleSaving = new(amount, rate, startingDate, duration);

                                    _savings.Add(simpleSaving);

                                    selectionRunning = false;

                                    break;

                                case 2:

                                    type = "Compound";

                                    CompoundSaving compoundSaving = new(amount, rate, startingDate, duration);

                                    _savings.Add(compoundSaving);

                                    selectionRunning = false;

                                    break;
                                
                            }

                        }
                        else
                        {

                        InvalidInputMessage();

                        }

                    }

                    break;

                case 2:

                    element = "Loan";

                    //

                    break;

            }

            Console.WriteLine($"New {type} {element} created and added sucessfully");

        }
        
        private void EraseElement()// W.I.P.
        {

            Console.Clear();

            string actionDescription = "Are you going to erase a";

            int menuSelection = ListSelector(actionDescription);

            switch (menuSelection)
            {

                case 0:

                    Console.Clear();

                    break;

                case 1:

                    GetListdetail(menuSelection);

                    if (_savings.Count >0 )
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
                                
                                InvalidSelectionMessage();

                            }

                        }
                        else
                        {

                            InvalidInputMessage();

                        }

                    }

                    break;

                case 2:
/*
                    GetListdetail(menuSelection);

                    Console.Write("cuak ");

                    int user2 = int.Parse(Console.ReadLine())-1;

                    _loans.RemoveAt(user2);
*/
                    break;

            }

        }

        private void UpdateElement()// W.I.P.
        {
            //
        }

        private void TeoricProgress()
        {

            Console.Clear();

            string actionDescription = "Are you going to select a";

            int menuSelection = ListSelector(actionDescription);

            switch (menuSelection)
            {

                case 0:

                    Console.Clear();

                    break;

                case 1:

                    Console.Clear();

                    GetListdetail(menuSelection);

                    Console.Write("cuak ");

                    int user1 = int.Parse(Console.ReadLine())-1;

                    Saving requestedSaving = _savings[user1];

                    requestedSaving.Evaluation();

                    break;

                case 2:

                    Console.Clear();

                    GetListdetail(menuSelection);

                    Console.Write("cuak ");

                    int user2 = int.Parse(Console.ReadLine())-1;

                    _loans.RemoveAt(user2);

                    Loan requestedloan = _loans[user2];

                    requestedloan.Evaluation();

                    break;

            }

            
        }

        private void InvalidInputMessage()
        {

            Console.Clear();

            Console.WriteLine("Selection not valid, please insert a number.\n");
            
        }

        private void InvalidSelectionMessage()
        {

            Console.Clear();

            Console.WriteLine("Select a valid number.\n");
            
        }

    }

}