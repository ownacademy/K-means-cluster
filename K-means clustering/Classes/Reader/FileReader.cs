using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K_means_clustering.Classes.Reader
{
    class FileReader
    {
        private string filePath = "Dataset/WineData.csv";
        private int[,] dataSet = new int[32, 100];

        public void StartRead()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader fileReader = new StreamReader(filePath))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line;
                    int currentWine = 0;

                    while ((line = fileReader.ReadLine()) != null)
                    {
                        var currentLine = line.Split(',');

                        for (int i = 0; i < currentLine.Length; i++)
                        {
                            dataSet[currentWine, i] = int.Parse(currentLine[i]);
                        }

                        currentWine++;
                    }

                    Console.WriteLine("Data has been added!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
