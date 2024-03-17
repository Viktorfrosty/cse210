namespace Assingment
{

    public class Scripture
    {
        
        private int _hiddenWords = 0;

        private Reference _reference;

        private List<Word> _words = new List<Word>();

        public Scripture(Reference reference,string text)
        {
            _reference = reference;

            string[] processedText = text.Split(" ");
            
            foreach (string wordElement in processedText)
            {

                _words.Add(new Word(wordElement));

            }
            
        }

        public void HideRandomWords(int NumberToHide)
        {

            Random randomValue = new Random();

            int totalWords = _words.Count();

            int wordsToHide = NumberToHide;

            while (wordsToHide > 0)
            {

                if (_hiddenWords != totalWords)
                {

                    int randomIndex = randomValue.Next(0, totalWords);

                    Word selectedWord = _words[randomIndex];

                    if (selectedWord.IsHidden() == false)
                    {

                        selectedWord.Hide();

                        wordsToHide -= 1;

                        _hiddenWords += 1;

                    }

                }
                else if (_hiddenWords == totalWords)
                {

                    wordsToHide = 0;

                }

            }

        }

        public void ShowAllWords()
        {

            foreach (Word wordElement in _words)
            {

                wordElement.Show();
                _hiddenWords = 0;
            
            }

        }

        public void DisplayText()
        {

            Console.WriteLine($"{_reference.GetDisplayText()}");

            foreach (Word wordElement in _words)
            {

                Console.Write(wordElement.GetDisplayText());

            }

        }

        public bool IsCompletlyHidden()
        {

            int statusSwitch = 0;

            bool status = false;

            foreach (Word wordElement in _words)
            {

                if (wordElement.IsHidden() == false)
                {

                    statusSwitch += 1;

                }

            }

            if (statusSwitch != 0)
            {

                status = false;

            }

            else if (statusSwitch == 0)
            {

                status = true;

            }

            return status;

        }
    
    }

}