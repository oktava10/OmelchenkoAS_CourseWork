namespace KR_2
{
    partial class ChangEntrySales
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
            this.countOfSalesTB = new System.Windows.Forms.TextBox();
            this.codeOfProductSalesTB = new System.Windows.Forms.TextBox();
            this.codeOfClientSalesTB = new System.Windows.Forms.TextBox();
            this.dateTimePickerOfSales = new System.Windows.Forms.DateTimePicker();
            this.countOfSalesLabel = new System.Windows.Forms.Label();
            this.codeOfProductLabel = new System.Windows.Forms.Label();
            this.codeOfClientLabel = new System.Windows.Forms.Label();
            this.dateOfSalesLabel = new System.Windows.Forms.Label();
            this.ChangeBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // countOfSalesTB
            // 
            this.countOfSalesTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countOfSalesTB.Location = new System.Drawing.Point(114, 77);
            this.countOfSalesTB.Name = "countOfSalesTB";
            this.countOfSalesTB.Size = new System.Drawing.Size(61, 20);
            this.countOfSalesTB.TabIndex = 19;
            // 
            // codeOfProductSalesTB
            // 
            this.codeOfProductSalesTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.codeOfProductSalesTB.Location = new System.Drawing.Point(15, 25);
            this.codeOfProductSalesTB.Name = "codeOfProductSalesTB";
            this.codeOfProductSalesTB.ReadOnly = true;
            this.codeOfProductSalesTB.Size = new System.Drawing.Size(32, 20);
            this.codeOfProductSalesTB.TabIndex = 18;
            this.codeOfProductSalesTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // codeOfClientSalesTB
            // 
            this.codeOfClientSalesTB.Cursor = System.Windows.Forms.Cursors.Default;
            this.codeOfClientSalesTB.Location = new System.Drawing.Point(15, 77);
            this.codeOfClientSalesTB.Name = "codeOfClientSalesTB";
            this.codeOfClientSalesTB.ReadOnly = true;
            this.codeOfClientSalesTB.Size = new System.Drawing.Size(32, 20);
            this.codeOfClientSalesTB.TabIndex = 17;
            this.codeOfClientSalesTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dateTimePickerOfSales
            // 
            this.dateTimePickerOfSales.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOfSales.Location = new System.Drawing.Point(114, 25);
            this.dateTimePickerOfSales.Name = "dateTimePickerOfSales";
            this.dateTimePickerOfSales.Size = new System.Drawing.Size(85, 20);
            this.dateTimePickerOfSales.TabIndex = 16;
            // 
            // countOfSalesLabel
            // 
            this.countOfSalesLabel.AutoSize = true;
            this.countOfSalesLabel.Location = new System.Drawing.Point(111, 61);
            this.countOfSalesLabel.Name = "countOfSalesLabel";
            this.countOfSalesLabel.Size = new System.Drawing.Size(66, 13);
            this.countOfSalesLabel.TabIndex = 15;
            this.countOfSalesLabel.Text = "Количество";
            // 
            // codeOfProductLabel
            // 
            this.codeOfProductLabel.AutoSize = true;
            this.codeOfProductLabel.Location = new System.Drawing.Point(12, 9);
            this.codeOfProductLabel.Name = "codeOfProductLabel";
            this.codeOfProductLabel.Size = new System.Drawing.Size(64, 13);
            this.codeOfProductLabel.TabIndex = 14;
            this.codeOfProductLabel.Text = "Код товара";
            // 
            // codeOfClientLabel
            // 
            this.codeOfClientLabel.AutoSize = true;
            this.codeOfClientLabel.Location = new System.Drawing.Point(12, 61);
            this.codeOfClientLabel.Name = "codeOfClientLabel";
            this.codeOfClientLabel.Size = new System.Drawing.Size(70, 13);
            this.codeOfClientLabel.TabIndex = 13;
            this.codeOfClientLabel.Text = "Код клиента";
            // 
            // dateOfSalesLabel
            // 
            this.dateOfSalesLabel.AutoSize = true;
            this.dateOfSalesLabel.Location = new System.Drawing.Point(111, 9);
            this.dateOfSalesLabel.Name = "dateOfSalesLabel";
            this.dateOfSalesLabel.Size = new System.Drawing.Size(80, 13);
            this.dateOfSalesLabel.TabIndex = 12;
            this.dateOfSalesLabel.Text = "Дата продажи";
            // 
            // ChangeBTN
            // 
            this.ChangeBTN.Location = new System.Drawing.Point(126, 137);
            this.ChangeBTN.Name = "ChangeBTN";
            this.ChangeBTN.Size = new System.Drawing.Size(75, 23);
            this.ChangeBTN.TabIndex = 20;
            this.ChangeBTN.Text = "OK";
            this.ChangeBTN.UseVisualStyleBackColor = true;
            // 
            // ChangEntrySales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 172);
            this.Controls.Add(this.ChangeBTN);
            this.Controls.Add(this.countOfSalesTB);
            this.Controls.Add(this.codeOfProductSalesTB);
            this.Controls.Add(this.codeOfClientSalesTB);
            this.Controls.Add(this.dateTimePickerOfSales);
            this.Controls.Add(this.countOfSalesLabel);
            this.Controls.Add(this.codeOfProductLabel);
            this.Controls.Add(this.codeOfClientLabel);
            this.Controls.Add(this.dateOfSalesLabel);
            this.Name = "ChangEntrySales";
            this.Text = "Изменить продажу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox countOfSalesTB;
        private System.Windows.Forms.TextBox codeOfProductSalesTB;
        private System.Windows.Forms.TextBox codeOfClientSalesTB;
        private System.Windows.Forms.DateTimePicker dateTimePickerOfSales;
        private System.Windows.Forms.Label countOfSalesLabel;
        private System.Windows.Forms.Label codeOfProductLabel;
        private System.Windows.Forms.Label codeOfClientLabel;
        private System.Windows.Forms.Label dateOfSalesLabel;
        private System.Windows.Forms.Button ChangeBTN;
    }
}