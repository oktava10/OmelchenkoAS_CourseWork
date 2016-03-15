namespace KR_2
{
    partial class Products
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.CodeOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addNewProductBtn = new System.Windows.Forms.Button();
            this.removeProductBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priceOfProductTextBox = new System.Windows.Forms.TextBox();
            this.nameOfProductTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productDataGridView
            // 
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeOfProduct,
            this.NameOfProduct,
            this.PriceOfProduct});
            this.productDataGridView.Location = new System.Drawing.Point(12, 12);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.Size = new System.Drawing.Size(427, 221);
            this.productDataGridView.TabIndex = 0;
            // 
            // CodeOfProduct
            // 
            this.CodeOfProduct.HeaderText = "Код";
            this.CodeOfProduct.Name = "CodeOfProduct";
            this.CodeOfProduct.ReadOnly = true;
            // 
            // NameOfProduct
            // 
            this.NameOfProduct.HeaderText = "Наименование товара";
            this.NameOfProduct.Name = "NameOfProduct";
            this.NameOfProduct.ReadOnly = true;
            this.NameOfProduct.Width = 180;
            // 
            // PriceOfProduct
            // 
            this.PriceOfProduct.HeaderText = "Цена";
            this.PriceOfProduct.Name = "PriceOfProduct";
            this.PriceOfProduct.ReadOnly = true;
            // 
            // addNewProductBtn
            // 
            this.addNewProductBtn.Location = new System.Drawing.Point(283, 312);
            this.addNewProductBtn.Name = "addNewProductBtn";
            this.addNewProductBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewProductBtn.TabIndex = 1;
            this.addNewProductBtn.Text = "Добавить";
            this.addNewProductBtn.UseVisualStyleBackColor = true;
            this.addNewProductBtn.Click += new System.EventHandler(this.addNewProductBtn_Click);
            // 
            // removeProductBtn
            // 
            this.removeProductBtn.Location = new System.Drawing.Point(364, 312);
            this.removeProductBtn.Name = "removeProductBtn";
            this.removeProductBtn.Size = new System.Drawing.Size(75, 23);
            this.removeProductBtn.TabIndex = 2;
            this.removeProductBtn.Text = "Удалить";
            this.removeProductBtn.UseVisualStyleBackColor = true;
            this.removeProductBtn.Click += new System.EventHandler(this.removeProductBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Цена";
            // 
            // priceOfProductTextBox
            // 
            this.priceOfProductTextBox.Location = new System.Drawing.Point(15, 312);
            this.priceOfProductTextBox.Name = "priceOfProductTextBox";
            this.priceOfProductTextBox.Size = new System.Drawing.Size(118, 20);
            this.priceOfProductTextBox.TabIndex = 6;
            // 
            // nameOfProductTextBox
            // 
            this.nameOfProductTextBox.Location = new System.Drawing.Point(15, 264);
            this.nameOfProductTextBox.Name = "nameOfProductTextBox";
            this.nameOfProductTextBox.Size = new System.Drawing.Size(207, 20);
            this.nameOfProductTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Наименование товара";
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceOfProductTextBox);
            this.Controls.Add(this.nameOfProductTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.removeProductBtn);
            this.Controls.Add(this.addNewProductBtn);
            this.Controls.Add(this.productDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Products";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.Button addNewProductBtn;
        private System.Windows.Forms.Button removeProductBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOfProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priceOfProductTextBox;
        private System.Windows.Forms.TextBox nameOfProductTextBox;
        private System.Windows.Forms.Label label2;
    }
}