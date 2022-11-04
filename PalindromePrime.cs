using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSprogram
{
    public class PalindromePrime
    {
        public Boolean isPrime(int n)
        {
            int c = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    c++;
            }
            if (c == 2)
                return true;
            else
                return false;
        }
        public Boolean isPalindrome(int n)
        {
            int temp = n;
            int rev = 0;
            while (temp > 0)
            {
                int d = temp % 10;
                rev = rev * 10 + d;
                temp = temp / 10;
            }
            if (n == rev)
                return true;
            else
                return false;
        }
    
}
}
