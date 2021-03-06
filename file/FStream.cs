using System;
using System.IO;

namespace dot.file
{
    public class FStream
    {
        private string _path = @"../../../file/lorem.txt";
        protected FileStream fs = null;
        protected StreamReader sr = null;
        public void Frs()
        {
            try
            {
                fs = new FileStream(_path, FileMode.Open);
                sr = new StreamReader(fs);

                string rl = sr.ReadToEnd();
                Console.WriteLine(rl);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
                fs.Close();
            }
            finally
            {
                fs.Close();
            }
        }

    }
}