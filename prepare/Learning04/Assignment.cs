namespace Assignments
{

    public class Assignment
    {

        protected string _studentName;

        protected string _topic;

        public void GetSummary()
        {

            Console.WriteLine($"{_studentName} {_topic}");

        }

    }

}