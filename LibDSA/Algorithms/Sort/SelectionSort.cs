using System;
using System.Collections.Generic;
using System.Text;
using static LibDSA.DSAHelper;

namespace LibDSA
{
    public partial class Sort
    {
        public void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                int min_index = i;

                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min_index] )
                    {
                        min_index = j;
                    }
                }
                if (arr[i] > arr[min_index]) Swap(ref arr[i], ref arr[min_index]);


            }
        }
    }
}
