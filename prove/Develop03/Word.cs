namespace Assingment
{

    public class Word
    {

        private string _text;
        private bool _isHidden;

        public Word(string text)
        {

            _text = text;
            _isHidden = false;

        }

        public void Hide()
        {

            _isHidden = true;

        }

        public void Show()
        {

            // looks like I am going to omit this...

        }

        public bool IsHidden()
        {

            return _isHidden;

        }

        public string Display()
        {

            return _text;

        }

    }

}