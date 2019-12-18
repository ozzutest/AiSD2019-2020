using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NWD
{
    internal class Program
    {

        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }

            return a;
        }

        private static void Main(string[] args)
        {
            Console.WriteLine($"Greatest common divisor:  {GCD(20, 40)}");
            Console.WriteLine($"Greatest common divisor:  {GCD(100, 5)}");
            Console.WriteLine($"Greatest common divisor:  {GCD(282, 78)}");
            Console.WriteLine($"Greatest common divisor:  {GCD(50, 4)}");
            Console.WriteLine($"Greatest common divisor:  {GCD(90, 20)}");
            Console.WriteLine($"Greatest common divisor:  {GCD(180, 90)}");
            Console.WriteLine($"Greatest common divisor:  {GCD(40, 6)}");
            Console.WriteLine($"Greatest common divisor:  {GCD(10000, 5500)}");
            Console.WriteLine($"Greatest common divisor:  {GCD(1000, 2000)}");
            Console.WriteLine($"Greatest common divisor:  {GCD(350, 50)}");

            Console.WriteLine();

            Console.WriteLine($"Greatest commond divisor(recursive): {GCD(2, 5)}");
            Console.WriteLine($"Greatest commond divisor(recursive): {GCD(5, 10)}");
            Console.WriteLine($"Greatest commond divisor(recursive): {GCD(50000, 25000)}");

            Console.ReadKey();
        }

        private static decimal GCD(decimal a, decimal b)  
        {
            var temporary = a % b;
            return temporary == 0 ? b : GCD(b, temporary);
        }
    }
}
