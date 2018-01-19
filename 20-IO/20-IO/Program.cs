using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"Test.txt";

            var writer = File.CreateText(path);
            writer.Write("Hello world!!");
            writer.Close();

            var reader = File.OpenText(path);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();

            Console.ReadKey();
        }
    }
}
