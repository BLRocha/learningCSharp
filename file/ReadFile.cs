using System;
using System.IO;
namespace dot.file
{
    public class ReadFile
    {
        public string CurrentPath = @"../../../file/lorem.txt";
        public string NewPath = @"../../../file/lorem_copy.txt";

        public void RdFile()
        {
            try
            {
                FileInfo file = new FileInfo(CurrentPath);
                if (file.Exists)
                {
                    string[] allLines = File.ReadAllLines(CurrentPath);

                    foreach (string currentLine in allLines)
                    {
                        Console.WriteLine(currentLine);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("File error message: " + e.Message);
            }
        }
    }
}