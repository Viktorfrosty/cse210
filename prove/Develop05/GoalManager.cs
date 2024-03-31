using System.IO;

namespace QuestSystem
{
    
    public class GoalManager
    {

        List<Goal> _goals = new List<Goal>();

        private int _score;

        public GoalManager()
        {

            _score = 0;
            
        }

        public void Start()
        {
            bool running = true;

            Console.WriteLine("\nEternalQuest.");

            while(running == true)
            {

                try // Exceding the requirements.
                {

                    DisplayPlayerInfo();

                    Console.Write($"Menu Options:\n  1. List all the goals.\n  2. Create a new goal.\n  3. Erase a goal.\n  4. Save the goals into a txt file.\n  5. Load goals from a txt file.\n  6. Record an event.\n  0. Exit the program.\n\nSelection: ");

                    int userSelection = int.Parse(Console.ReadLine());

                    switch (userSelection)
                    {
                        
                        default:

                            Console.WriteLine("\nInvalid option: selected option is not in the list.\nSelect a valid option from the list.");

                            break;

                        case 0:

                            Console.WriteLine("\nGoodbye.\n");

                            running = false;

                            break;

                        case 1:

                            ListGoalDetails();

                            break;

                        case 2:

                            CreateGoal();

                            break;

                        case 3:

                            EraseGoal();

                            break;

                        case 4:

                            SaveGoals();

                            break;

                        case 5:

                            LoadGoals();

                            break;

                        case 6:

                            RecordEvent();

                            break;

                    }

                }
                catch (Exception) // Exceding the requirements.
                {

                    Console.WriteLine("\nInvalid input: Selected option is not a number.\nSelect a valid option from the list.");

                }

            }
            
        }

        private void DisplayPlayerInfo()
        {
            
            Console.WriteLine($"\nYour score is: {_score}\n");

        }

        private void ListGoalNames()
        {

            int listNumber = 0;

            if (_goals.Count() == 0)
            {

                Console.WriteLine("\nNo goals listed.");

            }
            else
            {

                Console.WriteLine("\nGoals: ");
                
                foreach (Goal goal in _goals)
                {
                    
                    listNumber++;

                    Console.WriteLine($"  {listNumber}. {goal.GetName()}");

                }

            }

        }

        private void ListGoalDetails()
        {

            int listNumber = 0;

            if (_goals.Count() == 0)
            {

                Console.WriteLine("\nNo goals listed.");

            }
            else
            {

                Console.WriteLine("\nGoals: ");
                
                foreach (Goal goal in _goals)
                {

                    listNumber++;

                    string mark = "[ ]";

                    if (goal.IsCompleted() != false)
                    {
        
                        mark = "[x]";

                    }

                    Console.WriteLine($"  {listNumber}. {mark} {goal.GetDetailString()}");

                }

            }

        }

