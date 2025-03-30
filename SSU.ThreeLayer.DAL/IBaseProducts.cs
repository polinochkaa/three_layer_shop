using System;
using System.Collections;
using System.Collections.Generic;
using SSU.ThreeLayer.Entities;

namespace SSU.ThreeLayer.DAL
{
    public interface IBaseProducts
    {
        void AddProduct(Product product);
        void DeleteProduct(string name);
        Product GetProduct(string name);
        IEnumerable<Product> GetAllProducts();
        void UpdateProduct(Product product);
        IEnumerable<Product> SearchProductByName(string name);
    }
}