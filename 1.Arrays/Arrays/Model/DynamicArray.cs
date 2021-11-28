using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays.Model
{
    public class DynamicArray<T>
    {
        private T[] datas;
        private int initialCapacity;

        public DynamicArray(int initialCapacity) 
        {
            this.initialCapacity = initialCapacity;
            this.datas = new T[initialCapacity];
        }

        public T GetByIndex(int index) 
        {
            return (T)this.datas[index];
        }

        public T SetByIndex(int index, T val) 
        {
            this.datas[index] = val;

            return this.datas[index];
        }

        public T InsertByIndex(int index, T val) 
        {
            for (int i = this.datas.Length - 1; i > index; i -= 1) 
            {
                this.datas[i] = this.datas[i - 1];
            }

            this.datas[index] = val;

            return this.datas[index];
        }

        public T DeleteByIndex(int index) 
        {
            var val = this.datas[index];

            for (int i = index; i < this.datas.Length - 1; i += 1) 
            {
                this.datas[i] = this.datas[i + 1];
            }

            this.datas[this.datas.Length - 1] = default(T);

            return val;
        }

        public bool IsEmpty() 
        {
            foreach (T data in this.datas) 
            {
                if (data != null && !data.Equals(default(T))) return false;
            }

            return true;
        }

        public bool Contains(T val) 
        {
            foreach (T data in this.datas) 
            {
                if (data != null && data.Equals(val)) return true;
            }

            return false;
        }

        public int ReSize()
        {
            this.initialCapacity *= 2;

            var newDatas = new T[this.initialCapacity];

            for (int i = 0; i < this.datas.Length; i += 1) 
            {
                newDatas[i] = this.datas[i];
            }

            this.datas = newDatas;

            return this.datas.Length;
        }

        public void Print() 
        {
            foreach (T data in this.datas) 
            {
                Console.Write($"{data} \t");
            }

            Console.WriteLine();
        }
    }
}
