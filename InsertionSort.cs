using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSprogram
{
    public class InsertionSort
    {
        public void Display()
        {
            int[] arr = new int[5] { 23, 9, 34, 5, 1 };
            int n = 5, i, j, val, flag;

            Console.WriteLine("Insertion sort");
            Console.WriteLine("Initial Array is");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else
                    {
                        flag = 1;
                    }

                }
            }
            Console.WriteLine("After array is");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
        }
    }
}
