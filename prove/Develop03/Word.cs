namespace Assingment
{

    public class Word
    {

        private string _text;

        private bool _isHidden;

        public Word(string text)
        {

            _text = text;

        }

        public void Hide()
        {

            _isHidden = true;

        }

        public void Show()
        {

            _isHidden = false;

        }

        public bool IsHidden()
        {
            
            return _isHidden;

        }

        public string DisplayText()
        {
            switch (_isHidden)
            {
            case true:

                return _text;
            case false:
                return _text;
            }

        }

    }

}