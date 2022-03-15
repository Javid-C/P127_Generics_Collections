using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Generics_Collections
{
    class ComputerList
    {
        private Computer[] arr;

        public int Count
        {
            get
            {
                return arr.Length;
            }
        }

        public ComputerList()
        {
            arr = new Computer[0];
        }

        public void Add(Computer comp)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = comp;
        }

        public Computer[] GetArray()
        {
            return arr;
        }
    }
}
