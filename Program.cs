using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores? ");
            int n = int.Parse(Console.ReadLine());

            PrintService printService = new PrintService();

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                printService.AddValue(x);
            }

            Console.WriteLine("Primeiro elemento: " + printService.First());

            Console.WriteLine("-----------");

            printService.Print();
        }
    }
}
