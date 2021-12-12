using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Model
{
    public class HashTableList
    {
        private int initialSize = 16;
        private HashEntry[] Data;

        public HashTableList() 
        {
            this.Data = new HashEntry[this.initialSize];
        }

        public void Push(string key, string val) 
        {
            var newEntry = new HashEntry(key,val);

            var index = this.GetIndex(key);
            if (this.Data[index] != null) 
            {
                HashEntry current = this.Data[index];

                while (current.Next != null) 
                {
                    current = current.Next;
                }

                current.Next = newEntry;
                return;
            }

            this.Data[index] = newEntry;
        }

        public string Get(string key) 
        {
            var index = this.GetIndex(key);

            HashEntry current = this.Data[index];
            if (current == null) return null;

            while (current.Key != key && current.Next != null) 
            {
                current = current.Next;
            }

            return current.Value;
        }

        public int GetIndex(string key) 
        {
            var hashCode = key.GetHashCode();

            return Math.Abs(hashCode % this.initialSize);
        }

    }
}
