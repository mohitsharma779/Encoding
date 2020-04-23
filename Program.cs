using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiddle
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string processFilePath = @"D:\ENCODING\File1.DAT";
                string outfile = @"D:\ENCODING\File2.txt";
                string readerEncoding = "ASCII";
                string writerEncoding = "UTF-8";
                

                using (StreamReader reader = new StreamReader(processFilePath, Encoding.Default))
                {
                    using (StreamWriter writer = new StreamWriter(outfile, true, Encoding.GetEncoding(writerEncoding)))
                    {
                        writer.WriteLine(reader.ReadToEnd());
                    }
                }
                Console.WriteLine("Done");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();

        }

        public static FileStream ReadFile(string filepath)
        {
            return File.Open(filepath, FileMode.Open, FileAccess.Read, FileShare.None);
        }
    }
}
