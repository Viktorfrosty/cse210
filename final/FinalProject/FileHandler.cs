using System.IO;

namespace Inversions
{

    public class FileHandler: WalletTracker
    {

        public FileHandler()
        {

            //

        }

        public void SaveRegistry()
        {

            Console.Write("\nSave the registry on a CSV file.\n(Do not add the .CSV at the end of the file name.\nFile name: ");

            string fileName = Console.ReadLine()+".csv";

            if (_savings.Count > 0)
            {

                using (StreamWriter outputFile = new(fileName))
                {

                    foreach (Saving record in _savings)
                    {

                        outputFile.WriteLine(record.GetStringElement());

                    }
                    
                }

            }
            
            else if (_loans.Count > 0)
            {

                using (StreamWriter outputFile = new(fileName))
                {

                    foreach (Loan record in _loans)
                    {

                        outputFile.WriteLine(record.GetStringElement());

                    }
                    
                }

            }

            Console.Clear();

            Console.WriteLine("File saved.\n");

        }

        public void GetRegistry()// W.I.P.
        {
            
            Console.Write("\nLoad the registry from a CSV file.\n(Do not add the .CSV at the end of the file name.\nFile name: ");

            string fileName = Console.ReadLine()+".csv";

            if (File.Exists(fileName))
            {

                using (StreamReader reader = new(fileName))
                {

                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {

                        try
                        {
                            
                            string[] parts = line.Split("‖");

                            string element = parts[0];

                            string startingDate = parts[1];

                            int amount = int.Parse(parts[2]);

                            int rate = int.Parse(parts[3]);

                            string description = parts[4];

                            int duration = int.Parse(parts[5]);

                            switch (element)
                            {
                                
                                case "Simple Saving":

                                    SimpleSaving simpleSaving = new(amount, rate, startingDate, description,duration);

                                    _savings.Add(simpleSaving);

                                    break;

                                case "Compound Saving":

                                    CompoundSaving compoundSaving = new(amount, rate, startingDate, description, duration);

                                    _savings.Add(compoundSaving);

                                    break;

                                case "Simple Loan":// W.I.P.

                                    break;

                                // other loans.

                            }

                        }
                        catch (Exception)
                        {
                            
                            Console.WriteLine($"Error: {fileName} File formated inproperly.");

                            break;

                        }

                    }

                }

            }
            else
            {
                
                Console.Clear();

                Console.WriteLine($"Error: File {fileName} not found.\n");

            }

        }

    }

}