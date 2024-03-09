using System.IO;
using ca1050;

class Program
{
    static void Main(string[] args)
    {

        Journal myJournal = new Journal();

        bool init = true;

        Console.WriteLine("Welcome to the Personal Journal Assitant V0.1\n");

        while (init == true)
        {
            
            Console.Write("To proceed select the number one of the following options:\n1) New entry.\n2) Display entries.\n3) Save to a file.\n4) Load from a file\n5) exit the program.\nYour Selection: ");
            string userSelection = Console.ReadLine();

            switch (int.Parse(userSelection))
            {
                case 1:

                    Entry entryData = new Entry();

                    DateTime currentTime = DateTime.Now;
                    entryData._entryDate = currentTime.ToShortDateString();

                    PromptGenerator prompt = new PromptGenerator();
                    string selectedPrompt = prompt.GetRandomPrompt();
                    entryData._promptText = selectedPrompt;

                    Console.WriteLine($"Date:{currentTime}\n{selectedPrompt}");

                    entryData._entryText = Console.ReadLine();

                    myJournal._entries.Add(entryData);

                    break;

                case 2:

                    myJournal.DisplayJournal();
                    break;

                case 3:

                    break;

                case 4:

                    break;
                
                case 5:

                    Console.WriteLine("Goodbye");

                    init = false;

                    break;
            }
        }
    }
}