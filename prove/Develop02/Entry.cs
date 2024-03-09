namespace ca1050
{
    public class Entry
    {

        public string _entryDate;

        public string _promptText;

        public string _entryText;

        public void DisplayEntry()
        {
            Console.WriteLine($"Date: {_entryDate}\nPrompt: {_promptText}\n{_entryText}");
        }
    }
}