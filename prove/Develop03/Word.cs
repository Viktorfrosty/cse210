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

        public string GetDisplayText()
        {
            
            switch(_isHidden)
            {

                case true:

                    string hiddenWord = "";

                    foreach (char letter in _text)
                    {

                        if (letter == ',')
                        {

                            hiddenWord += ",";

                        }
                        else if (letter == '.')
                        {

                            hiddenWord += "."; 

                        }
                        else
                        {

                            hiddenWord += "_"; 

                        }

                    }

                    return $"{hiddenWord} ";

                case false:

                    return $"{_text} ";

            }

        }

    }

}