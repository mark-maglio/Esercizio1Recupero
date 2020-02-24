using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreariaEs1;

namespace BOB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero");
            int n = int.Parse(Console.ReadLine());
            bool risposta = Calcoli.QuadratoPerfetto(n);
            if (risposta)
            {
                Console.WriteLine($"il numero è UN QUADRATO PERFETTO");
            }
            else
                Console.WriteLine("il numero non è un quadrato perfetto");
            Console.ReadLine();
        }
    }
}