        private void CreateGoal()
        {

            bool running = true;

            while (running == true)
            {

                try // Exceding the requirements.
                {

                    string name;

                    string description;

                    int points;

                    int number;

                    int target;

                    int bonus;
                
                    Console.Write("\nThe type of goals are:\n  1. Simple.\n  2. Eternal.\n  3. Checklist.\n\nWhich type of goal are you going to create? (Insert 0 to return to the main menu.)\nSelection: ");
                    
                    int userSelection = int.Parse(Console.ReadLine());

                    switch (userSelection)
                    {

                        default:

                            Console.WriteLine("\nInvalid option: selected option is not in the list.\nSelect a valid option from the list.");

                            break;
                        
                        case 0:

                            running = false;

                            break;

                        case 1:

                            Console.WriteLine("\nSimple Goal.");

                            Console.Write("\nName of the goal:");
                            
                            name = Console.ReadLine();

                            Console.Write("\nDescription of the goal:");
                            
                            description = Console.ReadLine();

                            while (true)
                            {

                            Console.Write("\nPoints value of the goal:");

                                bool result = int.TryParse(Console.ReadLine(), out number); // Exceding the requirements.

                                if (result == true && number >= 1)
                                {

                                    points = number;
                                    
                                    break;

                                }
                                else
                                {

                                    Console.WriteLine("\nInvalid input: Insert a positive number.");

                                }
                                
                            }

                            SimpleGoal simpleGoal = new SimpleGoal(name, description, points, false);

                            _goals.Add(simpleGoal);

                            running = false;

                            Console.WriteLine($"\nThe {name} goal has been created and added to the list successfully.");

                            running = false;

                            break;

                        case 2:


                            Console.WriteLine("\nEternal Goal.");

                            Console.Write("\nName of the goal:");
                            
                            name = Console.ReadLine();

                            Console.Write("\nDescription of the goal:");
                            
                            description = Console.ReadLine();

                            while (true)
                            {

                            Console.Write("\nPoints value of the goal:");

                                bool result = int.TryParse(Console.ReadLine(), out number); // Exceding the requirements.

                                if (result == true && number >= 1)
                                {

                                    points = number;
                                    
                                    break;

                                }
                                else
                                {

                                    Console.WriteLine("\nInvalid input: Insert a positive number.");

                                }
                                
                            }

                            EternalGoal eternalGoal = new EternalGoal(name, description, points);

                            _goals.Add(eternalGoal);

                            running = false;

                            Console.WriteLine($"\nThe {name} goal has been created and added to the list successfully.");

                            running = false;

                            break;

                        case 3:

                            Console.WriteLine("\nChecklist Goal.");

                            Console.Write("\nName of the goal:");
                            
                            name = Console.ReadLine();

                            Console.Write("\nDescription of the goal:");
                            
                            description = Console.ReadLine();


                            while (true)
                            {

                            Console.Write("\nPoints value of the goal:");

                                bool result = int.TryParse(Console.ReadLine(), out number); // Exceding the requirements.

                                if (result == true && number >= 1)
                                {

                                    points = number;
                                    
                                    break;

                                }
                                else
                                {

                                    Console.WriteLine("\nInvalid input: Insert a positive number.");

                                }
                                
                            }

                            while (true)
                            {

                                Console.Write("\nHow many times this goal needs to be acomplished to earn a bonus:");

                                bool result = int.TryParse(Console.ReadLine(), out number); // Exceding the requirements.

                                if (result == true && number >= 1)
                                {

                                    target = number;
                                    
                                    break;

                                }
                                else
                                {

                                    Console.WriteLine("\nInvalid input: Insert a positive number.");

                                }
                                
                            }
                            
                            while (true)
                            {

                                Console.Write("\nBonus value of the goal:");

                                bool result = int.TryParse(Console.ReadLine(), out number); // Exceding the requirements.

                                if (result == true && number >= 1)
                                {

                                    bonus = number;
                                    
                                    break;

                                }
                                else
                                {

                                    Console.WriteLine("\nInvalid input: Insert a positive number.");
                                    
                                }
                                
                            }

                            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus, 0);

                            _goals.Add(checklistGoal);

                            running = false;

                            Console.WriteLine($"\nThe {name} goal has been created and added to the list successfully.");

                            break;

                    }

                }
                catch (Exception) // Exceding the requirements.
                {

                    Console.WriteLine("\nInvalid input: Selected option is not a number.\nSelect a valid option from the list.");

                }

            }

        }

        private void EraseGoal() // Exceding the requirements.
        {

            ListGoalDetails();

            if (_goals.Count()>0)
            {

                while (true)
                {
                    
                    try // Exceding the requirements.
                    {

                        Console.Write("\nSelect the goal you are going to erase from the list (Select 0 to return to the main menu)\nSelection: ");

                        int userSelection = int.Parse(Console.ReadLine()) - 1;

                        if (userSelection == -1)
                        {

                            break;

                        }
                        else if (_goals.Count() >= userSelection && _goals[userSelection] != null)
                        {

                            _goals.RemoveAt(userSelection);

                            Console.WriteLine("\nGoal removed from the list.");

                            break;

                        }
                        else
                        {

                            Console.WriteLine("\nInvalid input: Selected option is not a number.\nSelect a valid option from the list.");

                        }
                    }
                    catch (Exception) // Exceding the requirements.
                    {
                        
                        Console.WriteLine("\nInvalid input: Selected option is not a number.\nSelect a valid option from the list.");
                        
                    }

                }

            }

        }

