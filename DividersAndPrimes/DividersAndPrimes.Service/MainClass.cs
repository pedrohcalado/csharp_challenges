using System;
using System.Collections.Generic;

namespace DividersAndPrimes.Service
{
    public static class MainClass
    {
        public static List<int> GetPrimeDividers(int entryValue)
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

                if (counter == 2)
                {
                    primeDividers.Add(item);
                }

                counter = 0;
            }

            return primeDividers;
        }

        public static List<int> GetDividers(int entryValue)
        {
            List<int> dividers = new List<int>();

            for (int i = 1; i <= entryValue; i++)
            {
                if ((entryValue % i) == 0)
                    dividers.Add(i);
            }
            return dividers;
        }
    }
}
