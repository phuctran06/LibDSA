using System;
using static LibDSA.DSAHelper;

namespace LibDSA
{
    public partial class Sort
    {
        public void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int current = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > current)
                {
                    arr[j+1] = arr[j];
                    j = j-1;
                }
                arr[j+1] = current;
            }
        }
    }
}
