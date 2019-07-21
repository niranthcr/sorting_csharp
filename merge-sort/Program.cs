using System;

namespace merge_sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {2,7,4,1,5,3};
            merge_sort(arr);

        }

        public static void merge_sort(int[] A)
        {
            int n = A.Length;

            if(n < 0)
                return;
            
            int mid = n/2;
            int[] left = new int[mid];
            int[] right = new int[n-mid];
            for(int i = 0; i < mid; i++)
            {
                left[i] = A[i];
            }
            for(int i = mid; i < n; i++)
            {
                right[i - mid] = A[i];
            }
            merge_sort(left);
            merge_sort(right);
            Merge(left, right, A);

            foreach(int item in A)
            {
                System.Console.Write($"{item} ");
            }
        }

        public static void Merge(int[] left, int[] right, int[] A)
        {
            int nLeft = left.Length;
            int nRight = right.Length;
            int i = 0, j = 0, k = 0;
            while(i<nLeft && j<nRight)
            {
                if(left[i] <= right[j])
                {
                    A[k] = left[i];
                    i++;
                }
                else
                {
                    A[k] = right[j];
                    j++;
                }
                k++;
            }
            while(i < nLeft)
            {
                A[k] = left[i];
                i++;
                k++;
            }
            while(j < nRight)
            {
                A[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
