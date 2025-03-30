using SSU.ThreeLayer.DAL;
using SSU.ThreeLayer.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSU.ThreeLayer.BLL
{
    public class ProductLogic : IProductLogic
    {
        private readonly IBaseProducts baseProducts;

        public ProductLogic(IBaseProducts baseProducts)
        {
            this.baseProducts = baseProducts;
        }

        public void AddProduct(string name, string description, double price)
        {
            baseProducts.AddProduct(new Product(name, description, price));
        }

        public void DeleteProduct(string name)
        {
            baseProducts.DeleteProduct(name);
        }

        public Product GetProduct(string name)
        {
            return baseProducts.GetProduct(name);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return baseProducts.GetAllProducts();
        }

        public void UpdateProduct(Product product)
        {
            baseProducts.UpdateProduct(product); 
        }

        public IEnumerable<Product> SearchProductByName(string name)
        {
            return baseProducts.SearchProductByName(name);
        }
    }
}
