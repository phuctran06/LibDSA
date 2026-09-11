using System;
using System.Collections.Generic; 

namespace LibDSA
{
    public partial class Search
    {
        public List<int> LinearSearch(int[] arr, int target)
        {
            List<int> index_list = new List<int>(); 

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    index_list.Add(i);
                }
            }

            return index_list;
        }
    }
}
