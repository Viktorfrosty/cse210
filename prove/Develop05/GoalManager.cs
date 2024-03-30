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

                            Console.WriteLine("Invalid option: selected option is not in the list.\nSelect a valid option from the list.\n");

                            break;

                        case 0:

                            Console.WriteLine("Goodbye.");

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

                    Console.Clear();

                    Console.WriteLine("Invalid input: Selected option is not a number.\nSelect a valid option from the list.\n");

                }
            }
            
        }

        private void DisplayPlayerInfo()
        {
            
            Console.WriteLine($"Your score is: {_score}\n");

        }

        private void ListGoalNames()
        {
            //
        }

        private void ListGoalDetails()
        {

            if (_goals.Count() == 0)
            {

                Console.WriteLine("No goals listed");

            }
            else
            {

                Console.WriteLine("Goals: ");
                
                foreach (Goal goal in _goals)
                {
                    Console.WriteLine($"  {goal.GetDetailString()}");
                }

            }

            Console.WriteLine("");

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

                            Console.WriteLine("Invalid option: selected option is not in the list.\nSelect a valid option from the list.");

                            break;
                        
                        case 0:

                            createGoal = false;

                            break;

                        case 1:

                            Console.WriteLine("CreateGoal Test 1\n"); // remove!

                            createGoal = false;

                            break;

                        case 2:

                            Console.WriteLine("CreateGoal Test 2\n"); // remove!

                            createGoal = false;

                            break;

                        case 3:

                            Console.WriteLine("CreateGoal Test 3\n"); // remove!

                            createGoal = false;

                            break;

                        case 4: // remove!

                            Console.WriteLine("CreateGoal Test 4\n"); // remove!

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

                    Console.Clear();

                    Console.WriteLine("Invalid input: Selected option is not a number.\nSelect a valid option from the list.");

                }

            }

        }

        private void EraseGoal() // Exceding the requirements.
        {
            //
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