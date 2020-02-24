using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 2 == 0)
                {
                    Console.Write($" {i}");
                    if (i != 100)
                    {
                        Console.Write(",");
                    }
                }
            }
            Console.WriteLine();
                int n;
            do
            {
                Console.WriteLine("Inserisci un numero");
                n = int.Parse(Console.ReadLine());
            }
            while (n != 0);
            int n1;
            do
            {
                Console.WriteLine("Inserisci un numero");
                n1 = int.Parse(Console.ReadLine());
            }
            while (n1 < 0);
            if (n1 % 2 == 0)
            {
                Console.WriteLine("Il numero è pari");
            }
            else
            {
                Console.WriteLine("Il numero è dispari");
            }
            Console.ReadLine();
        }
    }
}
