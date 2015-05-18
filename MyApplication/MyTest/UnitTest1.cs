using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void shouldAddProductToList()
        {
            MyApplication.Product product = new MyApplication.Product(5.0f, "product1Name");
            MyApplication.Cart cart = new MyApplication.Cart();
            cart.AddNewProduct(5.0f, "product1Name");
            Assert.IsTrue(cart.MyProduct[0].equals(product));
        }
        [TestMethod]
        public void shouldAddMultipleProductToList()
        {
            MyApplication.Product product1 = new MyApplication.Product(5.0f, "product1Name");
            MyApplication.Product product2 = new MyApplication.Product(5.0f, "product2Name");
            MyApplication.Product product3 = new MyApplication.Product(5.0f, "product3Name");
            MyApplication.Cart cart = new MyApplication.Cart();
            cart.AddNewProduct(5.0f, "product1Name");
            cart.AddNewProduct(5.0f, "product2Name");
            cart.AddNewProduct(5.0f, "product3Name");
            Assert.IsTrue(cart.MyProduct[0].equals(product1));
            Assert.IsTrue(cart.MyProduct[1].equals(product2));
            Assert.IsTrue(cart.MyProduct[2].equals(product3));
        }
        [TestMethod]
        public void shouldAddNumberOfProducts()
        {
            MyApplication.Product product = new MyApplication.Product(5.0f, "product1Name");
            MyApplication.Cart cart = new MyApplication.Cart();
            int quantity = 2;
            cart.AddNewProducts(product, quantity);
            for (int i = 0; i < cart.MyProduct.Count; i++)
            {
                Assert.IsTrue(cart.MyProduct[i].equals(product));
            }
        }
      
        [TestMethod]
        public void shouldClearCart()
         {
             MyApplication.Product product1 = new MyApplication.Product(5.0f, "product1Name");
             MyApplication.Product product2 = new MyApplication.Product(5.0f, "product2Name");
             MyApplication.Product product3 = new MyApplication.Product(5.0f, "product3Name");
             MyApplication.Cart cart = new MyApplication.Cart();
             cart.AddNewProduct(5.0f, "product1Name");
             cart.AddNewProduct(5.0f, "product2Name");
             cart.AddNewProduct(5.0f, "product3Name");
             cart.clearCart();
             Assert.AreEqual(0, cart.MyProduct.Count);
         }
        [TestMethod]
        public void shouldRemoveSpecifiedProduct()
        {
            MyApplication.Product product1 = new MyApplication.Product(5.0f, "product1Name");
            MyApplication.Product product2 = new MyApplication.Product(5.0f, "product2Name");
            MyApplication.Product product3 = new MyApplication.Product(5.0f, "product3Name");
            MyApplication.Cart cart = new MyApplication.Cart();
            cart.AddNewProduct(5.0f, "product1Name");
            cart.AddNewProduct(5.0f, "product2Name");
            cart.AddNewProduct(5.0f, "product3Name");
            cart.RemoveSpecifiedProduct("product2Name");
            for(int i = 0 ; i < cart.MyProduct.Count; i ++){
                Assert.AreNotEqual(cart.MyProduct[i].Name, "product2Name");
             }
        }
    }
}
