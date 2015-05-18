using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    class Program
    {
        static string name;
        static int quantity;
        static void Main(string[] args)
        {
            Cart myCart = new Cart();
            MyApplication.Product product1 = new MyApplication.Product(3.0f, "potato");
            MyApplication.Product product2 = new MyApplication.Product(4.5f, "pear");
            MyApplication.Product product3 = new MyApplication.Product(6.67f, "apple");
            string x = "", y = "";
            bool isEnd = false;
            Console.WriteLine("Hello,please select product:");
            Console.WriteLine("Write \"potato\" if you want to add potato");
            Console.WriteLine("Write \"pear\" if you want to add pear:");
            Console.WriteLine("Write \"apple\" if you want to add apple:");
            Console.WriteLine("Write \"potato,quantity\" if you want to add potato");
            Console.WriteLine("Write \"pear,quantity\" if you want to add pear:");
            Console.WriteLine("Write \"apple,quantity\" if you want to add apple:");
            Console.WriteLine("\"Quantity\" is a number of products with you are ordering.");
            Console.WriteLine("Press 1 if you want to see summary.");
            Console.WriteLine("Press 2 to clear cart.");
            Console.WriteLine("Press 3 to end shopping.");
            Console.WriteLine("Press 4 to remove specified product.");
            do
            {
                x = "";
                x = Convert.ToString(Console.ReadLine());
                ResolveString(x);
                switch (name)
                {
                    case "potato":
                        if (quantity == 1) { 
                        myCart.AddNewProduct(product1.Price, product1.Name);
                          }
                        else
                        {
                         myCart.AddNewProducts(product1, quantity);
                        }
                        break;
                    case "pear":
                        if (quantity == 1)
                        {
                            myCart.AddNewProduct(product2.Price, product2.Name);
                        }
                        else
                        {
                            myCart.AddNewProducts(product2, quantity);
                        }
                        break;
                    case "apple":
                        if (quantity == 1)
                        {
                            myCart.AddNewProduct(product3.Price, product3.Name);
                        }
                        else
                        {
                            myCart.AddNewProducts(product3, quantity);
                        }
                        break;
                    case "1":
                        myCart.summary();
                        break;
                    case "2":
                        myCart.clearCart();
                        break;
                    case "3":
                        isEnd = true;
                        break;
                    case "4":
                        Console.WriteLine("Write product to remove");
                         y = "";
                         y = Convert.ToString(Console.ReadLine());
                         myCart.RemoveSpecifiedProduct(y);
                        break;
                    default:
                        Console.WriteLine("Invalid data. Please,try again.");
                        break;
                }
            } while (isEnd ==false);
        }
        static void ResolveString(string information)
        {

            String[] informations = new String[2];
            if(information.Contains(","))
            {
              informations = information.Split(',');
              quantity =Convert.ToInt32(informations[1]);
              name = informations[0];
            }
            else
            {
                name = information;
                quantity = 1;
            }
        }
    }
}
