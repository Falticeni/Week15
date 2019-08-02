using Exercitiul_4.Classes;
using System;
using System.Threading;


namespace Exercitiul_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread1 = new Thread(ThreadClasses.AverageFromEachFile);
            thread1.Start();
            thread1.Join();

            var thread2 = new Thread(ThreadClasses.SumFromEachFile);
            thread2.Start();
            thread2.Join();

            ThreadClasses.AverageFromAllFiles();
            ThreadClasses.SumFromAllFiles();

            Console.ReadKey();
        }
    }
}
