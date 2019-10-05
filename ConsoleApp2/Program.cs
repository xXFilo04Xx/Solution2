using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero da convertire");
            int valute = int.Parse(Console.ReadLine());
            string binary = Convert.ToString(valute, 2);
            Console.WriteLine($"Il numero binario è {binary}");
            string ottale = Convert.ToString(valute, 8);
            Console.WriteLine($"Il numero ottale è {ottale}");
            string esadecimale = Convert.ToString(valute, 16);
            Console.WriteLine($"Il numero esadecimale è {esadecimale}");
            Console.ReadLine();
        }
    }
}
