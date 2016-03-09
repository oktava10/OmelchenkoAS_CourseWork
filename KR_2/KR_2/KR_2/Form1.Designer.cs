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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.autoSave = new System.Windows.Forms.CheckBox();
            this.saveChangesBtn = new System.Windows.Forms.Button();
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeOfSales,
            this.DateOfSales,
            this.CodeOfClientSales,
            this.CodeOfProductSales,
            this.CountSales});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
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
            this.addSales.Location = new System.Drawing.Point(418, 238);
            this.addSales.Name = "addSales";
            this.addSales.Size = new System.Drawing.Size(75, 23);
            this.addSales.TabIndex = 2;
            this.addSales.Text = "Добавить";
            this.addSales.UseVisualStyleBackColor = true;
            this.addSales.Click += new System.EventHandler(this.addSales_Click);
            // 
            // removeSales
            // 
            this.removeSales.Location = new System.Drawing.Point(512, 238);
            this.removeSales.Name = "removeSales";
            this.removeSales.Size = new System.Drawing.Size(75, 23);
            this.removeSales.TabIndex = 3;
            this.removeSales.Text = "Удалить";
            this.removeSales.UseVisualStyleBackColor = true;
            // 
            // autoSave
            // 
            this.autoSave.AutoSize = true;
            this.autoSave.Location = new System.Drawing.Point(12, 214);
            this.autoSave.Name = "autoSave";
            this.autoSave.Size = new System.Drawing.Size(109, 17);
            this.autoSave.TabIndex = 4;
            this.autoSave.Text = "Автосохранение";
            this.autoSave.UseVisualStyleBackColor = true;
            // 
            // saveChangesBtn
            // 
            this.saveChangesBtn.Enabled = false;
            this.saveChangesBtn.Location = new System.Drawing.Point(12, 238);
            this.saveChangesBtn.Name = "saveChangesBtn";
            this.saveChangesBtn.Size = new System.Drawing.Size(75, 23);
            this.saveChangesBtn.TabIndex = 5;
            this.saveChangesBtn.Text = "Сохранить";
            this.saveChangesBtn.UseVisualStyleBackColor = true;
            // 
            // FSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 273);
            this.Controls.Add(this.saveChangesBtn);
            this.Controls.Add(this.autoSave);
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
        private System.Windows.Forms.CheckBox autoSave;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.Button saveChangesBtn;
    }
}

