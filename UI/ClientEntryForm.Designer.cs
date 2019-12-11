namespace V.ShopWithInventory.UI
{
    partial class ClientEntryForm
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
            this.balanceLabel = new System.Windows.Forms.Label();
            this.clientNameTextBox = new System.Windows.Forms.TextBox();
            this.clientMoneyTextBox = new System.Windows.Forms.TextBox();
            this.backButton = new System.Windows.Forms.Button();
            this.clientShopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име на клиент:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.AutoSize = true;
            this.balanceLabel.Location = new System.Drawing.Point(38, 97);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(47, 13);
            this.balanceLabel.TabIndex = 1;
            this.balanceLabel.Text = "Баланс:";
            this.balanceLabel.Visible = false;
            // 
            // clientNameTextBox
            // 
            this.clientNameTextBox.Location = new System.Drawing.Point(150, 64);
            this.clientNameTextBox.Name = "clientNameTextBox";
            this.clientNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientNameTextBox.TabIndex = 2;
            // 
            // clientMoneyTextBox
            // 
            this.clientMoneyTextBox.Location = new System.Drawing.Point(150, 90);
            this.clientMoneyTextBox.Name = "clientMoneyTextBox";
            this.clientMoneyTextBox.Size = new System.Drawing.Size(100, 20);
            this.clientMoneyTextBox.TabIndex = 3;
            this.clientMoneyTextBox.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(168, 149);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(82, 27);
            this.backButton.TabIndex = 4;
            this.backButton.Text = "Назад";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // clientShopButton
            // 
            this.clientShopButton.Location = new System.Drawing.Point(41, 149);
            this.clientShopButton.Name = "clientShopButton";
            this.clientShopButton.Size = new System.Drawing.Size(93, 27);
            this.clientShopButton.TabIndex = 5;
            this.clientShopButton.Text = "Към магазина";
            this.clientShopButton.UseVisualStyleBackColor = true;
            this.clientShopButton.Click += new System.EventHandler(this.clientShopButton_Click);
            // 
            // ClientEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 227);
            this.Controls.Add(this.clientShopButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.clientMoneyTextBox);
            this.Controls.Add(this.clientNameTextBox);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label1);
            this.Name = "ClientEntryForm";
            this.Text = "Клиентски данни за вход";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceLabel;
        private System.Windows.Forms.TextBox clientNameTextBox;
        private System.Windows.Forms.TextBox clientMoneyTextBox;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button clientShopButton;
    }
}