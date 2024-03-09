using System.IO;
using ca1050;

class Program
{
    static void Main(string[] args)
    {

        bool init = true;

        Console.WriteLine("Welcome to the Personal Journal Assitant V0.1\n");

        while (init == true)
        {
            
            Console.Write("To proceed select the number one of the following options:\n1) New entry.\n2) Display entries.\n3) Save to a file.\n4) Load from a file\n5) exit the program.\nYour Selection: ");
            string userSelection = Console.ReadLine();

            switch (int.Parse(userSelection))
            {
                case 1:
                    PromptGenerator prompt = new PromptGenerator();
                    prompt.GetRandomPrompt();
                    Entry entry = new Entry();
                    entry._promptText = prompt.ToString();

                    DateTime theCurrentTime = DateTime.Now;
                    entry._entryDate = theCurrentTime.ToShortDateString();

                    entry._entryText = Console.ReadLine();

                    entry.AddEntry();

                    break;
                case 2:
                    Journal myJournal = new Journal();
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