using System;
using System.Collections.Generic;
using SSU.ThreeLayer.Entities;

namespace SSU.ThreeLayer.DAL
{
    public interface IBaseSales
    {
        void AddSale(Sale sale);
        void DeleteSale(string name);
        Sale GetSale(string name);
        IEnumerable<Sale> GetAllSales();
        IEnumerable<Sale> SearchSales(DateTime date);
    }
}
