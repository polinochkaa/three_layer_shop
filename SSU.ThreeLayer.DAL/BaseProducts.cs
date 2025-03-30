using SSU.ThreeLayer.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Xml.Linq;

namespace SSU.ThreeLayer.DAL
{
    public class BaseProducts : IBaseProducts
    {
        private List<Product> products;

        public BaseProducts()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream f = new FileStream("products.dat", FileMode.OpenOrCreate);
            if (f.Length == 0)
            {
                products = new List<Product>();
            }
            else
            {
                products = (List<Product>)formatter.Deserialize(f);
            }
            f.Close();
        }

        ~BaseProducts()
        {
            SaveBaseProducts();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void DeleteProduct(string name)
        {
            Product deletedProduct = products.Find(x => x.Name == name);
            products.Remove(deletedProduct);
        }

        public Product GetProduct(string name)
        {
            return products.Find(x => x.Name == name);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }

        public void UpdateProduct(Product product) 
        {
            product.OnSale = true;
        }

        public IEnumerable<Product> SearchProductByName(string name)
        {
            return products.Where(product => product.Name.ToLower().Contains(name.ToLower()));
        }

        private void SaveBaseProducts()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = new FileStream("products.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(f, products);
            }
        }
    }
}
