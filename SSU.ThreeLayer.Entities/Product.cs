using System;

namespace SSU.ThreeLayer.Entities
{
    [Serializable]
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public bool OnSale { get; set; }

        public Product(string name, string description, double price)
        {
            Name = name;
            Description = description;
            Price = price;
            OnSale = false;
        }

        public override string ToString()
        {
            return $"{Name} - {Description}, Цена: {Price} руб";
        }
    }
}
