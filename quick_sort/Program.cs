using System;

namespace quick_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
 
        public static void quick_sort(int[] arr, int start, int end)
        {
            if(start < end)
            {
                int pIndex = partition(arr, start, end);
                quick_sort(arr, start, pIndex - 1);
                quick_sort(arr, pIndex + 1, end);
            }
        }

        public static int partition(int[] arr, int start, int end)
        {
            int pIndex = start;
            int pivot = arr[end];
            int temp = 0;
            for(int i = 0; i<end; i++)
            {
                if(arr[i] < pivot)
                {
                    temp = arr[i];
                    arr[i] = arr[pIndex];
                    arr[pIndex] = temp;

                    pIndex++; 
                }
                temp = arr[pIndex];
                arr[pIndex] = arr[end];
                arr[end] = temp;
            }

            return pIndex;
        }
    }
}
