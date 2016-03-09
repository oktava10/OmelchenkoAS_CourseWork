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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.addNewProductBtn = new System.Windows.Forms.Button();
            this.removeProductBtn = new System.Windows.Forms.Button();
            this.CodeOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeOfProduct,
            this.NameOfProduct,
            this.PriceOfProduct});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(427, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // addNewProductBtn
            // 
            this.addNewProductBtn.Location = new System.Drawing.Point(283, 248);
            this.addNewProductBtn.Name = "addNewProductBtn";
            this.addNewProductBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewProductBtn.TabIndex = 1;
            this.addNewProductBtn.Text = "Добавить";
            this.addNewProductBtn.UseVisualStyleBackColor = true;
            this.addNewProductBtn.Click += new System.EventHandler(this.addNewProductBtn_Click);
            // 
            // removeProductBtn
            // 
            this.removeProductBtn.Location = new System.Drawing.Point(364, 248);
            this.removeProductBtn.Name = "removeProductBtn";
            this.removeProductBtn.Size = new System.Drawing.Size(75, 23);
            this.removeProductBtn.TabIndex = 2;
            this.removeProductBtn.Text = "Удалить";
            this.removeProductBtn.UseVisualStyleBackColor = true;
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
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 283);
            this.Controls.Add(this.removeProductBtn);
            this.Controls.Add(this.addNewProductBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Products";
            this.Text = "Товары";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addNewProductBtn;
        private System.Windows.Forms.Button removeProductBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOfProduct;
    }
}