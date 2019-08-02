using System;
using System.IO;

namespace Exercitiul_4.Class
{
    public class SumAndAverage
    {
        public static decimal Sum(string file)
        {
            decimal sum = 0;
            StreamReader stream = new StreamReader(file);
            while (!stream.EndOfStream)
            {
                sum += decimal.Parse(stream.ReadLine());
            }
            return sum;
        }

        public static decimal Average(string file)
        {
            decimal sum = 0;
            decimal count = 0m;
            StreamReader stream = new StreamReader(file);
            while (!stream.EndOfStream)
            {
                sum += decimal.Parse(stream.ReadLine());
                count++;
            }
            return (sum / count);
        }

        public static float AverageFromAllFiles(string file1, string file2, string file3, string file4, string file5)
        {
            float sum = 0;
            float count = 0;
            StreamReader stream1 = new StreamReader(file1);
            while (!stream1.EndOfStream)
            {
                sum += Convert.ToInt32(stream1.ReadLine());
                count++;
            }
            StreamReader stream2 = new StreamReader(file2);
            while (!stream2.EndOfStream)
            {
                sum += Convert.ToInt32(stream2.ReadLine());
                count++;
            }
            StreamReader stream3 = new StreamReader(file3);
            while (!stream3.EndOfStream)
            {
                sum += Convert.ToInt32(stream3.ReadLine());
                count++;
            }
            StreamReader stream4 = new StreamReader(file4);
            while (!stream4.EndOfStream)
            {
                sum += Convert.ToInt32(stream4.ReadLine());
                count++;
            }
            StreamReader stream5 = new StreamReader(file5);
            while (!stream5.EndOfStream)
            {
                sum += Convert.ToInt32(stream5.ReadLine());
                count++;
            }
            return (sum / count);
        }


    }
}
