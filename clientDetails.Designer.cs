namespace V.ShopWithInventory
{
    partial class clientDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.accountBalanceButton = new System.Windows.Forms.TextBox();
            this.backToLoginFormButton = new System.Windows.Forms.Button();
            this.continueToShopClientView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на клиент:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Баланс:";
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(129, 9);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientNameTextBox.TabIndex = 2;
            // 
            // accountBalanceButton
            // 
            this.accountBalanceButton.Location = new System.Drawing.Point(129, 39);
            this.accountBalanceButton.Name = "accountBalanceButton";
            this.accountBalanceButton.Size = new System.Drawing.Size(100, 20);
            this.accountBalanceButton.TabIndex = 3;
            // 
            // backToLoginFormButton
            // 
            this.backToLoginFormButton.Location = new System.Drawing.Point(12, 90);
            this.backToLoginFormButton.Name = "backToLoginFormButton";
            this.backToLoginFormButton.Size = new System.Drawing.Size(101, 23);
            this.backToLoginFormButton.TabIndex = 4;
            this.backToLoginFormButton.Text = "Назад";
            this.backToLoginFormButton.UseVisualStyleBackColor = true;
            this.backToLoginFormButton.Click += new System.EventHandler(this.backToLoginFormButton_Click);
            // 
            // continueToShopClientView
            // 
            this.continueToShopClientView.Location = new System.Drawing.Point(129, 90);
            this.continueToShopClientView.Name = "continueToShopClientView";
            this.continueToShopClientView.Size = new System.Drawing.Size(100, 23);
            this.continueToShopClientView.TabIndex = 5;
            this.continueToShopClientView.Text = "Продължи";
            this.continueToShopClientView.UseVisualStyleBackColor = true;
            this.continueToShopClientView.Click += new System.EventHandler(this.continueToShopClientView_Click);
            // 
            // clientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 148);
            this.Controls.Add(this.continueToShopClientView);
            this.Controls.Add(this.backToLoginFormButton);
            this.Controls.Add(this.accountBalanceButton);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "clientDetails";
            this.Text = "Клиентски данни";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox accountBalanceButton;
        private System.Windows.Forms.Button backToLoginFormButton;
        private System.Windows.Forms.Button continueToShopClientView;
    }
}