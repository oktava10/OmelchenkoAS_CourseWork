namespace KR_2
{
    partial class NewProduct
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
            this.nameOfProduct = new System.Windows.Forms.Label();
            this.nameOfProductTextBox = new System.Windows.Forms.TextBox();
            this.priceOfProductTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addNewProductBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameOfProduct
            // 
            this.nameOfProduct.AutoSize = true;
            this.nameOfProduct.Location = new System.Drawing.Point(12, 9);
            this.nameOfProduct.Name = "nameOfProduct";
            this.nameOfProduct.Size = new System.Drawing.Size(121, 13);
            this.nameOfProduct.TabIndex = 0;
            this.nameOfProduct.Text = "Наименование товара";
            // 
            // nameOfProductTextBox
            // 
            this.nameOfProductTextBox.Location = new System.Drawing.Point(15, 25);
            this.nameOfProductTextBox.Name = "nameOfProductTextBox";
            this.nameOfProductTextBox.Size = new System.Drawing.Size(207, 20);
            this.nameOfProductTextBox.TabIndex = 1;
            // 
            // priceOfProductTextBox
            // 
            this.priceOfProductTextBox.Location = new System.Drawing.Point(15, 79);
            this.priceOfProductTextBox.Name = "priceOfProductTextBox";
            this.priceOfProductTextBox.Size = new System.Drawing.Size(118, 20);
            this.priceOfProductTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Цена";
            // 
            // addNewProductBtn
            // 
            this.addNewProductBtn.Location = new System.Drawing.Point(147, 113);
            this.addNewProductBtn.Name = "addNewProductBtn";
            this.addNewProductBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewProductBtn.TabIndex = 4;
            this.addNewProductBtn.Text = "Добавить";
            this.addNewProductBtn.UseVisualStyleBackColor = true;
            // 
            // NewProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 147);
            this.Controls.Add(this.addNewProductBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.priceOfProductTextBox);
            this.Controls.Add(this.nameOfProductTextBox);
            this.Controls.Add(this.nameOfProduct);
            this.Name = "NewProduct";
            this.Text = "Добавить товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameOfProduct;
        private System.Windows.Forms.TextBox nameOfProductTextBox;
        private System.Windows.Forms.TextBox priceOfProductTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addNewProductBtn;
    }
}