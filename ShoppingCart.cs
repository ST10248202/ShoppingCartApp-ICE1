using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class ShoppingCart
    {

        private Product[] product;
        private int itemCount;

        public ShoppingCart(int capacity)
        {
            product = new Product[capacity];
            itemCount = 0;
        }

        public Product[] Products
        {
            get { return product; }
        }

        public int ItemCount
        {
            get { return itemCount; }
        }

        public void AddProduct(Product product)
        {
            if (itemCount < Products.Length)
            {
                Products[itemCount++] = product;
            }
            else
            {
                Console.WriteLine("The cart is full. Cannot add more products.");
            }
        }

        public void RemoveProduct(Product product)
        {
            for (int i = 0; i < itemCount; i++)
            {
                if (Products[i] == product)
                {
                    for (int j = i; j < itemCount - 1; j++)
                    {
                        Products[j] = Products[j + 1];
                    }
                    itemCount--;
                    break;
                }
            }





        }
    }
}
