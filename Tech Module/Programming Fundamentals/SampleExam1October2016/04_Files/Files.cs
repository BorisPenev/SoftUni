namespace _04_Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class _04_Files
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, long>> inputData = new Dictionary<string, Dictionary<string, long>>();
            Dictionary<string, long> fileData = new Dictionary<string, long>();

            for (long i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split('\\');
                string fileAndSize = input[input.Length - 1];
                string[] fileInfo = fileAndSize.Split(';');
                string root = input[0];
                string fileName = fileInfo[0];
                long fileSize = long.Parse(fileInfo[1]);

                if (inputData.ContainsKey(root))
                {
                    inputData[root][fileName] = fileSize;
                }
                else
                {
                    fileData = new Dictionary<string, long>();
                    fileData[fileName] = fileSize;
                    inputData[root] = fileData;
                }
            }

            string[] subject = Console.ReadLine().Split();
            string fileTypeSubject = subject[0];
            string rootSubject = subject[2];

            bool areThereResults = false;
            
                fileData = inputData[rootSubject]
                .OrderByDescending(y => y.Value)
                .ThenBy(id => id.Key)
                .ToDictionary(d => d.Key, d => d.Value);



            foreach (KeyValuePair<string, long> filePair in inputData[rootSubject])
            {
                string[] fileNameAndExtension = filePair.Key.Split('.');

                if (fileNameAndExtension[1].Equals(fileTypeSubject))
                {
                    areThereResults = true;
                    Console.WriteLine($" {filePair.Key} -> {filePair.Value} KB");
                }
            }

            if (!areThereResults)
            {
                Console.WriteLine("No");
            }
        }
    }
}
