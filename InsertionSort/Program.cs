using System;

namespace InsertionSort{


    public class inserionSorting
    {
        public static void Sort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; ++i)
            {
                int key = array[i];
                int j = i - 1;

                while(j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j = j - 1;
                }
                array[j + 1] = key;
            }
        }

        public static void PrintArray(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine(array[i] + " ");
            }
        }

        public static void Main()
        {
            int[] array = { 14, 58, 64, 877, 47};
            
            inserionSorting.Sort(array);
            PrintArray(array);
        }
    }
}


