using System;
using System.Collections.Generic;
using System.Linq;
using SSU.ThreeLayer.DAL;
using SSU.ThreeLayer.Entities;

namespace SSU.ThreeLayer.BLL
{
    public class SaleLogic : ISaleLogic
    {
        private readonly IBaseSales baseSales;

        public SaleLogic(IBaseSales baseSales)
        {
            this.baseSales = baseSales;
        }

        public void AddSale(string name, DateTime startDate, DateTime endDate, List<Product> products)
        {
            baseSales.AddSale(new Sale(name, startDate, endDate, products));
        }

        public void DeleteSale(string name)
        {
            baseSales.DeleteSale(name);
        }

        public Sale GetSale(string name)
        {
            return baseSales.GetSale(name);
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return baseSales.GetAllSales();
        }

        public IEnumerable<Sale> SearchSales(DateTime date)
        {
            return baseSales.SearchSales(date);
        }

        public void UpdateSaleStatus(IProductLogic productLogic)
        {
            var allProducts = productLogic.GetAllProducts().ToList();
            var currentSales = GetAllSales();

            foreach (var product in allProducts)
            {
                product.OnSale = currentSales.Any(sale => sale.Products.Contains(product));
                
            }
        }
    }
}
