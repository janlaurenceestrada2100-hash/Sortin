using System;
namespace Sortin //exhange sort
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
        //Perform the exchange sort algorithm
        public static void sort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
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
