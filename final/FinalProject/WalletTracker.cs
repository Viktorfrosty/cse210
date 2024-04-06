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

                Console.Write($"Menu Options:\n  1: Show elements registered.\n  2: Add a new element to the registry.\n  3: Erase an element from the registry.\n  4: Update an element.\n  5: Show the teoric progression of an element.\n  6: Save the registry.\n  7: Load a registry.\n  0: Exit the program.\nSelection: ");

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

                            //AddElement();

                            break;

                        case 3:

                            Console.Clear();

                            Console.WriteLine("Test erase option.\n");

                            //EraseElement();

                            break;
                        
                        case 4:

                            Console.Clear();

                            Console.WriteLine("Test update option.\n");

                            //UpdateElement();

                            break;

                        case 5:

                            Console.Clear();

                            Console.WriteLine("Test theric progress option.\n");

                            //TeoricProgress();

                            break;

                        case 6:

                            SaveRegistry();

                            break;

                        case 7:

                            Console.Clear();

                            Console.WriteLine("Test load option.\n");

                            GetRegistry();

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

                        string registrationDate;

                        string lapseOfTime;

                        int duration;

                        string description;

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

                                ShowInvalidInputMessage();    
                            
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

                                ShowInvalidInputMessage();    
                            
                            }

                        }

                        Console.Write("lapse of time");

                        lapseOfTime = Console.ReadLine();

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

                                ShowInvalidInputMessage();    
                            
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

                                    ShowInvalidInputMessage();    
                                
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

                                    ShowInvalidInputMessage();    
                                
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

                                    ShowInvalidInputMessage();    
                                
                                }

                            }

                            registrationDate = $"{year}/{month}/{day}";

                            break;

                        }

                        Console.Write("description: ");

                        description = Console.ReadLine();

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

                                    break;

                                case 2:

                                    type = "Compound";

                                    CompoundSaving compoundSaving = new(amount, rate, registrationDate, lapseOfTime, duration, description);

                                    _savings.Add(compoundSaving);

                                    selectionRunning = false;

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

                    //

                    break;

            }

            Console.WriteLine($"New {type} {element} created and added sucessfully");

        }
        
        private void EraseElement(int listSelection)// W.I.P.
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

                    GetListdetails(menuSelection);

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
/*
                    GetListdetails(menuSelection);

                    Console.Write("cuak ");

                    int user2 = int.Parse(Console.ReadLine())-1;

                    _loans.RemoveAt(user2);
*/
                    break;

            }

        }

        private void UpdateElement(int listSelection)// W.I.P.
        {
            //
        }

        private void TeoricProgress(int listSelection)// W.I.P.
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

                    GetListdetails(menuSelection);

                    Console.Write("cuak ");

                    int user1 = int.Parse(Console.ReadLine())-1;

                    Saving requestedSaving = _savings[user1];

                    requestedSaving.Evaluation();

                    break;

                case 2:

                    Console.Clear();

                    GetListdetails(menuSelection);

                    Console.Write("cuak ");

                    int user2 = int.Parse(Console.ReadLine())-1;

                    _loans.RemoveAt(user2);

                    Loan requestedloan = _loans[user2];

                    requestedloan.Evaluation();

                    break;

            }

            
        }

        private void SaveRegistry()
        {

            Console.Write("\nSave the registry on a CSV file.\n(Do not add the .CSV at the end of the file name.\nFile name: ");

            string fileName = Console.ReadLine()+".csv";

            if (_savings.Count > 0)
            {

                using (StreamWriter outputFile = new(fileName))
                {

                    foreach (Saving record in _savings)
                    {

                        outputFile.WriteLine(record.GetStringElement());

                    }
                    
                }

            }
            
            else if (_loans.Count > 0)
            {

                using (StreamWriter outputFile = new(fileName))
                {

                    foreach (Loan record in _loans)
                    {

                        outputFile.WriteLine(record.GetStringElement());

                    }
                    
                }

            }

            Console.Clear();

            Console.WriteLine("File saved.\n");

        }

        private void GetRegistry()// W.I.P.
        {
            
            Console.Write("\nLoad the registry from a CSV file.\n(Do not add the .CSV at the end of the file name.\nFile name: ");

            string fileName = Console.ReadLine()+".csv";

            if (File.Exists(fileName))
            {

                using (StreamReader reader = new(fileName))
                {

                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {

                        try
                        {
                            
                            string[] parts = line.Split("‖");

                            string element = parts[0];

                            string registrationDate = parts[1];

                            int amount = int.Parse(parts[2]);

                            int rate = int.Parse(parts[3]);

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

                                    CompoundSaving compoundSaving = new(amount, rate, registrationDate, lapseOfTime, duration, description);

                                    _savings.Add(compoundSaving);

                                    break;

                                case "Simple Loan":// W.I.P.

                                    break;

                                // other loans.

                            }

                        }
                        catch (Exception)
                        {
                            
                            Console.WriteLine($"Error: {fileName} File formated inproperly.");

                            break;

                        }

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

            Console.WriteLine("Select a valid number.\n");
            
        }

    }

}