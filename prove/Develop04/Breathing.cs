namespace Mindfulness
{

    public class BreathingActivity: Activity
    {
        
        public BreathingActivity(string name, string description): base(name, description)
        {

            //

        }

        public void Run()
        {
            
            DateTime startTime = DateTime.Now;

            DateTime futureTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < futureTime)
            {

                Console.Write("breathe in: ");

                ShowCountDown(5);

                Console.WriteLine("");

                Console.Write("Breathe out: ");

                ShowCountDown(10);

                Console.WriteLine("");

            }

        }
        
    }

}