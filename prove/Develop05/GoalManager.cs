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

            Console.WriteLine("EternalQuest.\n");

            while(running == true)
            {

                try // Exceding the requirements.
                {

                    DisplayPlayerInfo();

                    Console.Write($"Menu Options:\n  1. List all goals.\n  2. Create new goal.\n  3. Erase a goal.\n  4. Save goals.\n  5. Load goals.\n  6. Record an event.\n  0. Exit the program.\n\nSelection: ");

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
            //
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

                    Console.WriteLine($"  {listNumber}. {goal.GetDetailString()}");

                }

            }

        }

        private void CreateGoal()
        {

            bool createGoal = true;

            while (createGoal == true)
            {

                try // Exceding the requirements.
                {
                
                    Console.Write("\nThe type of goals are:\n  1. Simple.\n  2. Eternal.\n  3. Checklist.\n\nWhich type of goal are you going to create? (Insert 0 to return to the main menu.)\nSelection: ");
                    
                    int userSelection = int.Parse(Console.ReadLine());

                    switch (userSelection)
                    {

                        default:

                            Console.WriteLine("\nInvalid option: selected option is not in the list.\nSelect a valid option from the list.");

                            break;
                        
                        case 0:

                            createGoal = false;

                            break;

                        case 1:

                            Console.WriteLine("\nCreateGoal Test .1"); // remove!

                            createGoal = false;

                            break;

                        case 2:

                            Console.WriteLine("\nCreateGoal Test 2."); // remove!

                            createGoal = false;

                            break;

                        case 3:

                            Console.WriteLine("\nCreateGoal Test 3."); // remove!

                            createGoal = false;

                            break;

                        case 4: // remove!

                            Console.WriteLine("\nCreateGoal Test 4."); // remove!

                            Console.Write("Name of the goal:");
                            
                            string name = Console.ReadLine();

                            Console.Write("Description of the goal:");
                            
                            string description = Console.ReadLine();

                            Console.Write("Points value of the goal:");
                            
                            string points = Console.ReadLine();

                            Goal goal = new Goal(name, description, points);

                            _goals.Add(goal);

                            createGoal = false;

                            Console.WriteLine($"\nThe {name} goal has been created and added to the list successfully.");

                            break;

                    }

                }
                catch (Exception) // Exceding the requirements.
                {

                    Console.WriteLine("\nInvalid input: Selected option is not a number.\nSelect a valid option from the list.*");

                }

            }

        }

        private void EraseGoal() // Exceding the requirements.
        {

            while (true)
            {
                try
                {

                    ListGoalDetails();

                    Console.Write("\nSelect the goal you are going to erase from the list (Select 0 to return to the main menu)\nSelection: ");

                    int userSelection = int.Parse(Console.ReadLine()) - 1;

                    if (userSelection == -1)
                    {

                        break;

                    }
                    else if (_goals.Count() > userSelection && _goals[userSelection] != null)
                    {

                        _goals.RemoveAt(userSelection);

                        Console.WriteLine("\nGoal removed from the list.");

                        break;

                    }
                    else
                    {

                        Console.WriteLine("\nInvalid input: Selected option is not a number.\nSelect a valid option from the list.**");

                    }
                }
                catch (Exception)
                {
                    
                    Console.WriteLine("\nInvalid input: Selected option is not a number.\nSelect a valid option from the list.**");
                    
                }

            }

        }

        private void RecordEvent()
        {
            //
        }

        private void SaveGoals()
        {
            //
        }

        private void LoadGoals()
        {
            //
        }

    }

}