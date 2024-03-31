namespace QuestSystem
{

    public class EternalGoal: Goal
    {

        public EternalGoal(string name, string description, int points): base(name, description, points)
        {
            // No change
        }

        public override string GetStringRepresentation()
        {

            return $"eternal¦{_shortName}¦{_description}¦{_points}";

        }

        public override int RecordEvent()
        {

            return _points;

        }

        public override bool IsCompleted()
        {
            return false;
        }
        
    }

}