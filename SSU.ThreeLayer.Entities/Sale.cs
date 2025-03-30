using System;
using System.Collections.Generic;

namespace SSU.ThreeLayer.Entities
{
    [Serializable]
    public class Sale
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Product> Products { get; set; }
        
        public Sale(string name, DateTime startDate, DateTime endDate, List<Product> products)
        {
            Name = name;
            StartDate = startDate;
            EndDate = endDate;
            Products = products ?? new List<Product>();
        }

        public override string ToString()
        {
            return $"{Name} ( {StartDate.ToShortDateString()} -- {EndDate.ToShortDateString()} )";
        }
    }
}
