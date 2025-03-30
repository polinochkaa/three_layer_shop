using SSU.ThreeLayer.BLL;
using SSU.ThreeLayer.Common;
using SSU.ThreeLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SSU.ThreeLayer
{
    class Program
    {
        static void Main(string[] args)
        {

            IProductLogic productLogic = DependencyResolver.ProductLogic;
            ISaleLogic saleLogic = DependencyResolver.SaleLogic;

            Console.WriteLine("Исходная выгрузка продуктов:");
            ShowProducts(productLogic);

            //productLogic.AddProduct("Телевизор", "Телевизор с диагональю 42 дюйма", 50000);
            //productLogic.AddProduct("Холодильник", "Двухкамерный холодильник", 30000);
            //productLogic.AddProduct("Микроволновка", "Микроволновая печь", 8000);

            Console.WriteLine("\nПосле добавления продуктов:");
            ShowProducts(productLogic);

            List<int> tvAndFridgeIds = new List<int> { 1, 2 }; // Допустим, что у телевизора ID 1, у холодильника ID 2
            List<int> microwaveIds = new List<int> { 3 }; // Допустим, что у микроволновки ID 3

            //saleLogic.AddSale("Скидка на телевизоры и холодильники", new DateTime(2024, 6, 1), new DateTime(2024, 6, 30), tvAndFridgeIds);
            //saleLogic.AddSale("Скидка на микроволновки", new DateTime(2024, 7, 1), new DateTime(2024, 7, 31), microwaveIds);

            saleLogic.UpdateSaleStatus(productLogic);

            Console.WriteLine("\nТекущие акции:");
            ShowSales(saleLogic);

            Console.WriteLine("\nАкционные товары:");
            ShowPromotionalProducts(productLogic);

           // productLogic.DeleteProduct(2); // Удаляем холодильник

            Console.WriteLine("\nПосле удаления продукта:");
            ShowProducts(productLogic);

           // saleLogic.DeleteSale(1); // Удаляем первую акцию

            //saleLogic.UpdateSaleStatus(productLogic);

            Console.WriteLine("\nПосле удаления акции:");
            ShowSales(saleLogic);
            Console.WriteLine("\nАкционные товары:");
            ShowPromotionalProducts(productLogic);

            Console.WriteLine("\nПоиск товара по названию 'Телевизор':");
            ShowProducts(productLogic.SearchProductByName("Телевизор"));

            Console.WriteLine("\nПоиск акции по дате '2024-07-15':");
            ShowSales(saleLogic.SearchSales(new DateTime(2024, 7, 15)));
        }

        static void ShowProducts(IEnumerable<Product> products)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
        static void ShowSales(IEnumerable<Sale> sales)
        {
            foreach (var sale in sales)
            {
                Console.WriteLine(sale);
            }
        }
        static void ShowProducts(IProductLogic productLogic)
        {
            int i = 1;
            foreach (Product product in productLogic.GetAllProducts())
            {
                Console.WriteLine($"№{i} - {product}");
                i++;
            }
        }

        static void ShowSales(ISaleLogic saleLogic)
        {
            int i = 1;
            foreach (Sale sale in saleLogic.GetAllSales())
            {
                Console.WriteLine($"№{i} - {sale}");
                i++;
            }
        }

        static void ShowPromotionalProducts(IProductLogic productLogic)
        {
            int i = 1;
            foreach (Product product in productLogic.GetAllProducts())
            {
                if (product.OnSale)
                {
                    Console.WriteLine($"№{i} - {product}");
                    i++;
                }
            }
        }
    }
}
