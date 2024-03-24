using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApp
{
    internal class ElectronicsProduct : Product
    {
        private string brand;
        private string model;

        public ElectronicsProduct(string name, double price, ProductCategory category, string brand, string model) : base(name, price, category)
        {
            this.brand = brand;
            this.model = model; 

        }

        public string Brand
        {
            get { return brand; }
        }

        public string Model
        {
            get { return model; }
        }

        public override void GetInfo()
        {
            Console.WriteLine( "\nElectronics Product Brand: " + brand
                              + "\nElectronics Product Model: " + model);


        }
        /*
         
         
        public override void GetInfo()
        {
            Console.WriteLine("Product Name: " + Name
                              + "\nProduct Price: R" + Price
                              + "\nProduct Category: " + Category
                              + "\nElectronics Product Brand: " + brand
                              + "\nElectronics Product Model: " + model);


        }


        */


    }
}
