namespace Inversions
{

    public class WalletTracker
    {

        private DateOnly _date = DateOnly.FromDateTime(DateTime.Now);

        private List<Saving> _savings = new();

        private List<Loan> _loans = new();

        public WalletTracker()
        {

            //

        }

        public void Menu()
        {

            bool mainMenuRunning = true;

            FileHandler fileHandler = new(_savings, _loans);

            ElementHandler elementHandler = new(_savings, _loans);

            Console.WriteLine($"\nWelcome to the basic personal finance calculator program.\nDate: {_date}\n");

            while (mainMenuRunning == true)
            {

                string actionDescription;

                int menuSelection;

                Console.Write($"Menu Options:\n1: Show elements registered.\n2: Add a new element to the registry.\n3: Erase an element from the registry.\n4: Update an element from the registry.\n5: Show the teoric progression of an element.\n6: Save the registry.\n7: Load a registry.\n0: Exit the program.\n\nSelection: ");

                bool userInput = int.TryParse(Console.ReadLine(), out int userSelection);

                if (userInput)
                {

                    switch (userSelection)
                    {
                        
                        default:

                            elementHandler.ShowInvalidSelectionMessage();

                            break;

                        case 1:

                            ShowList();

                            break;

                        case 2:

                            Console.Clear();

                            Console.WriteLine("Test erase option.\n");

                            actionDescription = "Are you going to add a";

                            menuSelection = ListSelector(actionDescription);

                            elementHandler.NewElement(menuSelection);

                            break;

                        case 3:

                            Console.Clear();

                            actionDescription = "Are you going to erase a";

                            menuSelection = ListSelector(actionDescription);

                            elementHandler.EraseElement(menuSelection);

                            break;
                        
                        case 4:

                            Console.Clear();

                            actionDescription = "Are you going to update a";

                            menuSelection = ListSelector(actionDescription);

                            elementHandler.UpdateElement(menuSelection);

                            break;

                        case 5:

                            Console.Clear();

                            actionDescription = "Are you going to select a";

                            menuSelection = ListSelector(actionDescription);

                            elementHandler.TeoricProgress(menuSelection);

                            break;

                        case 6:

                            fileHandler.SaveRegistry();

                            break;

                        case 7:

                            bool getRegistryRunning = true;

                            while (getRegistryRunning == true)
                            {

                                Console.Clear();

                                Console.Write("Warning! This will erase your current registry, do you want to proceed?\n1: Yes.\n2: No.\n\nSelection: ");

                                bool WarningValidationInput = int.TryParse(Console.ReadLine(), out int WarningValidationSelection);

                                if (WarningValidationInput)
                                {

                                    switch (WarningValidationSelection)
                                    {

                                        default:

                                            Console.Clear();

                                            elementHandler.ShowInvalidSelectionMessage();

                                            break;

                                        case 1:

                                            Console.Clear();
                                            
                                            fileHandler.GetRegistry();

                                            getRegistryRunning = false;

                                            break;

                                        case 2:

                                            Console.Clear();

                                            getRegistryRunning = false;
                                            
                                            break;

                                    }

                                }

                                else
                                {

                                    elementHandler.ShowInvalidInputMessage();

                                }

                            }

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

                    elementHandler.ShowInvalidInputMessage();

                }

            }


        }

        private int ListSelector(string actionDescription)
        {

            ElementHandler elementHandler = new(_savings, _loans);

            int listSelection;

            Console.Clear();

            while (true)
            {

                Console.Write($"{actionDescription}:\n1: Saving.\n2: Loan.\n0: Go back to te main menu.\n\nSelection: ");

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

                        elementHandler.ShowInvalidSelectionMessage();
                        
                    }

                }

                else
                {

                     Console.Clear();

                    elementHandler.ShowInvalidInputMessage();
                    
                }

            }

            return listSelection;

        }

        private void ShowList()
        {

            ElementHandler elementHandler = new(_savings, _loans);

            Console.Clear();

            string actionDescription = "You want to see";

            int menuSelection = ListSelector(actionDescription);

            switch (menuSelection)
            {

                case 0:

                    Console.Clear();

                    break;

                case 1:

                    elementHandler.GetDetails(menuSelection);

                    break;

                case 2:

                    elementHandler.GetDetails(menuSelection);

                    break;

            }

        }
        
    }

}