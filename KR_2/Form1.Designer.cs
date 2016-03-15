namespace KR_2
{
    partial class FSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSales));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodeOfSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeOfClientSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodeOfProductSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountSales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addSales = new System.Windows.Forms.Button();
            this.removeSales = new System.Windows.Forms.Button();
            this.dateOfSalesLabel = new System.Windows.Forms.Label();
            this.codeOfClientLabel = new System.Windows.Forms.Label();
            this.codeOfProductLabel = new System.Windows.Forms.Label();
            this.countOfSalesLabel = new System.Windows.Forms.Label();
            this.dateTimePickerOfSales = new System.Windows.Forms.DateTimePicker();
            this.codeOfClientSalesTB = new System.Windows.Forms.TextBox();
            this.codeOfProductSalesTB = new System.Windows.Forms.TextBox();
            this.countOfSalesTB = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientsToolStripMenuItem,
            this.productsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(599, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.clientsToolStripMenuItem.Text = "Клиенты";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.productsToolStripMenuItem.Text = "Товары";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeOfSales,
            this.DateOfSales,
            this.CodeOfClientSales,
            this.CodeOfProductSales,
            this.CountSales});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Size = new System.Drawing.Size(575, 181);
            this.dataGridView1.TabIndex = 1;
            // 
            // CodeOfSales
            // 
            this.CodeOfSales.HeaderText = "Код";
            this.CodeOfSales.Name = "CodeOfSales";
            this.CodeOfSales.ReadOnly = true;
            // 
            // DateOfSales
            // 
            this.DateOfSales.HeaderText = "Дата продажи";
            this.DateOfSales.Name = "DateOfSales";
            this.DateOfSales.ReadOnly = true;
            this.DateOfSales.Width = 130;
            // 
            // CodeOfClientSales
            // 
            this.CodeOfClientSales.HeaderText = "Код клиента";
            this.CodeOfClientSales.Name = "CodeOfClientSales";
            this.CodeOfClientSales.ReadOnly = true;
            // 
            // CodeOfProductSales
            // 
            this.CodeOfProductSales.HeaderText = "Код товара";
            this.CodeOfProductSales.Name = "CodeOfProductSales";
            this.CodeOfProductSales.ReadOnly = true;
            // 
            // CountSales
            // 
            this.CountSales.HeaderText = "Количество";
            this.CountSales.Name = "CountSales";
            this.CountSales.ReadOnly = true;
            // 
            // addSales
            // 
            this.addSales.Location = new System.Drawing.Point(419, 263);
            this.addSales.Name = "addSales";
            this.addSales.Size = new System.Drawing.Size(75, 23);
            this.addSales.TabIndex = 2;
            this.addSales.Text = "Добавить";
            this.addSales.UseVisualStyleBackColor = true;
            this.addSales.Click += new System.EventHandler(this.addSales_Click);
            // 
            // removeSales
            // 
            this.removeSales.Location = new System.Drawing.Point(512, 263);
            this.removeSales.Name = "removeSales";
            this.removeSales.Size = new System.Drawing.Size(75, 23);
            this.removeSales.TabIndex = 3;
            this.removeSales.Text = "Удалить";
            this.removeSales.UseVisualStyleBackColor = true;
            // 
            // dateOfSalesLabel
            // 
            this.dateOfSalesLabel.AutoSize = true;
            this.dateOfSalesLabel.Location = new System.Drawing.Point(12, 211);
            this.dateOfSalesLabel.Name = "dateOfSalesLabel";
            this.dateOfSalesLabel.Size = new System.Drawing.Size(80, 13);
            this.dateOfSalesLabel.TabIndex = 4;
            this.dateOfSalesLabel.Text = "Дата продажи";
            // 
            // codeOfClientLabel
            // 
            this.codeOfClientLabel.AutoSize = true;
            this.codeOfClientLabel.Location = new System.Drawing.Point(12, 250);
            this.codeOfClientLabel.Name = "codeOfClientLabel";
            this.codeOfClientLabel.Size = new System.Drawing.Size(70, 13);
            this.codeOfClientLabel.TabIndex = 5;
            this.codeOfClientLabel.Text = "Код клиента";
            // 
            // codeOfProductLabel
            // 
            this.codeOfProductLabel.AutoSize = true;
            this.codeOfProductLabel.Location = new System.Drawing.Point(122, 211);
            this.codeOfProductLabel.Name = "codeOfProductLabel";
            this.codeOfProductLabel.Size = new System.Drawing.Size(64, 13);
            this.codeOfProductLabel.TabIndex = 6;
            this.codeOfProductLabel.Text = "Код товара";
            // 
            // countOfSalesLabel
            // 
            this.countOfSalesLabel.AutoSize = true;
            this.countOfSalesLabel.Location = new System.Drawing.Point(122, 250);
            this.countOfSalesLabel.Name = "countOfSalesLabel";
            this.countOfSalesLabel.Size = new System.Drawing.Size(66, 13);
            this.countOfSalesLabel.TabIndex = 7;
            this.countOfSalesLabel.Text = "Количество";
            // 
            // dateTimePickerOfSales
            // 
            this.dateTimePickerOfSales.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOfSales.Location = new System.Drawing.Point(15, 227);
            this.dateTimePickerOfSales.Name = "dateTimePickerOfSales";
            this.dateTimePickerOfSales.Size = new System.Drawing.Size(85, 20);
            this.dateTimePickerOfSales.TabIndex = 8;
            // 
            // codeOfClientSalesTB
            // 
            this.codeOfClientSalesTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeOfClientSalesTB.Location = new System.Drawing.Point(15, 266);
            this.codeOfClientSalesTB.Name = "codeOfClientSalesTB";
            this.codeOfClientSalesTB.ReadOnly = true;
            this.codeOfClientSalesTB.Size = new System.Drawing.Size(32, 20);
            this.codeOfClientSalesTB.TabIndex = 9;
            this.codeOfClientSalesTB.Click += new System.EventHandler(this.onClickClientSalesTB);
            // 
            // codeOfProductSalesTB
            // 
            this.codeOfProductSalesTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeOfProductSalesTB.Location = new System.Drawing.Point(125, 227);
            this.codeOfProductSalesTB.Name = "codeOfProductSalesTB";
            this.codeOfProductSalesTB.Size = new System.Drawing.Size(32, 20);
            this.codeOfProductSalesTB.TabIndex = 10;
            this.codeOfProductSalesTB.Click += new System.EventHandler(this.onClickProductSalesTB);
            // 
            // countOfSalesTB
            // 
            this.countOfSalesTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countOfSalesTB.Location = new System.Drawing.Point(125, 266);
            this.countOfSalesTB.Name = "countOfSalesTB";
            this.countOfSalesTB.Size = new System.Drawing.Size(61, 20);
            this.countOfSalesTB.TabIndex = 11;
            // 
            // FSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 319);
            this.Controls.Add(this.countOfSalesTB);
            this.Controls.Add(this.codeOfProductSalesTB);
            this.Controls.Add(this.codeOfClientSalesTB);
            this.Controls.Add(this.dateTimePickerOfSales);
            this.Controls.Add(this.countOfSalesLabel);
            this.Controls.Add(this.codeOfProductLabel);
            this.Controls.Add(this.codeOfClientLabel);
            this.Controls.Add(this.dateOfSalesLabel);
            this.Controls.Add(this.removeSales);
            this.Controls.Add(this.addSales);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FSales";
            this.Text = "OmelchenkoAS-Store";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOfSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOfClientSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOfProductSales;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountSales;
        private System.Windows.Forms.Button addSales;
        private System.Windows.Forms.Button removeSales;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.Label dateOfSalesLabel;
        private System.Windows.Forms.Label codeOfClientLabel;
        private System.Windows.Forms.Label codeOfProductLabel;
        private System.Windows.Forms.Label countOfSalesLabel;
        private System.Windows.Forms.DateTimePicker dateTimePickerOfSales;
        private System.Windows.Forms.TextBox codeOfClientSalesTB;
        private System.Windows.Forms.TextBox codeOfProductSalesTB;
        private System.Windows.Forms.TextBox countOfSalesTB;
    }
}

