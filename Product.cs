using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{

    public enum ProductCategory
    {
        Clothing,
        Electronics,
        Home,
        Beauty,
        Groceries
    }

     internal class Product
     {
        private string name;
        private double price;
        private ProductCategory category;

        public Product(string name, double price, ProductCategory category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }
                
        

        public string Name
        {
            get { return name; } //reads
        }

        public double Price
        {
            get { return price; } //reads
        }


        public ProductCategory Category
        {
            get { return category; } //reads
        }

        public virtual void GetInfo()
        {
            Console.WriteLine("Product Name: " + name
                              + "\nProduct Price: R" + price
                              + "\nProduct Category: " + category);


        }
        
     }
}
