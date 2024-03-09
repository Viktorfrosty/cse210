using System.IO;

namespace ca1050
{
    public class Journal
    {

        public List<Entry> _entries = new List<Entry>();

        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }

        public void DisplayJournal()
        {
            foreach (Entry entry in _entries)
            {
                entry.DisplayEntry();
            }
        }

        public void SaveToFile()
        {

        }

        public void LoadFromFile()
        {

        }
    }
}