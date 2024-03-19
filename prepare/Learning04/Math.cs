namespace Assignments
{

    public class MathAssingment: Assignment
    {

        private string _textBookSection;

        private string _problems;

        public MathAssingment(string studentName, string topic, string textBookSection, string Problems): base(studentName, topic)
        {

            _textBookSection = textBookSection;

            _problems = Problems;

        }

        public string GetHomework()
        {

            return $"Text Book Section: {_textBookSection}\nProblems: {_problems}";

        }

    }

}