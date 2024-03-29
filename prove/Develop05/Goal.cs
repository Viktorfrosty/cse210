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
            //
        }

        public virtual string GetStringRepresentation()
        {
            //
        }

        public virtual void RecordEvent()
        {
            //
        }

        public virtual bool IsCompleted()
        {
            //
        }

    }

}