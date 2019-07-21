using System;

namespace sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,7,4,1,5,3};
            int n = arr.Length;
            SelectionSort(arr, n);
        }

        public static void SelectionSort(int[] arr, int n)
        {
            for(int i = 0; i < n - 1; i++)
            {
                int iMin = i;
                for(int j = i+1; j<n; j++)
                {
                    if(arr[j] < arr[iMin])
                        iMin = j;
                }
                int temp = arr[i];
                arr[i] = arr[iMin];
                arr[iMin] = temp;
            }
            foreach(int i in arr)
            {
                System.Console.Write($"{i} ");
            }   
            Console.ReadLine(); 
        }
    }
}
