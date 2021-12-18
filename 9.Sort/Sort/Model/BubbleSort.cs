using Sort.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sort.Model
{
    public class BubbleSort : ISort
    {
        public int[] Sort(int[] arrays)
        {
            int temp;
            for (int i = 0; i < arrays.Length; i += 1) 
            {
                for (int j = 0; j < arrays.Length - 1; j += 1) 
                {
                    if (arrays[j] > arrays[j + 1]) 
                    {
                        temp = arrays[j + 1];
                        arrays[j + 1] = arrays[j];
                        arrays[j] = temp;
                    }
                }
            }

            return arrays;
        }
    }
}
