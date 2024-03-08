namespace ca1050
{
    public class Entry
    {
        public string _entrydate;
        public string _promptText;
        public string _entryText;
        public void DisplayEntry()
        {
            Console.WriteLine($"Date: {_entrydate}");
        }
    }
}