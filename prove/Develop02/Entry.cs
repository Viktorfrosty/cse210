namespace ca1050
{
    public class Entry
    {
        
        // Challenge extra info save on the entry, entry number as _entryCode.
        public int _entryCode;

        public string _entryDate;

        public string _promptText;

        public string _entryText;

        public void DisplayEntry()
        {

            Console.WriteLine($"\nEntry number: {_entryCode}\nDate: {_entryDate}\nPrompt: {_promptText}\n{_entryText}");

        }

    }

}