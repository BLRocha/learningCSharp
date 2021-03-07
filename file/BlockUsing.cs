using System;
using System.IO;

namespace dot.file
{
    public class BlockUsing
    {
        private string _path = @"../../../file/lorem.txt";

        public void UsingTest()
        {
            using (FileStream fs = new FileStream(_path, FileMode.Open))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    int count = 0;
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine($"Line number: {count}, Content: {sr.ReadLine()}");
                        count++;
                    }
                }
            }
        }

        public void UsingOpenText()
        {
            using (StreamReader sr = File.OpenText(_path))
            {
                int count = 0;
                while (!sr.EndOfStream)
                {
                    Console.WriteLine($"Line number: {count}, Content: {sr.ReadLine()}");
                    count++;
                }
            }
        }
    }
}