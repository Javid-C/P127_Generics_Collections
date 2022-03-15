using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Generics_Collections
{
    class Item<T>
    {
        #region Worst case
        //public int Quality;
        //public string _Quality;
        //public char _quality;

        //public Item(int quality)
        //{
        //    Quality = quality;
        //}
        //public Item(string quality)
        //{
        //    _Quality = quality;
        //}
        //public Item(char quality)
        //{
        //    _quality = quality;
        //}
        #endregion

        public T Quality;

        public Item(T quality)
        {
            Quality = quality;
        }

    }
}
