namespace Assingment
{

    public class Scripture
    {
        
        private Reference _reference = new Reference("test",1,1);

        private List<Word> _words = new List<Word>();

        public Scripture(Reference reference, string text)
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

            //

        }

        public string DisplayText()
        {

            Console.Write($"{_reference} :");
            foreach (Word wordElement in _words)
            {
                if (wordElement.IsHidden())
                {

                    Console.Write(wordElement.DisplayText());

                }
            }

        }

        public bool IsCompletlyHidden()
        {
            
            //

        }
    
    }

}