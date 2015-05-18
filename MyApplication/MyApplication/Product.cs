using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    public class Product
    {
        #region Properties
        private float price;

        public float Price
        {
            get { return price; }
            set { price = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion 
        public Product(float _price, string _name)
        {
            this.price = _price;
            this.name = _name;
        }
        public Boolean equals(Object otherProduct)
        {
            Product product = (Product)otherProduct;
            return this.name == product.Name && this.price == product.Price;
        }
        
    }
}
