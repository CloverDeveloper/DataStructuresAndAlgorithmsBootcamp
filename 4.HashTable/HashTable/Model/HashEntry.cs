using System;
using System.Collections.Generic;
using System.Text;

namespace HashTable.Model
{
    public class HashEntry
    {
        public string Key;

        public string Value;

        public HashEntry Next;

        public HashEntry(string key, string val) 
        {
            this.Key = key;
            this.Value = val;
            this.Next = null;
        }
    }
}
