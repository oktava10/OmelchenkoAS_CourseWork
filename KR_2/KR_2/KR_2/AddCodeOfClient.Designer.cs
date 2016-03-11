namespace KR_2
{
    partial class AddCodeOfClient
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
            this.clientDataGridView = new System.Windows.Forms.DataGridView();
            this.CodeOfClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addCodeOfClientbtn = new System.Windows.Forms.Button();
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
            this.clientDataGridView.Location = new System.Drawing.Point(11, 12);
            this.clientDataGridView.Name = "clientDataGridView";
            this.clientDataGridView.Size = new System.Drawing.Size(249, 219);
            this.clientDataGridView.TabIndex = 1;
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
            // addCodeOfClientbtn
            // 
            this.addCodeOfClientbtn.Location = new System.Drawing.Point(185, 254);
            this.addCodeOfClientbtn.Name = "addCodeOfClientbtn";
            this.addCodeOfClientbtn.Size = new System.Drawing.Size(75, 23);
            this.addCodeOfClientbtn.TabIndex = 2;
            this.addCodeOfClientbtn.Text = "OK";
            this.addCodeOfClientbtn.UseVisualStyleBackColor = true;
            // 
            // AddCodeOfClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 289);
            this.Controls.Add(this.addCodeOfClientbtn);
            this.Controls.Add(this.clientDataGridView);
            this.Name = "AddCodeOfClient";
            this.Text = "AddCodeOfClient";
            ((System.ComponentModel.ISupportInitialize)(this.clientDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addCodeOfClientbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeOfClient;
        private System.Windows.Forms.DataGridView clientDataGridView;
    }
}