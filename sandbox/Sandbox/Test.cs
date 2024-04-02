namespace Test
{

    public class Generation1
    {

        protected string _name;

        public Generation1()
        {

            _name = "First";

        }

        public void ShowName()
        {

            Console.WriteLine($"{_name} generation test.");

        }

        public virtual void ShowMessage()
        {

            Console.WriteLine("First generation tested successfully.");

        }

    }

}