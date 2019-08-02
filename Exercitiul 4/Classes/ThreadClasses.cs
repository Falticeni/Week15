using Exercitiul_4.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul_4.Classes
{
    public class ThreadClasses
    {
        private const string file1 = "File1.txt";
        private const string file2 = "File2.txt";
        private const string file3 = "File3.txt";
        private const string file4 = "File4.txt";
        private const string file5 = "File5.txt";

        public static void AverageFromEachFile()
        {
            Console.WriteLine("Media numerelor primului fisier este: {0}.", (SumAndAverage.Average(file1)));
            Console.WriteLine("Media numerelor din fisierul nr. 2 este: {0}.", (SumAndAverage.Average(file2)));
            Console.WriteLine("Media numerelor din fisierul nr. 3 este: {0}.", (SumAndAverage.Average(file3)));
            Console.WriteLine("Media numerelor din fisierul nr. 4 este: {0}.", (SumAndAverage.Average(file4)));
            Console.WriteLine("Media numerelor din fisierul nr. 5 este: {0}.", (SumAndAverage.Average(file5)));
            Console.WriteLine();
        }
        public static void SumFromEachFile()
        {
            Console.WriteLine("Suma numerelor primului fisier este: {0}.", SumAndAverage.Sum(file1));
            Console.WriteLine("Suma numerelor din fisierul nr. 2 este: {0}.", SumAndAverage.Sum(file2));
            Console.WriteLine("Suma numerelor din fisierul nr. 3 este: {0}.", SumAndAverage.Sum(file3));
            Console.WriteLine("Suma numerelor din fisierul nr. 4 este: {0}.", SumAndAverage.Sum(file4));
            Console.WriteLine("Suma numerelor din fisierul nr. 5 este: {0}.", SumAndAverage.Sum(file4));
            Console.WriteLine();
        }
        public static void AverageFromAllFiles()
        {
            Console.WriteLine("Media numerelor din toate fisierele este: {0}.", SumAndAverage.AverageFromAllFiles(file1, file2, file3, file4, file5));
            Console.WriteLine();
        }

        public static void SumFromAllFiles()
        {
            var s = SumAndAverage.Sum(file1) + SumAndAverage.Sum(file2) + SumAndAverage.Sum(file3) + SumAndAverage.Sum(file4) + SumAndAverage.Sum(file5);
            Console.WriteLine("Suma numerelor din toate fisierele este: {0}.", s);
            Console.WriteLine();
        }
    }
}
