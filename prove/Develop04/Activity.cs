namespace Mindfulness
{

    public class Activity
    {
        
        protected string _name;

        protected string _description;

        protected int _duration;

        public Activity(string name, string description)
        {

            _name = name;

            _description = description;

        }

        public void DisplayStartingMessage()
        {

            Console.Clear();

            Console.Write($"Welcome to the {_name} Activity!\n\n{_description}\n\nHow long (in seconds) would you like to be this session: ");

            _duration = int.Parse(Console.ReadLine());

            Console.Clear();
            
            Console.Write("Get ready.");

            ShowSpinner(5);

            Console.Clear();

        }

        public void DisplayEndingMessage()
        {

            Console.Clear();

            Console.WriteLine($"Well Done!\nYou completed {_duration} seconds of {_name} Activity.\n");

        }

        public void ShowSpinner(int seconds)
        {

            List<string> spinner = new List<string>()
            { "|", "/", "—", "\\"};

            int index = 0;

            DateTime startTime = DateTime.Now;

            DateTime futureTime = startTime.AddSeconds(seconds);

            while (DateTime.Now < futureTime)
            {

                Console.Write(spinner[index]);

                Thread.Sleep(500);

                Console.Write("\b \b");

                index++;

                if (index >= spinner.Count())
                {

                    index = 0;

                }

            }
            
        }

        public void ShowCountDown(int seconds)
        {

            for (int countdown = seconds; countdown > 0; countdown--)
            {

                Console.Write(countdown);

                Thread.Sleep(1000);

                if (countdown.ToString().Length == 1)
                {

                    Console.Write("\b \b");
                
                }

                else if (countdown.ToString().Length == 2)
                {

                    Console.Write("\b\b  \b\b");
                
                }

            }

        }

    }

}