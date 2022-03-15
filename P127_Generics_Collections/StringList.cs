using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Generics_Collections
{
    class StringList
    {
        private string[] arr;

        public int Count
        {
            get
            {
                return arr.Length;
            }
        }

        public StringList()
        {
            arr = new string[0];
        }

        public void Add(string word)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = word;
        }

        public string[] GetArray()
        {
            return arr;
        }
    }
}
