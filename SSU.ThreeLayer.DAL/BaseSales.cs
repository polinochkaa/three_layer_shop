using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using SSU.ThreeLayer.Entities;

namespace SSU.ThreeLayer.DAL
{
    public class BaseSales : IBaseSales
    {
        private List<Sale> sales; 

        public BaseSales() 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream f = new FileStream("sales.dat", FileMode.OpenOrCreate);
            if (f.Length == 0) 
            {
                sales = new List<Sale>();
            }
            else 
            {
                sales = (List<Sale>)formatter.Deserialize(f);
            }
            f.Close();
        }

        ~BaseSales()
        {
            SaveBaseSales();
        }

        public void AddSale(Sale sale)
        {
            sales.Add(sale);
        }

        public void DeleteSale(string name)
        {
            Sale deletedSale = sales.Find(x => x.Name == name);
            sales.Remove(deletedSale);
        }

        public Sale GetSale(string name)
        {
            return sales.Find(x => x.Name == name);
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return sales;
        }

        public IEnumerable<Sale> SearchSales(DateTime date)
        {
            foreach (var sale in sales)
            {
                if (sale.StartDate <= date && sale.EndDate >= date)
                {
                    yield return sale;
                }
            }
        }

        private void SaveBaseSales()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream f = new FileStream("sales.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(f, sales);
            }
        }
    }
}
