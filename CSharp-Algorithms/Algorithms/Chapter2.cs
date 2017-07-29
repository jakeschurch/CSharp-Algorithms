using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    class Chapter2
    {
        public static void PrintArray<T>(T[] A)
        {
            foreach (var item in A)
            { Console.Write(item + " "); }
        }

        static int[] DisArray = new int[6] { 5, 2, 4, 6, 1, 3 };

        static int[] InsertSort(int[] A)
        {   // efficient for sorting small number of elements
        for (int j = 1; j < A.Length; j++)
            {
                int key = A[j];
                int i = j - 1;

                while (i >= 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                A[i + 1] = key;
            }
            return A;
        }

        static int[] ReverseInsertSort(int[] A)
        {   // Ex. 2.1-2
            for (int j = 1; j < A.Length; j++)
            {
                int key = A[j];
                int i = j - 1;

                while (i >= 0 && A[i] < key)
                {
                    A[i + 1] = A[i];
                    i = i - 1;
                }
                A[i + 1] = key;
            }
            return A;
        }

        static int? LinearSearch(int[] A, int v)
        {   // Ex. 2.1-3
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] == v)
                {
                    return i;
                }
            }
            return null;
        }


        static void Main(string[] args)
        {
            //int[] DatArray = ReverseInsertSort(DisArray);
            //PrintArray<int>(DatArray);
            Console.WriteLine(LinearSearch(DisArray, 10));
            Console.ReadKey();
        }
    }
}
