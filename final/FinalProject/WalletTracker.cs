using System.Runtime.Serialization;

namespace Inversions
{

    public class WalletTracker
    {

        DateOnly date = DateOnly.FromDateTime(DateTime.Now);

        List<Saving> _savings = new();

        List<Loan> _loans = new();

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

                Console.Write($"\nMenu Options:\n  1: Show elements listed.\n  2: Add a new element to the list.\n  3: Erase an element from the list.\n  4: Update an element.\n  5: Show the progression of an element.\n  0: Exit the program.\nSelection: ");

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

                            EraseElement();

                            break;

                        case 5:

                            Evaluation();

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

                Console.Write($"\n{actionDescription}:\n  1: Saving.\n  2: Loan.\n  0: Go back to te main menu.\nSelection: ");

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

                    }
                    else
                    {
                        
                        Console.WriteLine("No Savings found.");

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

                    }
                    else
                    {
                        
                        Console.WriteLine("No Loans found.");
                        
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

        private void NewElement(int listSelection)
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

                        double apr;

                        string startingDate;

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

                        Console.Write("apr");

                        while (true)
                        {

                            consoleInput = int.TryParse(Console.ReadLine(), out int aprIput);

                            if (consoleInput)
                            {

                                apr = aprIput;

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

                            Console.Write("day");

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

                                    SimpleSaving simpleSaving = new(amount, apr, startingDate);

                                    _savings.Add(simpleSaving);

                                    selectionRunning = false;

                                    break;

                                case 2:

                                    type = "Compound";

                                    CompoundSaving compoundSaving = new(amount, apr, startingDate);

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
        
        private void EraseElement()
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

                    break;

                case 2:

                    GetListdetail(menuSelection);

                    _loans.RemoveAt(1);

                    break;

            }

        }

        private void Evaluation()
        {

            Console.Clear();
            
        }

        private void InvalidInputMessage()
        {

            Console.Clear();

            Console.WriteLine("Selection not valid, please insert a number.");
            
        }

        private void InvalidSelectionMessage()
        {

            Console.Clear();

            Console.WriteLine("Select a valid number.");
            
        }

    }

}