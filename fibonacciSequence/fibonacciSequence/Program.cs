using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fibbonacci = new int[50];

            fibbonacci[0] = 0;
            fibbonacci[1] = 1;

            for (int i = 2; i < fibbonacci.Length; i++)
            {
                fibbonacci[i] = fibbonacci[i - 2] + fibbonacci[i - 1];
            }
            
            Console.WriteLine(string.Join(",\n", fibbonacci));

            Console.ReadKey();

        }
    }
}
