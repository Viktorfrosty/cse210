namespace QuestSystem
{
    
    public class GoalManager
    {

        List<Goal> _goals = new List<Goal>();

        private int _score;

        public GoalManager()
        {
            //
        }

        public void Start()
        {
            private bool running = true;

            Console.WriteLine("EternalQuest.\n")

            while (running == true)
            {
                DisplayPlayerInfo();

                Console.WriteLine("Menu Options:\n1. Create new goal.\n2. Erase a goal.\n3. Save goals.\n4. Load goals.\n5. Record an event.\n0. Exit the program.\nSelection: ")

                int userSelection = int.Parse(Console.ReadLine());

                try
                {

                    switch (userSelection)
                    {
                        
                        default:

                            Console.WriteLine("Invalid input: Select a valid option.\n")

                            break;

                        case 0:

                            Console.WriteLine("Goodbye.")

                            running = false;

                            break;

                    }

                }
                catch (System.Exception)
                {
                    
                    throw;
                }
            }
            
        }

        public void DisplayPlayerInfo()
        {
            
            Console.WriteLine($"Your score is: {_score}")

        }

        public void ListGoalNames()
        {
            //
        }

        public void ListGoalDetails()
        {
            //
        }

        public void CreateGoal()
        {
            //
        }

        public void RecordEvent()
        {
            //
        }

        public void SaveGoals()
        {
            //
        }

        public void LoadGoals()
        {
            //
        }

    }

}