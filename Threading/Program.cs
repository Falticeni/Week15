using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threading
{
    internal class Program
    {
        private const string fileName = "TextFileSmaller.txt";
        private static object locker = new Object();
        static void Main(string[] args)
        {
            var currentThreadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"[Main Thread] Hello from thread with id: {currentThreadId}");

            var thread1 = new Thread(RunOnThread1);
            thread1.Start();

            var thread2 = new Thread(RunOnThread2);
            thread2.Start();

            var thread3 = new Thread(RunOnThread3);
            thread3.Start();


            Console.WriteLine("Gata thread-urile!");
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void RunOnThread1()
        {
            var start = 0;
            var end = 1000;


            var currentThreadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"[Main Thread1] Hello from thread with id: {currentThreadId}");

            for (int i = start; i < end; i++)
            {
                lock (locker)
                {
                    File.AppendAllText(fileName, i + Environment.NewLine);
                }
            };

            //Thread.Sleep(TimeSpan.FromSeconds(10));
            Console.WriteLine($"[Main Thread1] Hello delaided 10 sec from thread with id: {currentThreadId}");
        }
        private static void RunOnThread2()
        {
            var start = 1001;
            var end = 2000;

            var currentThreadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"[Main Thread2] Hello from thread with id: {currentThreadId}");

            for (int i = start; i < end; i++)
            {
                lock (locker)
                {
                    File.AppendAllText(fileName, i + Environment.NewLine);
                }
            };

            //Thread.Sleep(TimeSpan.FromSeconds(5));
            Console.WriteLine($"[Main Thread2] Hello delaided 5 sec from thread with id: {currentThreadId}");
        }
        private static void RunOnThread3()
        {
            var start = 2001;
            var end = 3000;

            var currentThreadId = Thread.CurrentThread.ManagedThreadId;
            Console.WriteLine($"[Main Thread3] Hello from thread with id: {currentThreadId}");

            for (int i = start; i < end; i++)
            {
                lock (locker)
                {
                    File.AppendAllText(fileName, i + Environment.NewLine);
                }
            };

            //Thread.Sleep(TimeSpan.FromSeconds(3));
            Console.WriteLine($"[Main Thread3] Hello delaided 2 sec from thread with id: {currentThreadId}");
        }
    }
}
