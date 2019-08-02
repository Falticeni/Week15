using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercitiul_2
{
    class Program
    {
        static async Task<double> Compute()
        {
            Console.WriteLine("Se calculeaza Pi async: {0}", await ComputePi());
            Console.WriteLine();
            Console.WriteLine("Se calculeaza Pi sync: ");
            return ComputePi().Result;
        }
        static async Task<double> ComputePi()
        {
            var sum = 0.0;
            var step = 1e-9;

            for (var i = 0; i < 1000000000; i++)
            {
                var x = (i + 0.5) * step;
                sum = sum + 4.0 / (1.0 + x * x);
            }
            return sum * step;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Compute().Result);

            Console.ReadKey();
        }
    }
}
