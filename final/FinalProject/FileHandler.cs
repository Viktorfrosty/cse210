namespace Inversions
{

    public class FileHandler: WalletTracker
    {

        public void SaveRegistry()// W.I.P.
        {

            Console.Write("\nSave the registry on a CSV file.\n(Do not add the .CSV at the end of the file name.\nFile name: ");

            string fileName = Console.ReadLine()+".csv";

            if (_savings.Count > 0)
            {

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {

                    foreach (Saving record in _savings)
                    {

                        outputFile.WriteLine(record.GetElementDetails());

                    }
                    
                }

            }

            Console.WriteLine("\nFile saved.");

        }

        public void GetRegistry()// W.I.P.
        {
            //
        }

    }

}