namespace KR_2
{
    partial class NewSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewSales));
            this.DateOfSalesLabel = new System.Windows.Forms.Label();
            this.CodeOfClientLabel = new System.Windows.Forms.Label();
            this.CodeOfProductLabel = new System.Windows.Forms.Label();
            this.CountOfSalesLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.addNewSalesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DateOfSalesLabel
            // 
            this.DateOfSalesLabel.AutoSize = true;
            this.DateOfSalesLabel.Location = new System.Drawing.Point(12, 9);
            this.DateOfSalesLabel.Name = "DateOfSalesLabel";
            this.DateOfSalesLabel.Size = new System.Drawing.Size(80, 13);
            this.DateOfSalesLabel.TabIndex = 0;
            this.DateOfSalesLabel.Text = "Дата продажи";
            // 
            // CodeOfClientLabel
            // 
            this.CodeOfClientLabel.AutoSize = true;
            this.CodeOfClientLabel.Location = new System.Drawing.Point(125, 9);
            this.CodeOfClientLabel.Name = "CodeOfClientLabel";
            this.CodeOfClientLabel.Size = new System.Drawing.Size(70, 13);
            this.CodeOfClientLabel.TabIndex = 1;
            this.CodeOfClientLabel.Text = "Код клиента";
            // 
            // CodeOfProductLabel
            // 
            this.CodeOfProductLabel.AutoSize = true;
            this.CodeOfProductLabel.Location = new System.Drawing.Point(12, 61);
            this.CodeOfProductLabel.Name = "CodeOfProductLabel";
            this.CodeOfProductLabel.Size = new System.Drawing.Size(64, 13);
            this.CodeOfProductLabel.TabIndex = 2;
            this.CodeOfProductLabel.Text = "Код товара";
            // 
            // CountOfSalesLabel
            // 
            this.CountOfSalesLabel.AutoSize = true;
            this.CountOfSalesLabel.Location = new System.Drawing.Point(125, 61);
            this.CountOfSalesLabel.Name = "CountOfSalesLabel";
            this.CountOfSalesLabel.Size = new System.Drawing.Size(66, 13);
            this.CountOfSalesLabel.TabIndex = 3;
            this.CountOfSalesLabel.Text = "Количество";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(128, 25);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(67, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(15, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(85, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(61, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(128, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 20);
            this.textBox3.TabIndex = 8;
            // 
            // addNewSalesBtn
            // 
            this.addNewSalesBtn.Location = new System.Drawing.Point(118, 121);
            this.addNewSalesBtn.Name = "addNewSalesBtn";
            this.addNewSalesBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewSalesBtn.TabIndex = 9;
            this.addNewSalesBtn.Text = "Добавить";
            this.addNewSalesBtn.UseVisualStyleBackColor = true;
            // 
            // NewSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(205, 156);
            this.Controls.Add(this.addNewSalesBtn);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.CountOfSalesLabel);
            this.Controls.Add(this.CodeOfProductLabel);
            this.Controls.Add(this.CodeOfClientLabel);
            this.Controls.Add(this.DateOfSalesLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewSales";
            this.Text = "Добавить продажу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DateOfSalesLabel;
        private System.Windows.Forms.Label CodeOfClientLabel;
        private System.Windows.Forms.Label CodeOfProductLabel;
        private System.Windows.Forms.Label CountOfSalesLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button addNewSalesBtn;
    }
}