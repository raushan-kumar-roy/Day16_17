using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSprogram
{
    public class PrimeNumberRange
    {
        public static ArrayList FindPrimeNumbers(int start, int end)
        {
            int prime = 0;
            ArrayList primeNumbers = new ArrayList();
            if (start <= end)
            {
                if (start == 0)
                {
                    start += 2;
                }
                if (start == 1)
                {
                    start++;
                }
                if (start == 2)
                {
                    if (end >= 2)
                    {
                        primeNumbers.Add(2);
                        start += 1;
                    }
                }
                for (int i = start; i <= end; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            prime = 0;
                            break;
                        }
                        else
                            prime = 1;
                    }
                    if (prime == 1)
                    {
                        primeNumbers.Add(i);
                    }
                }
            }
            else
                Console.WriteLine("Starting point should not greater than ending point");
            return primeNumbers;
        }
    }
}
