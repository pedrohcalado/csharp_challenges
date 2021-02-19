using System;
using DividersAndPrimes.Service;

namespace DividersAndPrimesNS
{
    public class DividersAndPrimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro:");
            var entryValue = Console.ReadLine();
            Menu(entryValue);
        }

        public static void Menu(string entryValue)
        {
            try
            {
                var dividers = MainClass.GetDividers(int.Parse(entryValue));
                var primeDividers = MainClass.GetPrimeDividers(int.Parse(entryValue));
                Console.WriteLine($"Número de entrada: {entryValue}");
                Console.WriteLine($"Números divisores: {String.Join(" ", dividers)}");
                Console.WriteLine($"Divisores primos: {String.Join(" ", primeDividers)}");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Digite um número inteiro:");
                Menu(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"Error: {e.Message}");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("Digite um número inteiro:");
                Menu(Console.ReadLine());
            }
        }
    }
}
