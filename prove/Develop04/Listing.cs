namespace Mindfulness
{

    public class ListingActivity: Activity
    {

        private int _count;

        private List<string> _userList = new List<string>{};

        private List<string> _prompts = new List<string>
        {
            "listing test1",
            "listing test2",
            "listing test3"
        };

        public ListingActivity(string name, string description, int count): base(name, description)
        {

            //

        }
        
        public void Run()
        {
            
            //

        }

        public void GetRandomPrompt()
        {

            Random random = new Random();

            int randomIndex = random.Next(0,_prompts.Count());

            Console.WriteLine(_prompts[randomIndex]);

        }

        public List<string> GetListFromUser()
        {

            return 

        }
        
    }

}