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

            if (_entries.Count() >= 1 )
            {

                foreach (Entry entry in _entries)
                {

                    entry.DisplayEntry();

                }

            }
            else
            {

                Console.WriteLine("\nNo entries found.");

            }
        }

        public void SaveToFile()
        {
            string fileName = "myJournal.csv";

            using (StreamWriter outputFile = new StreamWriter(fileName))
            {

                foreach (Entry entry in _entries)
                {

                    outputFile.WriteLine($"{entry._entryCode}<|>{entry._entryDate}<|>{entry._promptText}<|>{entry._entryText}");

                }

            }
            
            Console.WriteLine($"\nJournal saved as {fileName}.");

        }

        public void LoadFromFile()
        {
            
            string fileName = "myJournal.csv";

            if (File.Exists(fileName))
            {

                _entries.Clear();

                string[] lines = System.IO.File.ReadAllLines(fileName);

                foreach (string line in lines)
                {

                    Entry newEntry = new Entry();

                    string[] parts = line.Split("<|>");

                    newEntry._entryCode = int.Parse(parts[0]);

                    newEntry._entryDate = parts[1];

                    newEntry._promptText = parts[2];

                    newEntry._entryText = parts[3];

                    _entries.Add(newEntry);

                }

                Console.WriteLine($"\nJournal loaded from {fileName}.");

            }

            else
            {

                Console.WriteLine("\nNo journal file found.");

            }

        }
        
    }

}