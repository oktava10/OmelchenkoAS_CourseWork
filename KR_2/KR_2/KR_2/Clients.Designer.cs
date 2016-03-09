namespace KR_2
{
    partial class Clients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clients));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodeOfClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addClient = new System.Windows.Forms.Button();
            this.removeClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeOfClient,
            this.Lastname});
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(249, 219);
            this.dataGridView1.TabIndex = 0;
            // 
            // CodeOfClient
            // 
            this.CodeOfClient.HeaderText = "Код";
            this.CodeOfClient.Name = "CodeOfClient";
            this.CodeOfClient.ReadOnly = true;
            this.CodeOfClient.Width = 30;
            // 
            // Lastname
            // 
            this.Lastname.HeaderText = "Фамилия";
            this.Lastname.Name = "Lastname";
            this.Lastname.ReadOnly = true;
            this.Lastname.Width = 170;
            // 
            // addClient
            // 
            this.addClient.Location = new System.Drawing.Point(105, 238);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(75, 23);
            this.addClient.TabIndex = 2;
            this.addClient.Text = "Добавить";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // removeClient
            // 
            this.removeClient.Location = new System.Drawing.Point(186, 238);
            this.removeClient.Name = "removeClient";
            this.removeClient.Size = new System.Drawing.Size(75, 23);
            this.removeClient.TabIndex = 3;
            this.removeClient.Text = "Удалить";
            this.removeClient.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 273);
            this.Controls.Add(this.removeClient);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clients";
            this.Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button removeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOfClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
    }
}