using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    public class Cart
    {
        #region Properties
        private List<Product> myProduct;

        public List<Product> MyProduct
        {
            get { return myProduct; }
          //  set { myProduct = value; }
        }
        #endregion
        public Cart()
        {
            myProduct = new List<Product>();
        }
        public void AddNewProduct(float price, String name)
        {
            Product product = new Product(price, name);
            myProduct.Add(product);
        }
        public void AddNewProducts(Product product, int quantity)
        {
            for(int i = 0 ; i < quantity; i ++)
            {
                myProduct.Add(product);
            }
        }
        public void summary()
        {
            float totalPrice = 0;
            for(int i = 0; i < MyProduct.Count; i ++)
            {
                totalPrice += myProduct[0].Price;
            }
            Console.WriteLine("total Price: "+ totalPrice.ToString());
            Console.WriteLine("quantity of products: "+ myProduct.Count.ToString());
        }
        public void clearCart()
        {
            myProduct.Clear();
        }
        public void RemoveSpecifiedProduct(String name)
        {
            for(int i  = 0; i < myProduct.Count;i++)
            {
                if(myProduct[i].Name == name)
                {
                    myProduct.RemoveAt(i);
                }
            }
        }
    }
}
