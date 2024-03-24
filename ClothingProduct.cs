using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ShoppingCartApp 
{
    internal class ClothingProduct : Product
    {

        private string size;
        private string color;


        public ClothingProduct(string name, double price, ProductCategory category, string size, string color) : base(name, price, category)
        {
            this.size = size;
            this.color = color;

        }


        public string Size
        {
            get { return size; }
        }

        public string Color
        {
            get { return color; }
        }

        public override void GetInfo()
        {
            Console.WriteLine( "\nClothing Size: " + size
                              + "\nClothing Color: " + color);


        }

        /*
         
         
        public override void GetInfo()
        {
            Console.WriteLine("Product Name: " + Name
                              + "\nProduct Price: R" + Price
                              + "\nProduct Category: " + Category
                              + "\nClothing Size: " + size
                              + "\nClothing Color: " + color);


        }


        */


    }
}
