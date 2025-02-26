using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
            static void Main(string[] args)
            {
            Console.Write("Введите значение параметра х: ");
            string s = Console.ReadLine();
            double x = double.Parse(s);
            double F = 2 * Math.Cos(x);
            Console.WriteLine($"Значение F = {F}.");
            Console.ReadKey();
        }
    
    }
}
