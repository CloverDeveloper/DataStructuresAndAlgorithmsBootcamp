using Sort.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sort.Model
{
    public class QuickSort : ISort
    {
        public int[] Sort(int[] arrays)
        {
            this.SortItem(arrays, 0, arrays.Length - 1);

            return arrays;
        }

        private void SortItem(int[] arrays, int left, int right) 
        {
            if (left >= right) 
            {
                return;
            }

            // Pick a prvot element，we will choose the center
            // Better would be to choose left + (right - left)/2 avoid overflow
            int pivot = arrays[(left + right) / 2];

            // Partition the array around this pivot and return the index of partition
            int index = this.Partition(arrays, left, right, pivot);

            // Sort on left and right side
            this.SortItem(arrays, left, index - 1);
            this.SortItem(arrays, index, right);
        }

        private int Partition(int[] arrays, int left, int right, int pivot) 
        {
            // Move the left and right pointer in toward each other
            while (left <= right) 
            {
                // move left until find bigger than pivot
                while (arrays[left] < pivot) 
                {
                    left += 1;
                }

                // move right until find smaller than pivot
                while (arrays[right] > pivot) 
                {
                    right -= 1;
                }

                // than swap
                if (left <= right) 
                {
                    int temp = arrays[left];
                    arrays[left] = arrays[right];
                    arrays[right] = temp;

                    left += 1;
                    right -= 1;
                }
            }

            this.Print(arrays);

            return left;
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
