namespace QuestSystem
{

    public class ChecklistGoal: Goal
    {

        private int _amountCompleted;

        private int _target;

        private int _bonus;

        public ChecklistGoal(string name, string description, string points, int target, int bonus): base(name, description, points)
        {
            
            _target = target;

            _bonus = bonus;

        }

        public override string GetDetailString()
        {
            //
        }

        public override string GetStringRepresentation()
        {
            //
        }

        public override void RecordEvent()
        {
            //
        }

        public override bool IsCompleted()
        {
            //
        }
        
    }

}