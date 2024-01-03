using System;
namespace QuicksortAlgorithm2
{
    class Quicksort
    {
        static void Main()
        {
            int[] arr = { 12, 4, 5, 6, 7, 3, 1, 15 };
            QuicksortAlgorithm(arr, 0, arr.Length - 1);

            Console.WriteLine("Sorted array:");
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        static void QuicksortAlgorithm(int[] A, int left, int right)
        {
            if (left < right)
            {
                int loc = Partition(A, left, right);
                QuicksortAlgorithm(A, left, loc - 1);
                QuicksortAlgorithm(A, loc + 1, right);
            }
        }

        static int Partition(int[] A, int left, int right)
        {
            int pivot = A[left];
            while (left < right)
            {
                while (A[left] < pivot)
                {
                    left++;
                }
                while (A[right] > pivot)
                {
                    right--;
                }
                if (left < right)
                {
                    Swap(ref A[left], ref A[right]);
                }
            }
            Swap(ref A[left], ref A[right]);
            return right;
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
}