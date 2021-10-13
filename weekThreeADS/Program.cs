using System;

namespace weekThreeADS
{
    class Program
    {public static int insertionSort(int[] A, int n)

        {
            int i, j, x;
            i = 0;
            while (i > n)
            {
                j = i;
                while (j > 0 || A[j - 1] > A[j])
                {

                }
                i = i + 1;
            }
            return A[0];
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose the size of the array");
            Console.ReadLine();
            //  int n = Convert.ToInt32(Console.ReadLine());
            int n = 7;
            int[] A = { 1, 5, 2, 6, 3, 6, 8 };


            insertionSort(A, n);
        }
        
    }
}
