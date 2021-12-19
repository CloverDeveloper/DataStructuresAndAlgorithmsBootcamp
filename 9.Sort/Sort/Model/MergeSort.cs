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

                this.MergeItem(arrays, left, middle, right);
            }

            return arrays;
        }

        // Merges two subarrays of arr[]
        // First subarray is array[l..m]
        // Second subarray is array[m+1..r]
        private void MergeItem(int[] arrays, int left,int middle, int right)
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

        private void Test(int[] arrays, int left, int middle, int right) 
        {
            int leftGroupCount = middle - left + 1;
            int[] leftGroupArray = new int[leftGroupCount];
            for (int i = 0; i < leftGroupCount; i += 1) 
            {
                leftGroupArray[i] = arrays[i + left];
            }

            int rightGroupCount = right - middle;
            int[] rightGroupArray = new int[rightGroupCount];
            for (int i = 0; i < rightGroupCount; i += 1)
            {
                rightGroupArray[i] = arrays[i + middle + 1];
            }

            int tempCount = left;
            int leftCount = 0;
            int rightCount = 0;
            while (leftCount < leftGroupCount && rightCount < rightGroupCount) 
            {
                if (leftGroupArray[leftCount] <= rightGroupArray[rightCount]) 
                {
                    arrays[tempCount] = leftGroupArray[leftCount];
                    leftCount += 1;
                }
                else 
                {
                    arrays[tempCount] = rightGroupArray[rightCount];
                    rightCount += 1;
                }

                tempCount += 1;
            }

            while (leftCount < leftGroupCount) 
            {
                arrays[tempCount] = leftGroupArray[leftCount];
                leftCount += 1;
                tempCount += 1;
            }

            while (rightCount < rightGroupCount)
            {
                arrays[tempCount] = rightGroupArray[rightCount];
                rightCount += 1;
                tempCount += 1;
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
