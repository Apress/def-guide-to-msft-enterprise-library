namespace ACME.POS.Service.Client
{
    partial class CreditCardUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.m_CardNumberLabel = new System.Windows.Forms.Label();
            this.m_ExpirationLabel = new System.Windows.Forms.Label();
            this.m_BillingAddressLabel = new System.Windows.Forms.Label();
            this.m_BillingAddressComboBox = new System.Windows.Forms.ComboBox();
            this.m_CardNumberTextBox = new System.Windows.Forms.TextBox();
            this.m_ExpirationMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // m_CardNumberLabel
            // 
            this.m_CardNumberLabel.AutoSize = true;
            this.m_CardNumberLabel.Location = new System.Drawing.Point(12, 7);
            this.m_CardNumberLabel.Name = "m_CardNumberLabel";
            this.m_CardNumberLabel.Size = new System.Drawing.Size(75, 13);
            this.m_CardNumberLabel.TabIndex = 0;
            this.m_CardNumberLabel.Text = "Card Number :";
            // 
            // m_ExpirationLabel
            // 
            this.m_ExpirationLabel.AutoSize = true;
            this.m_ExpirationLabel.Location = new System.Drawing.Point(276, 7);
            this.m_ExpirationLabel.Name = "m_ExpirationLabel";
            this.m_ExpirationLabel.Size = new System.Drawing.Size(34, 13);
            this.m_ExpirationLabel.TabIndex = 1;
            this.m_ExpirationLabel.Text = "Exp : ";
            // 
            // m_BillingAddressLabel
            // 
            this.m_BillingAddressLabel.AutoSize = true;
            this.m_BillingAddressLabel.Location = new System.Drawing.Point(6, 33);
            this.m_BillingAddressLabel.Name = "m_BillingAddressLabel";
            this.m_BillingAddressLabel.Size = new System.Drawing.Size(84, 13);
            this.m_BillingAddressLabel.TabIndex = 2;
            this.m_BillingAddressLabel.Text = "Billing Address : ";
            // 
            // m_BillingAddressComboBox
            // 
            this.m_BillingAddressComboBox.FormattingEnabled = true;
            this.m_BillingAddressComboBox.Location = new System.Drawing.Point(93, 30);
            this.m_BillingAddressComboBox.Name = "m_BillingAddressComboBox";
            this.m_BillingAddressComboBox.Size = new System.Drawing.Size(299, 21);
            this.m_BillingAddressComboBox.TabIndex = 3;
            this.m_BillingAddressComboBox.SelectionChangeCommitted += new System.EventHandler(this.m_BillingAddressComboBox_SelectionChangeCommitted);
            // 
            // m_CardNumberTextBox
            // 
            this.m_CardNumberTextBox.Location = new System.Drawing.Point(93, 4);
            this.m_CardNumberTextBox.Name = "m_CardNumberTextBox";
            this.m_CardNumberTextBox.Size = new System.Drawing.Size(177, 20);
            this.m_CardNumberTextBox.TabIndex = 4;
            this.m_CardNumberTextBox.TextChanged += new System.EventHandler(this.m_CardNumberTextBox_TextChanged);
            // 
            // m_ExpirationMaskedTextBox
            // 
            this.m_ExpirationMaskedTextBox.Location = new System.Drawing.Point(306, 4);
            this.m_ExpirationMaskedTextBox.Mask = "00/0000";
            this.m_ExpirationMaskedTextBox.Name = "m_ExpirationMaskedTextBox";
            this.m_ExpirationMaskedTextBox.Size = new System.Drawing.Size(86, 20);
            this.m_ExpirationMaskedTextBox.TabIndex = 5;
            this.m_ExpirationMaskedTextBox.TextChanged += new System.EventHandler(this.m_ExpirationMaskedTextBox_TextChanged);
            // 
            // CreditCardUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_ExpirationMaskedTextBox);
            this.Controls.Add(this.m_CardNumberTextBox);
            this.Controls.Add(this.m_BillingAddressComboBox);
            this.Controls.Add(this.m_BillingAddressLabel);
            this.Controls.Add(this.m_ExpirationLabel);
            this.Controls.Add(this.m_CardNumberLabel);
            this.Name = "CreditCardUserControl";
            this.Size = new System.Drawing.Size(395, 65);
            this.Load += new System.EventHandler(this.CreditCardUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_CardNumberLabel;
        private System.Windows.Forms.Label m_ExpirationLabel;
        private System.Windows.Forms.Label m_BillingAddressLabel;
        private System.Windows.Forms.ComboBox m_BillingAddressComboBox;
        private System.Windows.Forms.TextBox m_CardNumberTextBox;
        private System.Windows.Forms.MaskedTextBox m_ExpirationMaskedTextBox;
    }
}
