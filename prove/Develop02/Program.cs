/* Exceeding requirements: 
- Extra info save on the entry as _entryCode (Entry number).
- Added try-catch statement to handle a faulty selection at the beggining.
- handled the way the program read the CSV file.
- Added handlers for "entries not found" and "file not found"
- A total of seven random prompts are loaded in the generator.
*/

using ca1050;

class Program
{
    static void Main(string[] args)
    {

        Journal myJournal = new Journal();

        bool init = true;

        Console.WriteLine("Welcome to the Personal Journal Assistant V0.1");

        while (init == true)
        {

            // challenge element added.

            try
            {
            
                Console.Write("\nTo proceed select the number one of the following options:\n1) New entry.\n2) Display entries.\n3) Save to a file.\n4) Load from a file\n5) exit the program.\nYour Selection: ");

                string userSelection = Console.ReadLine();

                switch (int.Parse(userSelection))
                {

                    case 1:

                        Entry entryData = new Entry();

                        entryData._entryCode = myJournal._entries.Count + 1;

                        DateTime currentTime = DateTime.Now;

                        entryData._entryDate = currentTime.ToShortDateString();

                        PromptGenerator prompt = new PromptGenerator();

                        string selectedPrompt = prompt.GetRandomPrompt();

                        entryData._promptText = selectedPrompt;

                        Console.WriteLine($"\nDate: {entryData._entryDate}\n{entryData._promptText}\n");

                        entryData._entryText = Console.ReadLine();

                        myJournal.AddEntry(entryData);

                        Console.WriteLine($"\nEntry saved as entry number: {entryData._entryCode}");
                        
                        break;

                    case 2:

                        myJournal.DisplayJournal();
                        
                        break;

                    case 3:

                        myJournal.SaveToFile();
                        
                        break;

                    case 4:

                        myJournal.LoadFromFile();
                        
                        break;
                    
                    case 5:

                        Console.WriteLine("Goodbye.");

                        init = false;
                        
                        break;
                    
                    default:

                        Console.WriteLine($"\nInvalid selection: Please choose a valid option.");
                        
                        break;

                }

            }

            catch (Exception inputError)
            {

                Console.WriteLine($"\nInvalid selection: {inputError.Message}");

            }

        }

    }

}