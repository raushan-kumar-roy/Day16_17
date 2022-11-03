namespace DSprogram
{
    class Program
    {
        public static void Main(string[] args)
        {
            //BubbleSort bubbleSort = new BubbleSort();
            //bubbleSort.Display();

            //InsertionSort insertionSort = new InsertionSort();
            //insertionSort.Display();

            //Anagram anagram = new Anagram();
            //anagram.Display();

            //int[] arr = { 12, 11, 13, 5, 6, 7 };
            //Console.WriteLine("Given Array");
            //printArray(arr);
            //MergeSort ob = new MergeSort();
            //ob.sort(arr, 0, arr.Length - 1);
            //Console.WriteLine("\nSorted array");
            //printArray(arr);


            //Console.WriteLine("Enter starting point : ");
            //int start = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Ending Point : ");
            //int end = Convert.ToInt32(Console.ReadLine());
            //ArrayList primeNumbers = PrimeNumberRange.FindPrimeNumbers(start, end);
            //Console.WriteLine($"\nAll the prime numbers between {start} and {end} are :");
            //foreach (int prime in primeNumbers)
            //{
            //    Console.WriteLine(prime);
            //}

            PalindromePrime obj = new PalindromePrime();
            for (int i = 1; i < 1000; i++)
            {
                if (obj.isPrime(i) && obj.isPalindrome(i))
                    Console.WriteLine(i + " ");
            }



        }

    
}
}
