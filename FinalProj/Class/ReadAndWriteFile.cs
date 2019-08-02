using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercitiul1.Class
{
    public class ReadAndWriteFile
    {
        private static Dictionary<int, int> dictionary = new Dictionary<int, int>();
        private const string inputSmallFileData = "TextFileSmaller.txt";
        private const string inputBigFileData = "TextFileBigger.txt";

        public static void ReadSmallFileData()
        {
            StreamReader streamReader = new StreamReader(inputSmallFileData);
            while (!streamReader.EndOfStream)
            {
                string[] split = streamReader.ReadLine().Split();
                if (!dictionary.ContainsKey(int.Parse(split[0])))
                {
                    dictionary.Add(int.Parse(split[0]), 1);
                }
                else
                {
                    dictionary[int.Parse(split[0])]++;
                }
            }
        }

        public static void ReadBigFileData()
        {
            StreamReader streamReader = new StreamReader(inputBigFileData);
            while (!streamReader.EndOfStream)
            {
                string[] split = streamReader.ReadLine().Split();
                if (!dictionary.ContainsKey(int.Parse(split[0])))
                {
                    dictionary.Add(int.Parse(split[0]), 1);
                }
                else
                {
                    dictionary[int.Parse(split[0])]++;
                }
            }
        }

        public static void Write(string output)
        {
            StreamWriter streamWriter = new StreamWriter(output);
            foreach (var element in dictionary)
            {
                streamWriter.Write("{0}: {1} words;", element.Key, element.Value);
                streamWriter.WriteLine();
                streamWriter.Flush();
            }
        }
    }
}
