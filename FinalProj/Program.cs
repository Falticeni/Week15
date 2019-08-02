using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Exercitiul1.Class;

namespace Exercitiul1
{
    class Program
    {
        private const string outputSmallFile = "outputSmallFile.txt";
        private const string outputBigFile = "outputBigFile.txt";

        static void Main(string[] args)
        {
            Thread smallData = new Thread(ReadAndWriteFile.ReadSmallFileData);
            smallData.Start();
            smallData.Join();
            ReadAndWriteFile.Write(outputSmallFile);

            Thread bigData = new Thread(ReadAndWriteFile.ReadBigFileData);
            bigData.Start();
            bigData.Join();
            ReadAndWriteFile.Write(outputBigFile);

            Console.ReadKey();
        }
    }
}
