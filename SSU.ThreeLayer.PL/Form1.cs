using SSU.ThreeLayer.BLL;
using SSU.ThreeLayer.Common;
using SSU.ThreeLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace SSU.ThreeLayer.PL
{
    public partial class Form1 : Form
    {
        IProductLogic productLogic = DependencyResolver.ProductLogic;
        ISaleLogic saleLogic = DependencyResolver.SaleLogic;


        public Form1()
        {
            InitializeComponent();
            
            foreach (Product product in productLogic.GetAllProducts())
            {
                ProductList.Items.Add(product.Name);
            }
            foreach (Sale sale in saleLogic.GetAllSales())
            {
                SaleList.Items.Add(sale.Name);
            }
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProductList.SelectedIndex != -1)
            {
                string selectedProductName = ProductList.SelectedItem.ToString();
                Product selectedProduct = productLogic.GetProduct(selectedProductName);
                string text = selectedProduct.Price.ToString();
                text += " руб\n\n";
                text += selectedProduct.Description;
                Description.Text = text;
                
            }
        }

        private void SaleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SaleList.SelectedIndex != -1)
            {
                string selectedSaleName = SaleList.SelectedItem.ToString();
                Sale selectedSale = saleLogic.GetSale(selectedSaleName);
                string text = selectedSale.StartDate.ToShortDateString();
                text += " - ";
                text += selectedSale.EndDate.ToShortDateString();
                text += "\n\n";
                text += selectedSale.Name;
                text += "\n\nАкционные товары:\n";
                
                foreach(Product product in selectedSale.Products)
                {
                    text += product.Name;
                    text += "\n";
                }
                
                Description.Text = text;

            }
        }

        private void ShowPromotionalProducts_Click(object sender, EventArgs e)
        {
            ProductList.Items.Clear();
            foreach (Product product in productLogic.GetAllProducts())
            {
                if (product.OnSale == true)
                    ProductList.Items.Add(product.Name);
            }
        }
        private void ShowAllProducts_Click(object sender, EventArgs e)
        {
            ProductList.Items.Clear();
            foreach (Product product in productLogic.GetAllProducts())
            {
                ProductList.Items.Add(product.Name);
            }
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            string productName = ProductNameText.Text;
            string productDescription = ProductDescriptionText.Text;
            double productPrice = double.Parse(ProductPriceText.Text);
            productLogic.AddProduct(productName, productDescription, productPrice);
            ProductList.Items.Clear();
            foreach (Product product in productLogic.GetAllProducts())
            {
                ProductList.Items.Add(product.Name);
            }
            
        }
        private void DeleteProduct_Click(object sender, EventArgs e)
        {
            string selectedProductName = ProductList.SelectedItem.ToString();
            Product selectedProduct = productLogic.GetProduct(selectedProductName);
            foreach(Sale sale in saleLogic.GetAllSales())
            {
                if (sale.Products.Contains(selectedProduct))
                {
                    sale.Products.Remove(selectedProduct);
                }
                
            }
            SaleList.Items.Clear();
            
            foreach (Sale sale in saleLogic.GetAllSales())
            {
                SaleList.Items.Add(sale.Name);
            }

            productLogic.DeleteProduct(selectedProductName);
            ProductList.Items.Clear();
            foreach (Product product in productLogic.GetAllProducts())
            {
                ProductList.Items.Add(product.Name);
            }
            Description.Text = "";

        }
        private void AddSale_Click(object sender, EventArgs e)
        {
            string saleName = SaleDescriptionText.Text;
            DateTime saleStart = DateTime.Parse(StartDateText.Text);
            DateTime saleEnd = DateTime.Parse(EndDateText.Text);
            List<Product> promotionalProducts = new List<Product>();
            foreach(var item in ProductList.SelectedItems)
            {
                string promotionalProductsName = item.ToString();
                promotionalProducts.Add(productLogic.GetProduct(promotionalProductsName));
            }
            saleLogic.AddSale(saleName, saleStart, saleEnd, promotionalProducts);
            saleLogic.UpdateSaleStatus(productLogic);
            
            
            SaleList.Items.Clear();
            foreach (Sale sale in saleLogic.GetAllSales())
            {
                SaleList.Items.Add(sale.Name);
            }

        }

        private void DeleteSale_Click(object sender, EventArgs e)
        {
            string selectedSaleName =SaleList.SelectedItem.ToString();
            

            saleLogic.DeleteSale(selectedSaleName);
            SaleList.Items.Clear();
            foreach (Sale sale in saleLogic.GetAllSales())
            {
                ProductList.Items.Add(sale.Name);
            }
            Description.Text = "";
        }

        private void ChangeSelectionMode_Click(object sender, EventArgs e)
        {

            if (ProductList.SelectionMode == SelectionMode.MultiSimple)
            {
                ProductList.SelectionMode = SelectionMode.One;
                ChangeSelectionMode.Text = "Выбрать несколько";
            }
            else
            {
                ProductList.SelectionMode = SelectionMode.MultiSimple;
                ChangeSelectionMode.Text = "Выбрать один";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            string name = SearchProductText.Text;
            List<Product> searchProducts = productLogic.SearchProductByName(name).ToList();
            ProductList.Items.Clear();
            foreach (Product product in searchProducts)
            {
                ProductList.Items.Add(product.Name);
            }
        }

        private void SearchSaleButton_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(SearchSaleText.Text);
            List<Sale> searchSales = saleLogic.SearchSales(date).ToList();
            SaleList.Items.Clear();
            foreach (Sale sale in searchSales)
            {
                SaleList.Items.Add(sale.Name);
            }
        }

        private void ShowAllSales_Click(object sender, EventArgs e)
        {
            SaleList.Items.Clear();
            foreach (Sale sale in saleLogic.GetAllSales())
            {
                SaleList.Items.Add(sale.Name);
            }
        }
    }
}