        private void RecordEvent()
        {

            ListGoalNames();

            if (_goals.Count()>0)
            {

                while (true)
                {
                    try // Exceding the requirements.
                    {

                        Console.Write("\nSelect the goal you acomplished (Select 0 to return to the main menu)\nSelection: ");

                        int userSelection = int.Parse(Console.ReadLine()) - 1;

                        if (userSelection == -1)
                        {

                            break;

                        }
                        else if (_goals.Count() >= userSelection && _goals[userSelection] != null)
                        {

                            Goal selectedGoal = _goals[userSelection];

                            _score += selectedGoal.RecordEvent();

                            Console.WriteLine("\nGoal status updated.");

                            break;

                        }
                        else
                        {

                            Console.WriteLine("\nInvalid input: Selected option is not a number.\nSelect a valid option from the list.");

                        }
                    }
                    catch (Exception) // Exceding the requirements.
                    {
                        
                        Console.WriteLine("\nInvalid input: Selected option is not a number.\nSelect a valid option from the list.");
                        
                    }

                }

            }

        }

        private void SaveGoals()
        {

            ListGoalDetails();

            if (_goals.Count()>0)
            {

                Console.Write("\nSave the list on a txt file.\n(Do not add the .txt at the end of the file name)\nFile name: ");

                string fileName = Console.ReadLine()+".txt";

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {

                    outputFile.WriteLine(_score);

                    foreach (Goal goal in _goals)
                    {

                        outputFile.WriteLine(goal.GetStringRepresentation());

                    }
                    
                }

                Console.WriteLine("\nFile saved.");

            }

        }

        private void LoadGoals()
        {

            bool running = true;

            while (running == true)
            {

                try // Exceding the requirements.
                {

                    Console.Write("\nLoad the goal list from a txt file.\nWarning this process will erase the current goal list. Do you want to proceed?\n  1. Yes (Load file)\n  0. No (Return to main menu)\nSelection: ");

                    int userSelection = int.Parse(Console.ReadLine());

                    if (userSelection == 1)
                    {

                        Console.Write("\nNote: Do not add the .txt at the end of the file name.\nFile name: ");

                        string fileName = Console.ReadLine()+".txt";

                        if (File.Exists(fileName))
                        {

                            _score = 0;

                            _goals.Clear();

                            using (StreamReader reader = new StreamReader(fileName))
                            {
                                
                                string firstLine = reader.ReadLine();

                                _score = int.Parse(firstLine);

                                string line;

                                while ((line = reader.ReadLine()) != null)
                                {

                                    string[] parts = line.Split("¦");

                                    string goalType = parts[0];

                                    string shortName = parts[1];

                                    string description = parts[2];

                                    int points = int.Parse(parts[3]);

                                    switch (goalType.ToLower())
                                    {
                                        
                                        case "simple":

                                            bool isCompleted = false;

                                            string isCompletedString = parts[4];
                                        
                                            if (isCompletedString.ToLower() == "true")
                                            {

                                                isCompleted = true;

                                            }

                                            SimpleGoal simpleGoal = new SimpleGoal(shortName, description, points, isCompleted);

                                            _goals.Add(simpleGoal);

                                            break;
                                                                                
                                        case "eternal":

                                            EternalGoal eternalGoal = new EternalGoal(shortName, description, points);

                                            _goals.Add(eternalGoal);

                                            break;

                                        case "checklist":

                                            int target = int.Parse(parts[4]);

                                            int bonus = int.Parse(parts[5]);

                                            int amountCompleted = int.Parse(parts[6]);

                                            ChecklistGoal checklistGoal = new ChecklistGoal(shortName, description, points, target, bonus, amountCompleted);

                                            _goals.Add(checklistGoal);

                                            break;

                                    }

                                }

                            }

                            Console.WriteLine("\nGoal list loaded.");

                            running = false;
                            
                        }
                        else
                        {

                            Console.WriteLine($"\nFile {fileName} not found.");

                        }

                    }
                    else if (userSelection == 0)
                    {

                        running = false;

                    }
                    else
                    {

                        Console.WriteLine("\nInvalid input: Selected option is not a number.\nSelect a valid option from the list.");

                    }

                }
                catch (Exception) // Exceding the requirements.
                {

                    Console.WriteLine("\nInvalid input: Selected option is not a number.\nSelect a valid option from the list.");

                }

            }

        }

    }

}