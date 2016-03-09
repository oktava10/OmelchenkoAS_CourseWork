namespace KR_2
{
    partial class NewClient
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
            this.addNewClientBtn = new System.Windows.Forms.Button();
            this.addNewClientTextBox = new System.Windows.Forms.TextBox();
            this.lastnameOfClientLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addNewClientBtn
            // 
            this.addNewClientBtn.Location = new System.Drawing.Point(180, 96);
            this.addNewClientBtn.Name = "addNewClientBtn";
            this.addNewClientBtn.Size = new System.Drawing.Size(75, 23);
            this.addNewClientBtn.TabIndex = 0;
            this.addNewClientBtn.Text = "Добавить";
            this.addNewClientBtn.UseVisualStyleBackColor = true;
            // 
            // addNewClientTextBox
            // 
            this.addNewClientTextBox.Location = new System.Drawing.Point(12, 55);
            this.addNewClientTextBox.Name = "addNewClientTextBox";
            this.addNewClientTextBox.Size = new System.Drawing.Size(243, 20);
            this.addNewClientTextBox.TabIndex = 1;
            // 
            // lastnameOfClientLabel
            // 
            this.lastnameOfClientLabel.AutoSize = true;
            this.lastnameOfClientLabel.Location = new System.Drawing.Point(12, 20);
            this.lastnameOfClientLabel.Name = "lastnameOfClientLabel";
            this.lastnameOfClientLabel.Size = new System.Drawing.Size(56, 13);
            this.lastnameOfClientLabel.TabIndex = 2;
            this.lastnameOfClientLabel.Text = "Фамилия";
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 131);
            this.Controls.Add(this.lastnameOfClientLabel);
            this.Controls.Add(this.addNewClientTextBox);
            this.Controls.Add(this.addNewClientBtn);
            this.Name = "NewClient";
            this.Text = "Добавить клиента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addNewClientBtn;
        private System.Windows.Forms.TextBox addNewClientTextBox;
        private System.Windows.Forms.Label lastnameOfClientLabel;
    }
}