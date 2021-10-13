using System;

namespace weekThreeADS
{
    class Program
    {public static int[] insertionSort(ref int[] A, int n)

        {
            int i, j;
            i = 0;
            
            while (i < n)
            {
                j = i;
                while (j > 0 && A[j - 1] > A[j])
                {
                    //Console.WriteLine(" before "+  A[j] + A[j - 1]);
                    swap(ref A[j], ref A[j - 1]);
                    j = j - 1;
                    //Console.WriteLine("after"+ A[j]+  A[j - 1]);
                }
                i = i + 1;
            }
            for (i = 0; i < 7; i++)
            {
                Console.WriteLine(A[i]);
            }
            return A;
         
        }
        public static void swap(ref int elementOne, ref int elementTwo)
        {
            int temp = elementOne;
            elementOne = elementTwo;
            elementTwo = temp;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Choose the size of the array");
            Console.ReadLine();
            //  int n = Convert.ToInt32(Console.ReadLine());
            int n = 7;
            int[] A = { 1, 5, 2, 6, 3, 6, 8 };
            A = insertionSort(ref A,n);
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(insertionSort(ref A, n));
            //}
        }
        
    }
}
