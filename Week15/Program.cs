using System;
using System.Collections.Generic;
using System.Diagnostics;
using Speech.Engine;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week15
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();

            var list = new List<string>();
            var hashset = new HashSet<string>();

            int count = 0;
            var number = 10000000;


            var s1 = new Stopwatch();
            s1.Start();
            for (var x = 0; x < number; x++)
            {
                list.Add("string_" + x);
                count++;
                if (count % 1000000 == 0)
                {
                    Console.WriteLine("S-au inserat {0} procente date", count / (number / 100));
                }
            }
            Console.WriteLine($"Insert into list {s1.ElapsedMilliseconds} ms");
            s1.Stop();


            //var s2 = new Stopwatch();
            //s2.Start();
            //for (var x = 0; x < 10000000; x++)
            //{
            //    hashset.Add("string_" + x);
            //    for (int i = 0; i < number; i++)
            //    {
            //        count++;
            //        if (count % 1000000 == 00)
            //        {
            //            Console.WriteLine("S-au inserat {0} procente date", count/number/100);
            //        }
            //    }
            //}
            //Console.WriteLine($"Insert into hashset {s2.ElapsedMilliseconds} ms");
            //s2.Stop();

            //var stringToSearch = "string_9234231";

            //var s3 = new Stopwatch();
            //s3.Start();
            //list.Contains(stringToSearch);
            //Console.WriteLine($"Time to search {s3.ElapsedMilliseconds} ms, in list");
            //s3.Stop();

            //var s4 = new Stopwatch();
            //s4.Start();
            //hashset.Contains(stringToSearch);
            //Console.WriteLine($"Time to search {s4.ElapsedMilliseconds} ms, in hashset");
            //s4.Stop();

            //var s5 = new Stopwatch();
            //s5.Start();
            //list.Remove(stringToSearch);
            //Console.WriteLine($"Time to delete {s5.ElapsedMilliseconds} ms, in list");
            //s5.Stop();

            //var s6 = new Stopwatch();
            //s6.Start();
            //hashset.Remove(stringToSearch);
            //Console.WriteLine($"Time to delete {s6.ElapsedMilliseconds} ms, in hashset");
            //s6.Stop();
        }
    }
}
