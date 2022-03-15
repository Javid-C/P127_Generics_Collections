using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Generics_Collections
{
    class SuperMarket<T,U> /*where T: class,U*/
    {
        private T[] Prices;
        private U[] Products;

        public SuperMarket()
        {
            Prices = new T[0];
            Products = new U[0];
        }

        public void Add(T price, U name)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = name;

            Array.Resize(ref Prices, Prices.Length + 1);
            Prices[Prices.Length - 1] = price;
        }

        public U[] GetNames()
        {
            return Products; 
        }

        public T[] GetPrices()
        {
            return Prices;
        }
    }
}
