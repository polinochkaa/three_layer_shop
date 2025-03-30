using System;
using System.Collections;
using System.Collections.Generic;
using SSU.ThreeLayer.Entities;

namespace SSU.ThreeLayer.BLL
{
    public interface IProductLogic
    {
        void AddProduct(string name, string description, double price);
        void DeleteProduct(string name);
        Product GetProduct(string name);
        IEnumerable<Product> GetAllProducts();
        void UpdateProduct(Product product);
        IEnumerable<Product> SearchProductByName(string name);
    }
}