using System;

namespace insertion_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,7,4,1,5,3};
            int n = arr.Length;
            insertion_sort(arr, n);
        }

        static void insertion_sort(int[] arr, int n)
        {
            for(int i = 1; i < n; i++)
            {
                int value = arr[i];
                int hole = i;
                while(hole > 0 && arr[hole-1]>value)
                {
                    arr[hole] = arr[hole - 1];
                    hole = hole - 1;
                }
                arr[hole] = value;
            }
            foreach(var item in arr)
            {
                System.Console.WriteLine($"{item} ");
            }
            
        }
    }
}
