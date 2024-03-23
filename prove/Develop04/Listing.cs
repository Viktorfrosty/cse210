namespace Mindfulness
{

    public class ListingActivity: Activity
    {

        private int _count;

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
            
            GetRandomPrompt();

            List<string> list = GetListFromUser();

            _count = list.Count();

        }

        private void GetRandomPrompt()
        {

            Random random = new Random();

            int randomIndex = random.Next(0,_prompts.Count());

            Console.WriteLine(_prompts[randomIndex]);

        }

        private List<string> GetListFromUser()
        {

            List<string> userList = new List<string>{};

            bool getList = true;

            while (getList == true)
            {

            }

            return userList;

        }
        
    }

}