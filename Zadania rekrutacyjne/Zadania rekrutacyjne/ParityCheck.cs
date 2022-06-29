using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadania_rekrutacyjne
{
    internal static class ParityCheck
    {
        public static void ParityCheckMethod(int x)
        {
            int b = 2;
            if(x % b == 0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
            {
                Console.WriteLine("Liczba nie jest parzysta");
            }      
        }
    }
}
