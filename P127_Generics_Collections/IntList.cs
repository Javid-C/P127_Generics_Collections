using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Generics_Collections
{
    class IntList
    {
        private int[] arr;

        public int Count
        {
            get
            {
                return arr.Length;
            }
        }

        public IntList()
        {
            arr = new int[0];
        }

        public void Add(int number)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = number;
        }

        public int[] GetArray()
        {
            return arr;
        }
    }
}
