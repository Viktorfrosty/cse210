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

            return $"{_shortName} ({_description}) -- objective: {_target} times / currently completed: {_amountCompleted} times.";

        }

        public override string GetStringRepresentation()
        {
            return $"checklist¦{_shortName}¦{_description}¦{_points}¦{_target}¦{_bonus}¦{_amountCompleted}";
        }

        public override int RecordEvent()
        {

            _amountCompleted++;

            if (_target == _amountCompleted)
            {

                Console.WriteLine($"\nCongratulations! you completed your objective.\nYou earned {_points} points and {_bonus} points.");

                return _points + _bonus;
 
            }
            else
            {

                Console.WriteLine($"\nCongratulations! You earned {_points} points.");
                
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