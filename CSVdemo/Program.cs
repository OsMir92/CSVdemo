using System;

namespace CSVdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!\n\n");
            //Write sample data to a .csv file
            using (CsvFileWriter writer = new CsvFileWriter("Test.csv"))
            {
                for (int i = 0; i < 10; i++)
                {
                    CsvRow row = new CsvRow();
                    for (int j = 0; j < 3; j++)
                        row.Add(String.Format("Column{0}", j));
                    writer.WriteRow(row);
                }
            }
            
            //Read the sample data
            using (CsvFileReader reader = new CsvFileReader("Test.csv"))
            {
                CsvRow row = new CsvRow();
                while (reader.ReadRow(row))
                {
                    foreach (string s in row)
                    {
                        Console.Write(s);
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }

    }

}
