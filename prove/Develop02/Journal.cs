namespace ca1050
{
    public class Journal
    {
        public List<Entry> _Entries = new List<Entry>();
        public void AddEntry(Entry newEntry)
        {
            _Entries.Add(newEntry);
        }
        public void DisplayJournal()
        {
            foreach (Entry entry in _Entries)
            {
                entry.DisplayEntry();
            }
        }
    }
}