namespace Mindfulness
{

    public class Activity
    {
        
        protected string _name;

        protected string _description;

        protected int _duration;

        public Activity(string name, string description, int duration)
        {

            _name = name;

            _description = description;

            _duration = duration;

        }

        public void DisplayStartingMessage()
        {

            Console.Clear();

            Console.Write($"Welcome to the {_name} Activity!\n\n{_description}\n\nHow long (in seconds) would you like to be this session: ");
            


        }

        public void DisplayEndingMessage()
        {

            Console.WriteLine("Well Done.");

        }

        public void ShowSpinner(int seconds)
        {

            List<string> spinner = new List<string>()
            { "|", "/", "—", "\\"};

            int index = 0;

            DateTime startTime = DateTime.Now;

            DateTime futureTime = startTime.AddSeconds(seconds);

            Console.WriteLine("");//remove.

            while (DateTime.Now < futureTime)
            {

                Console.Write(spinner[index]);

                Thread.Sleep(1000);

                Console.Write("\b \b");

                index += 1;

                if (index >= spinner.Count())
                {

                    index = 0;

                }

            }
            
        }

        public void ShowCountDown(int seconds)
        {

            Console.WriteLine("");// remove

            for (int countdown = seconds; countdown > 0; countdown--)
            {

                Console.Write(countdown);

                Thread.Sleep(1000);

                Console.Write("\b \b");

            }

        }

    }

}