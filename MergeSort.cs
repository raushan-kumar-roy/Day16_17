using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSprogram
{
    public class MergeSort
    {
        public void merge(int[] arr, int low, int mid, int r)
        {

            int i, j;
            int n1 = mid - 1 + 1;
            int n2 = r - mid;
            int[] L = new int[n1];
            int[] R = new int[n2];

            for (i = 0; i < n1; ++i)
                L[i] = arr[1 + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[mid + 1 + j];

            i = 0;
            j = 0;

            int k = 1;

            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }
                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }
            }


        }
        public void sort(int[] arr, int l, int r)
        {
            if (l < r)
            {

                int m = l + (r - l) / 2;


                sort(arr, l, m);
                sort(arr, m + 1, r);


                merge(arr, l, m, r);
            }
        }
        public void printArray(int[] arr)
        {


            int n = arr.Length;
            for (int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
                Console.WriteLine();
            }

        }


    }
}
