namespace KR_2
{
    partial class AddCodeOfProduct
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
            this.addCodeOfProductDGV = new System.Windows.Forms.DataGridView();
            this.CodeOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceOfProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCodeOfProductBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addCodeOfProductDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // addCodeOfProductDGV
            // 
            this.addCodeOfProductDGV.AllowUserToAddRows = false;
            this.addCodeOfProductDGV.AllowUserToDeleteRows = false;
            this.addCodeOfProductDGV.AllowUserToResizeColumns = false;
            this.addCodeOfProductDGV.AllowUserToResizeRows = false;
            this.addCodeOfProductDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addCodeOfProductDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeOfProduct,
            this.NameOfProduct,
            this.PriceOfProduct});
            this.addCodeOfProductDGV.Location = new System.Drawing.Point(12, 12);
            this.addCodeOfProductDGV.Name = "addCodeOfProductDGV";
            this.addCodeOfProductDGV.ReadOnly = true;
            this.addCodeOfProductDGV.Size = new System.Drawing.Size(427, 221);
            this.addCodeOfProductDGV.TabIndex = 1;
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
            // addCodeOfProductBTN
            // 
            this.addCodeOfProductBTN.Location = new System.Drawing.Point(364, 247);
            this.addCodeOfProductBTN.Name = "addCodeOfProductBTN";
            this.addCodeOfProductBTN.Size = new System.Drawing.Size(75, 23);
            this.addCodeOfProductBTN.TabIndex = 2;
            this.addCodeOfProductBTN.Text = "OK";
            this.addCodeOfProductBTN.UseVisualStyleBackColor = true;
            this.addCodeOfProductBTN.Click += new System.EventHandler(this.addCodeOfProductBTN_Click);
            // 
            // AddCodeOfProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 282);
            this.Controls.Add(this.addCodeOfProductBTN);
            this.Controls.Add(this.addCodeOfProductDGV);
            this.Name = "AddCodeOfProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбрать продукт";
            ((System.ComponentModel.ISupportInitialize)(this.addCodeOfProductDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView addCodeOfProductDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameOfProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceOfProduct;
        private System.Windows.Forms.Button addCodeOfProductBTN;
    }
}