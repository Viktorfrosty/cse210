namespace QuestSystem
{

    public class ChecklistGoal: Goal
    {

        private int _amountCompleted;

        private int _target;

        private int _bonus;

        public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted): base(name, description, points)
        {
            
            _target = target;

            _bonus = bonus;

            _amountCompleted = amountCompleted;

        }

        public override string GetDetailString()
        {

            return $"{_shortName} ({_description}) -- currently completed: {_amountCompleted}";

        }

        public override string GetStringRepresentation()
        {
            return $"ChecklistGoal¦{_shortName}¦{_description}¦{_points}¦{_target}¦{_bonus}¦{_amountCompleted}";
        }

        public override int RecordEvent()
        {

            _amountCompleted++;

            if (_target == _amountCompleted)
            {

                return _points + _bonus;
 
            }
            else
            {

                return _points;

            }
            
        }

        public override bool IsCompleted()
        {

            if (_target == _amountCompleted)
            {

                return true;

            }
            else
            {

                return false;

            }

        }
       
    }

}