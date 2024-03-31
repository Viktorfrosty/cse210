namespace QuestSystem
{

    public class Goal
    {

        protected string _shortName;

        protected string _description;

        protected int _points;

        public Goal(string name, string description, int points)
        {

            _shortName = name;

            _description = description;

            _points = points;
            
        }
        
        public virtual string GetDetailString()
        {

            return $"{_shortName} ({_description})";

        }

        public virtual string GetStringRepresentation()
        {

            return $"goal¦{_shortName}¦{_description}¦{_points}";

        }

        public virtual int RecordEvent()
        {

            return _points;

        }

        public virtual bool IsCompleted()
        {

            return false;
            
        }

        public string GetName()
        {

            return _shortName;

        }

    }

}