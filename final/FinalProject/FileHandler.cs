namespace Inversions
{
    public class FileHandler
    {

        List<Saving> _savings;

        List<Loan> _loans;

        public FileHandler(List<Saving> savings, List<Loan> loans)
        {

            _savings = savings;

            _loans = loans;

        }

        public void SaveRegistry()
        {
            
            Console.Clear();

            if (_savings.Count < 1 && _loans.Count < 1)
            {

                Console.WriteLine("File can not be created, there is no data to save.\n");                

            }

            else
            {

                Console.Write("Save the registry on a CSV file.\n(Do not add the .CSV at the end of the file name.\nFile name: ");

                string fileName = Console.ReadLine()+".csv";

                Console.Clear();

                if (_savings.Count > 0 && _loans.Count > 0)
                {

                    using StreamWriter outputFile = new(fileName);

                    foreach (Saving record in _savings)
                    {

                        outputFile.WriteLine(record.GetStringElement());

                    }

                    foreach (Loan record in _loans)
                    {

                        outputFile.WriteLine(record.GetStringElement());

                    }

                    Console.WriteLine("File saved.\n");

                }
                
                else if (_loans.Count > 0 && _savings.Count < 1)
                {

                    using StreamWriter outputFile = new(fileName);

                    foreach (Loan record in _loans)
                    {

                        outputFile.WriteLine(record.GetStringElement());

                    }

                    Console.WriteLine("File saved.\n");
                    
                }

                else if (_savings.Count > 0 && _loans.Count < 1)
                {

                    using StreamWriter outputFile = new(fileName);

                    foreach (Saving record in _savings)
                    {

                        outputFile.WriteLine(record.GetStringElement());

                    }

                    Console.WriteLine("File saved.\n");
                    
                }

            }

        }

        public void GetRegistry()
        {

            Console.Clear();
            
            Console.Write("Load the registry from a CSV file.\n(Do not add the .CSV at the end of the file name.\nFile name: ");

            string fileName = Console.ReadLine()+".csv";

            if (File.Exists(fileName))
            {

                List<Saving> _temporalSavingsList = new();

                List<Loan> _temporalLoansList = new();

                using StreamReader reader = new(fileName);

                _savings.Clear();

                _loans.Clear();

                string line;

                while ((line = reader.ReadLine()) != null)
                {

                    try
                    {

                        string[] parts = line.Split("‖");

                        string element = parts[0];

                        string registrationDate = parts[1];

                        double amount = double.Parse(parts[2]);

                        double rate = double.Parse(parts[3]);

                        string lapseOfTime = parts[4];

                        int duration = int.Parse(parts[5]);

                        string description = parts[6];

                        switch (element)
                        {

                            case "Simple Saving":

                                SimpleSaving simpleSaving = new(amount, rate, registrationDate, lapseOfTime, duration, description);

                                _temporalSavingsList.Add(simpleSaving);

                                break;

                            case "Compound Saving":

                                int interestCompound = int.Parse(parts[7]);

                                CompoundSaving compoundSaving = new(amount, rate, interestCompound, registrationDate, lapseOfTime, duration, description);

                                _temporalSavingsList.Add(compoundSaving);

                                break;

                            case "Personal Loan":

                                int anualPayments = int.Parse(parts[7]);

                                PersonalLoan personalLoan = new(amount, anualPayments, rate, registrationDate, lapseOfTime, duration, description);

                                _temporalLoansList.Add(personalLoan);

                                break;

                            case "Payday Loan":

                                int fees = int.Parse(parts[7]);

                                PaydayLoan paydayLoan = new(amount, fees, rate, registrationDate, lapseOfTime, duration, description);

                                _temporalLoansList.Add(paydayLoan);

                                break;

                        }

                        Console.Clear();

                        Console.WriteLine($"File {fileName} loaded succesfully.\n");

                    }

                    catch (Exception)
                    {

                        Console.Clear();

                        Console.WriteLine($"Error: {fileName} File formated inproperly.\n");

                        break;

                    }

                    if(_temporalLoansList.Count > 0 || _temporalSavingsList.Count > 0)
                    {

                        _loans = _temporalLoansList;

                        _savings = _temporalSavingsList;
                        
                        Console.Clear();

                        Console.WriteLine($"File {fileName} loaded succesfully.\n");
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