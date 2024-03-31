namespace QuestSystem
{

    public class SimpleGoal: Goal
    {

        private bool _isComplete;

        public SimpleGoal(string name, string description, int points, bool isCompleted): base(name, description, points)
        {

            _isComplete = isCompleted;

        }

        public override string GetStringRepresentation()
        {

            return $"simple¦{_shortName}¦{_description}¦{_points}¦{_isComplete}";

        }

        public override int RecordEvent()
        {

            _isComplete = true;

            return _points;

        }

        public override bool IsCompleted()
        {
            return _isComplete;
        }
        
    }

}