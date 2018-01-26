using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_2
{
    class FileWorker
    {
        FileStream stream1 = new FileStream("FirstDoc.txt", FileMode.Open);
        FileStream stream2 = new FileStream("SecondDoc.txt", FileMode.Open);
        TextWriter writer = File.CreateText("ResultDoc.txt");

        private object block = new object();

        public void ReadFile1()
        {
            StreamReader reader = new StreamReader(stream1);
            string res = reader.ReadToEnd();
            reader.Close();
            WriteFile(res);
        }

        public void ReadFile2()
        {
            StreamReader reader = new StreamReader(stream2);
            string res = reader.ReadToEnd();
            reader.Close();
            WriteFile(res);
        }

        private void WriteFile(string content)
        {
            lock (block)
            {
                writer.WriteLine(content);
                Console.WriteLine("Поток {0} завершился", Thread.CurrentThread.GetHashCode());
            }
        }

        public void CloseThread()
        {
            writer.Close();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            FileWorker instance = new FileWorker();

            Thread thread1 = new Thread(instance.ReadFile1);
            Thread thread2 = new Thread(instance.ReadFile2);

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
            Thread.Sleep(200);
            instance.CloseThread();
            Console.ReadKey();


        }
    }
}
