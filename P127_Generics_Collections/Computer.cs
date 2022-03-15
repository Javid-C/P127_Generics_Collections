using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace P127_Generics_Collections
{
    class Computer:ICollection
    {
        public int Id;
        public string Model;
        public byte Ram;
        public short Memory;

        public static int count = 1;

        public int Count => throw new NotImplementedException();

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

        public Computer(string model, byte ram, short memory)
        {
            Id = count;
            Model = model;
            Ram = ram;
            Memory = memory;
            count++;
        }

        public override string ToString()
        {
            return $"Model: {Model}, Ram: {Ram}, Memory: {Memory}";
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
