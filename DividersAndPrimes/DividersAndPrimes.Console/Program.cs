using System;
using DividersAndPrimes.Service;

namespace DividersAndPrimesNS
{
    public class DividersAndPrimes
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            //do fazer um caso para exceptions
            //{
            Console.WriteLine("Digite um número inteiro (ESC para sair):");

            var entryValue = Console.ReadLine();

            var dividers = MainClass.GetDividers(int.Parse(entryValue));
            var primeDividers = MainClass.GetPrimeDividers(int.Parse(entryValue));

            Console.WriteLine($"Número de entrada: {entryValue}");
            Console.WriteLine($"Números divisores: {String.Join(" ", dividers)}");
            Console.WriteLine($"Divisores primos: {String.Join(" ", primeDividers)}");
            Console.WriteLine("----------------------------------------------");
            Menu();
            //}
            //while (Console.ReadKey().Key != ConsoleKey.Escape);


        }
    }
}
