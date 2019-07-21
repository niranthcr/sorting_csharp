using System;

namespace bubble_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,7,4,1,5,3};
            int n = arr.Length;
            bubble_sort(arr, n);
        }

        public static void bubble_sort(int[] arr, int n)
        {
            
            for(int k=0;k<n-1;k++)
            {
                int flag = 0;
                for(int i=0;i<n-k-1;i++)
                {
                    if(arr[i]>arr[i+1])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i+1] = temp;

                        flag = 1;
                    }
                }
                if(flag == 0)
                    break;
            }
            foreach (var item in arr)
            {
                System.Console.Write($"{item} ");
            }
        }
    }
}
