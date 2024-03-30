namespace QuestSystem
{

    public class Goal
    {

        private string _shortName;

        private string _description;

        private string _points;

        public Goal(string name, string description, string points)
        {

            _shortName = name;

            _description = description;

            _points = points;
            
        }
        
        public string GetDetailString()
        {
            return $"[ ] {_shortName} ({_description})";
        }

        public virtual string GetStringRepresentation()
        {

            return $"testGoal¦{_shortName}¦{_description}¦{_points}";

        }

        public virtual void RecordEvent()
        {
            //
        }

        public virtual bool IsCompleted()
        {

            return false;
            
        }

    }

}