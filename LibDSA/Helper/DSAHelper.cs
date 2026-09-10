using System;
using System.Collections.Generic;
using System.Text;

namespace LibDSA
{
    public class DSAHelper
    {
        public static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
            
        }
    }
}
