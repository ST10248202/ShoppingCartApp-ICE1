using ShoppingCartApp;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            ShoppingCart cart1 = new ShoppingCart(10);
            ClothingProduct shirt = new ClothingProduct("Shirt", 60.00, ProductCategory.Clothing, "L", "Yellow");
            ElectronicsProduct watch = new ElectronicsProduct("Smart Watch", 2999.99, ProductCategory.Electronics, "Samsung", "Galaxy Gear S3 Frontier");
            cart1.AddProduct(shirt);
            cart1.AddProduct(watch);

            

            Console.WriteLine("Do you want to display cart contents? (yes/no)");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "yes")
            {
                Console.WriteLine("Cart contents:");
                foreach (Product product in cart1.Products)
                {
                    if (product != null)
                    {
                        product.GetInfo();
                    }
                }
            }











        }
    }
}
