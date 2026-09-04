using System;
namespace Sortin //Selection Sort
{
    class Program
    {

        // Main program
        public static void Main(string[] args)
        {
            try
            {
                int[] arr = { 64, 25, 12, 22, 11 };
                sort(arr);
                Console.WriteLine("Sorted array");
                printArray(arr);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error encountered. \n{e.ToString()}");
            }
            finally
            {
                Console.ReadKey();
            }
        }
        //Perform the insertion sort algorithm
        public static void sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = arr[i];
                int j = i - 1;

                // Move elements of arr[0..i-1],
                // that are greater than key,
                // to one position ahead of
                // their current position
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
                printArray(arr);
            }
        }
        // Prints the array
        static void printArray(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " | ");
            Console.WriteLine();
        }

    }
}
