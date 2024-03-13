namespace ca1050
{

    public class Fraction
    {

        private int _top;
        private int _bottom;

        public Fraction()
        {
            _top = 1;
            _bottom =1;
            //Console.WriteLine($"{_top}/{_bottom}");

        }
        public Fraction(int wholeNumber)
        {
            _top = wholeNumber;
            _bottom =1;
            //Console.WriteLine($"{_top}/{_bottom}");
        }
        public Fraction(int top, int bottom)
        {
            _top = top;
            _bottom = bottom;
            //Console.WriteLine($"{_top}/{_bottom}");
        }

        public void GetTop()
        {
            Console.WriteLine(_top);
        }

        public int SetTop(int top)
        {
            Console.Write("top value: ");
            top = int.Parse(Console.ReadLine());
            return top;
        }

        public void GetBottom()
        {
            Console.WriteLine(_bottom);
        }

        public int SetBottom(int bottom)
        {
            Console.Write("Bottom value: ");
            bottom = int.Parse(Console.ReadLine());
            return bottom;
        }

        public string GetFractionString()
        {
            string fraction = $"{_top}/{_bottom}";
            return fraction;
        }
        public double GetDecimalValue()
        {
            return (double) _top / _bottom;
        }

    }

}