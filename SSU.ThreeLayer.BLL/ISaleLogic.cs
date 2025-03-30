using System;
using System.Collections.Generic;
using SSU.ThreeLayer.Entities;

namespace SSU.ThreeLayer.BLL
{
    public interface ISaleLogic
    {
        void AddSale(string name, DateTime startDate, DateTime endDate, List<Product> productIds);
        void DeleteSale(string name);
        Sale GetSale(string name);
        IEnumerable<Sale> GetAllSales();
        IEnumerable<Sale> SearchSales(DateTime date);
        void UpdateSaleStatus(IProductLogic productLogic);
    }
}
