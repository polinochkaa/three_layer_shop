namespace SSU.ThreeLayer.PL
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ProductList = new System.Windows.Forms.ListBox();
            this.SaleList = new System.Windows.Forms.ListBox();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.DeleteProduct = new System.Windows.Forms.Button();
            this.AddSale = new System.Windows.Forms.Button();
            this.DeleteSale = new System.Windows.Forms.Button();
            this.ShowAllProducts = new System.Windows.Forms.Button();
            this.ProductNameText = new System.Windows.Forms.TextBox();
            this.SaleDescriptionText = new System.Windows.Forms.TextBox();
            this.StartDateText = new System.Windows.Forms.MaskedTextBox();
            this.EndDateText = new System.Windows.Forms.MaskedTextBox();
            this.ProductPriceText = new System.Windows.Forms.TextBox();
            this.ProductDescriptionText = new System.Windows.Forms.TextBox();
            this.ChangeSelectionMode = new System.Windows.Forms.Button();
            this.SearchProductText = new System.Windows.Forms.TextBox();
            this.SearchSaleText = new System.Windows.Forms.MaskedTextBox();
            this.SearchProductButton = new System.Windows.Forms.Button();
            this.SearchSaleButton = new System.Windows.Forms.Button();
            this.ShowAllSales = new System.Windows.Forms.Button();
            this.ShowPromotionalProducts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.ItemHeight = 16;
            this.ProductList.Location = new System.Drawing.Point(27, 44);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(276, 260);
            this.ProductList.TabIndex = 0;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // SaleList
            // 
            this.SaleList.FormattingEnabled = true;
            this.SaleList.ItemHeight = 16;
            this.SaleList.Location = new System.Drawing.Point(591, 44);
            this.SaleList.Name = "SaleList";
            this.SaleList.Size = new System.Drawing.Size(276, 260);
            this.SaleList.TabIndex = 1;
            this.SaleList.SelectedIndexChanged += new System.EventHandler(this.SaleList_SelectedIndexChanged);
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(309, 44);
            this.Description.Name = "Description";
            this.Description.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.Description.Size = new System.Drawing.Size(276, 260);
            this.Description.TabIndex = 2;
            this.Description.Text = "";
            // 
            // AddProduct
            // 
            this.AddProduct.Location = new System.Drawing.Point(36, 462);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(137, 23);
            this.AddProduct.TabIndex = 3;
            this.AddProduct.Text = "Добавить товар";
            this.AddProduct.UseVisualStyleBackColor = true;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Location = new System.Drawing.Point(377, 333);
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(137, 23);
            this.DeleteProduct.TabIndex = 4;
            this.DeleteProduct.Text = "Удалить товар";
            this.DeleteProduct.UseVisualStyleBackColor = true;
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // AddSale
            // 
            this.AddSale.Location = new System.Drawing.Point(36, 552);
            this.AddSale.Name = "AddSale";
            this.AddSale.Size = new System.Drawing.Size(137, 23);
            this.AddSale.TabIndex = 5;
            this.AddSale.Text = "Добавить акцию";
            this.AddSale.UseVisualStyleBackColor = true;
            this.AddSale.Click += new System.EventHandler(this.AddSale_Click);
            // 
            // DeleteSale
            // 
            this.DeleteSale.Location = new System.Drawing.Point(377, 362);
            this.DeleteSale.Name = "DeleteSale";
            this.DeleteSale.Size = new System.Drawing.Size(137, 23);
            this.DeleteSale.TabIndex = 6;
            this.DeleteSale.Text = "Удалить акцию";
            this.DeleteSale.UseVisualStyleBackColor = true;
            this.DeleteSale.Click += new System.EventHandler(this.DeleteSale_Click);
            // 
            // ShowAllProducts
            // 
            this.ShowAllProducts.Location = new System.Drawing.Point(27, 362);
            this.ShowAllProducts.Name = "ShowAllProducts";
            this.ShowAllProducts.Size = new System.Drawing.Size(276, 23);
            this.ShowAllProducts.TabIndex = 8;
            this.ShowAllProducts.Text = "Показать все товары";
            this.ShowAllProducts.UseVisualStyleBackColor = true;
            this.ShowAllProducts.Click += new System.EventHandler(this.ShowAllProducts_Click);
            // 
            // ProductNameText
            // 
            this.ProductNameText.Location = new System.Drawing.Point(36, 425);
            this.ProductNameText.Name = "ProductNameText";
            this.ProductNameText.Size = new System.Drawing.Size(137, 22);
            this.ProductNameText.TabIndex = 9;
            this.ProductNameText.Text = "Название товара";
            // 
            // SaleDescriptionText
            // 
            this.SaleDescriptionText.Location = new System.Drawing.Point(36, 514);
            this.SaleDescriptionText.Name = "SaleDescriptionText";
            this.SaleDescriptionText.Size = new System.Drawing.Size(137, 22);
            this.SaleDescriptionText.TabIndex = 10;
            this.SaleDescriptionText.Text = "Название акции";
            // 
            // StartDateText
            // 
            this.StartDateText.Location = new System.Drawing.Point(203, 514);
            this.StartDateText.Mask = "00/00/0000";
            this.StartDateText.Name = "StartDateText";
            this.StartDateText.Size = new System.Drawing.Size(100, 22);
            this.StartDateText.TabIndex = 11;
            // 
            // EndDateText
            // 
            this.EndDateText.Location = new System.Drawing.Point(331, 514);
            this.EndDateText.Mask = "00/00/0000";
            this.EndDateText.Name = "EndDateText";
            this.EndDateText.Size = new System.Drawing.Size(100, 22);
            this.EndDateText.TabIndex = 12;
            // 
            // ProductPriceText
            // 
            this.ProductPriceText.Location = new System.Drawing.Point(203, 425);
            this.ProductPriceText.Name = "ProductPriceText";
            this.ProductPriceText.Size = new System.Drawing.Size(137, 22);
            this.ProductPriceText.TabIndex = 13;
            this.ProductPriceText.Text = "Цена товара";
            // 
            // ProductDescriptionText
            // 
            this.ProductDescriptionText.Location = new System.Drawing.Point(377, 425);
            this.ProductDescriptionText.Name = "ProductDescriptionText";
            this.ProductDescriptionText.Size = new System.Drawing.Size(137, 22);
            this.ProductDescriptionText.TabIndex = 14;
            this.ProductDescriptionText.Text = "Описание товара";
            // 
            // ChangeSelectionMode
            // 
            this.ChangeSelectionMode.Location = new System.Drawing.Point(27, 15);
            this.ChangeSelectionMode.Name = "ChangeSelectionMode";
            this.ChangeSelectionMode.Size = new System.Drawing.Size(203, 23);
            this.ChangeSelectionMode.TabIndex = 15;
            this.ChangeSelectionMode.Text = "Выбрать несколько";
            this.ChangeSelectionMode.UseVisualStyleBackColor = true;
            this.ChangeSelectionMode.Click += new System.EventHandler(this.ChangeSelectionMode_Click);
            // 
            // SearchProductText
            // 
            this.SearchProductText.Location = new System.Drawing.Point(692, 405);
            this.SearchProductText.Name = "SearchProductText";
            this.SearchProductText.Size = new System.Drawing.Size(175, 22);
            this.SearchProductText.TabIndex = 16;
            // 
            // SearchSaleText
            // 
            this.SearchSaleText.Location = new System.Drawing.Point(767, 494);
            this.SearchSaleText.Mask = "00/00/0000";
            this.SearchSaleText.Name = "SearchSaleText";
            this.SearchSaleText.Size = new System.Drawing.Size(100, 22);
            this.SearchSaleText.TabIndex = 17;
            // 
            // SearchProductButton
            // 
            this.SearchProductButton.Location = new System.Drawing.Point(759, 433);
            this.SearchProductButton.Name = "SearchProductButton";
            this.SearchProductButton.Size = new System.Drawing.Size(108, 23);
            this.SearchProductButton.TabIndex = 18;
            this.SearchProductButton.Text = "Найти товар";
            this.SearchProductButton.UseVisualStyleBackColor = true;
            this.SearchProductButton.Click += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // SearchSaleButton
            // 
            this.SearchSaleButton.Location = new System.Drawing.Point(759, 522);
            this.SearchSaleButton.Name = "SearchSaleButton";
            this.SearchSaleButton.Size = new System.Drawing.Size(108, 23);
            this.SearchSaleButton.TabIndex = 19;
            this.SearchSaleButton.Text = "Найти акцию";
            this.SearchSaleButton.UseVisualStyleBackColor = true;
            this.SearchSaleButton.Click += new System.EventHandler(this.SearchSaleButton_Click);
            // 
            // ShowAllSales
            // 
            this.ShowAllSales.Location = new System.Drawing.Point(591, 333);
            this.ShowAllSales.Name = "ShowAllSales";
            this.ShowAllSales.Size = new System.Drawing.Size(276, 23);
            this.ShowAllSales.TabIndex = 20;
            this.ShowAllSales.Text = "Показать все акции";
            this.ShowAllSales.UseVisualStyleBackColor = true;
            this.ShowAllSales.Click += new System.EventHandler(this.ShowAllSales_Click);
            // 
            // ShowPromotionalProducts
            // 
            this.ShowPromotionalProducts.Location = new System.Drawing.Point(27, 333);
            this.ShowPromotionalProducts.Name = "ShowPromotionalProducts";
            this.ShowPromotionalProducts.Size = new System.Drawing.Size(276, 23);
            this.ShowPromotionalProducts.TabIndex = 21;
            this.ShowPromotionalProducts.Text = "Показать акционные товары";
            this.ShowPromotionalProducts.UseVisualStyleBackColor = true;
            this.ShowPromotionalProducts.Click += new System.EventHandler(this.ShowPromotionalProducts_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(914, 613);
            this.Controls.Add(this.ShowPromotionalProducts);
            this.Controls.Add(this.ShowAllSales);
            this.Controls.Add(this.SearchSaleButton);
            this.Controls.Add(this.SearchProductButton);
            this.Controls.Add(this.SearchSaleText);
            this.Controls.Add(this.SearchProductText);
            this.Controls.Add(this.ChangeSelectionMode);
            this.Controls.Add(this.ProductDescriptionText);
            this.Controls.Add(this.ProductPriceText);
            this.Controls.Add(this.EndDateText);
            this.Controls.Add(this.StartDateText);
            this.Controls.Add(this.SaleDescriptionText);
            this.Controls.Add(this.ProductNameText);
            this.Controls.Add(this.ShowAllProducts);
            this.Controls.Add(this.DeleteSale);
            this.Controls.Add(this.AddSale);
            this.Controls.Add(this.DeleteProduct);
            this.Controls.Add(this.AddProduct);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.SaleList);
            this.Controls.Add(this.ProductList);
            this.Name = "Form1";
            this.Text = "Продукты и скидки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ProductList;
        private System.Windows.Forms.ListBox SaleList;
        private System.Windows.Forms.RichTextBox Description;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button DeleteProduct;
        private System.Windows.Forms.Button AddSale;
        private System.Windows.Forms.Button DeleteSale;
        private System.Windows.Forms.Button ShowAllProducts;
        private System.Windows.Forms.TextBox ProductNameText;
        private System.Windows.Forms.TextBox SaleDescriptionText;
        private System.Windows.Forms.MaskedTextBox StartDateText;
        private System.Windows.Forms.MaskedTextBox EndDateText;
        private System.Windows.Forms.TextBox ProductPriceText;
        private System.Windows.Forms.TextBox ProductDescriptionText;
        private System.Windows.Forms.Button ChangeSelectionMode;
        private System.Windows.Forms.TextBox SearchProductText;
        private System.Windows.Forms.MaskedTextBox SearchSaleText;
        private System.Windows.Forms.Button SearchProductButton;
        private System.Windows.Forms.Button SearchSaleButton;
        private System.Windows.Forms.Button ShowAllSales;
        private System.Windows.Forms.Button ShowPromotionalProducts;
    }
}

