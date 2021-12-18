using Sort.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sort.Model
{
    public class MergeSort : ISort
    {
        public int[] Sort(int[] arrays)
        {

            // l               r
            // 9,8,7,6,5,4,3,2,1

            var left = 0;
            var right = arrays.Length - 1;

            return this.SortItem(arrays, left, right);
        }

        private int[] SortItem(int[] arrays, int left, int right) 
        {
            Console.WriteLine("Split left:{0}，right:{1}",left,right);
            //this.Print(arrays,left,right);

            if (left < right) 
            {
                var middle = (left + right) / 2;

                this.SortItem(arrays, left, middle);
                this.SortItem(arrays, middle + 1, right);

                this.SortItem(arrays, left, middle, right);
            }

            return arrays;
        }

        // Merges two subarrays of arr[]
        // First subarray is array[l..m]
        // Second subarray is array[m+1..r]
        private void SortItem(int[] arrays, int left,int middle, int right)
        {
            Console.WriteLine("Split left:{0},middle:{1}，right:{2}", left, middle,right);

            // Find Sizes of Two Subarrays To Be Merged
            int n1 = middle - left + 1;
            int n2 = right - middle;
            Console.WriteLine("Merge- n1:{0},n2:{1}", n1, n2);

            // Create Temp Arrays
            int[] L = new int[n1];
            int[] R = new int[n2];
            int i = 0;
            int j = 0;
            for (i = 0; i < n1; i += 1) 
            {
                L[i] = arrays[left + i];
            }

            for (j = 0; j < n2; j += 1)
            {
                R[j] = arrays[middle + 1 + j];
            }

            i = 0;
            j = 0;
            int k = left;
            while (i < n1 && j < n2) 
            {
                if (L[i] <= R[j])
                {
                    arrays[k] = L[i];
                    i += 1;
                }
                else 
                {
                    arrays[k] = R[j];
                    j += 1;
                }

                k += 1;
            }

            while (i < n1) 
            {
                arrays[k] = L[i];
                i += 1;
                k += 1;
            }

            while (j < n2) 
            {
                arrays[k] = R[j];
                j += 1;
                k += 1;
            }

            this.Print(arrays);
        }

        private void Print(int[] arrays) 
        {
            Console.WriteLine();

            for (int i = 0; i < arrays.Length; i += 1) 
            {
                Console.Write(arrays[i] + " ");
            }

            Console.WriteLine();
        }
    }
}
