using System;
using System.Collections.Generic;

namespace DividersAndPrimesNS
{
    public class DividersAndPrimes
    {
        public DividersAndPrimes() { }
        static void Main(string[] args)
        {
            DividersAndPrimes entry = new DividersAndPrimes();
            Console.WriteLine("Digite um número inteiro:");
            entry.Menu(int.Parse(Console.ReadLine()));
        }

        public void Menu(int entryValue)
        {
            Console.Clear();

            var dividers = GetDividers(entryValue);
            var primeDividers = GetPrimeDividers(entryValue);

            Console.WriteLine($"Número de entrada: {entryValue}");
            Console.WriteLine($"Números divisores: {String.Join(" ", dividers)}");
            Console.WriteLine($"Divisores primos: {String.Join(" ", primeDividers)}");
        }

        public List<int> GetDividers(int entryValue)
        {
            List<int> dividers = new List<int>();

            for (int i = 1; i <= entryValue; i++)
            {
                if ((entryValue % i) == 0)
                    dividers.Add(i);
            }
            return dividers;
        }

        public List<int> GetPrimeDividers(int entryValue)
        {
            List<int> primeDividers = new List<int>();
            int counter = 0;
            var dividers = GetDividers(entryValue);

            foreach (int item in dividers)
            {
                for (int i = 1; i <= item; i++)
                {
                    if (item % i == 0)
                    {
                        counter++;
                    }
                }

                if (counter == 2 || item == 1)
                {
                    primeDividers.Add(item);
                }

                counter = 0;
            }

            return primeDividers;
        }
    }
}
