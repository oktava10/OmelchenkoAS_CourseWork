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
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.CodeOfClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addClient = new System.Windows.Forms.Button();
            this.removeClient = new System.Windows.Forms.Button();
            this.lastnameOfClientLabel = new System.Windows.Forms.Label();
            this.addNewClientTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // clientDataGridView
            // 
            this.clientDataGridView.AllowUserToResizeColumns = false;
            this.clientDataGridView.AllowUserToResizeRows = false;
            this.clientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeOfClient,
            this.Lastname});
            this.clientDataGridView.Location = new System.Drawing.Point(12, 12);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(249, 219);
            this.clientDataGridView.TabIndex = 0;
            // 
            // CodeOfClient
            // 
            this.CodeOfClient.HeaderText = "Код";
            this.CodeOfClient.Name = "CodeOfClient";
            this.CodeOfClient.ReadOnly = true;
            this.CodeOfClient.Width = 35;
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
            this.addClient.Location = new System.Drawing.Point(105, 300);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(75, 23);
            this.addClient.TabIndex = 2;
            this.addClient.Text = "Добавить";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // removeClient
            // 
            this.removeClient.Location = new System.Drawing.Point(186, 300);
            this.removeClient.Name = "removeClient";
            this.removeClient.Size = new System.Drawing.Size(75, 23);
            this.removeClient.TabIndex = 3;
            this.removeClient.Text = "Удалить";
            this.removeClient.UseVisualStyleBackColor = true;
            this.removeClient.Click += new System.EventHandler(this.removeClient_Click);
            // 
            // lastnameOfClientLabel
            // 
            this.lastnameOfClientLabel.AutoSize = true;
            this.lastnameOfClientLabel.Location = new System.Drawing.Point(9, 243);
            this.lastnameOfClientLabel.Name = "lastnameOfClientLabel";
            this.lastnameOfClientLabel.Size = new System.Drawing.Size(56, 13);
            this.lastnameOfClientLabel.TabIndex = 5;
            this.lastnameOfClientLabel.Text = "Фамилия";
            // 
            // addNewClientTextBox
            // 
            this.addNewClientTextBox.Location = new System.Drawing.Point(12, 259);
            this.addNewClientTextBox.Name = "addNewClientTextBox";
            this.addNewClientTextBox.Size = new System.Drawing.Size(243, 20);
            this.addNewClientTextBox.TabIndex = 4;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 344);
            this.Controls.Add(this.lastnameOfClientLabel);
            this.Controls.Add(this.addNewClientTextBox);
            this.Controls.Add(this.removeClient);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.clientDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Clients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView clientDataGridView;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Button removeClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOfClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.Label lastnameOfClientLabel;
        private System.Windows.Forms.TextBox addNewClientTextBox;
    }
}