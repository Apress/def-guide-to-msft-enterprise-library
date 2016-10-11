namespace ACME.POS.Service.Client
{
    partial class NewBillingMethodForm
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
            this.m_CreditCardRadioButton = new System.Windows.Forms.RadioButton();
            this.m_NetTermRadioButton = new System.Windows.Forms.RadioButton();
            this.m_SelectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_CreditCardRadioButton
            // 
            this.m_CreditCardRadioButton.AutoSize = true;
            this.m_CreditCardRadioButton.Checked = true;
            this.m_CreditCardRadioButton.Location = new System.Drawing.Point(23, 12);
            this.m_CreditCardRadioButton.Name = "m_CreditCardRadioButton";
            this.m_CreditCardRadioButton.Size = new System.Drawing.Size(77, 17);
            this.m_CreditCardRadioButton.TabIndex = 0;
            this.m_CreditCardRadioButton.TabStop = true;
            this.m_CreditCardRadioButton.Text = "Credit Card";
            this.m_CreditCardRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_NetTermRadioButton
            // 
            this.m_NetTermRadioButton.AutoSize = true;
            this.m_NetTermRadioButton.Location = new System.Drawing.Point(23, 35);
            this.m_NetTermRadioButton.Name = "m_NetTermRadioButton";
            this.m_NetTermRadioButton.Size = new System.Drawing.Size(69, 17);
            this.m_NetTermRadioButton.TabIndex = 1;
            this.m_NetTermRadioButton.TabStop = true;
            this.m_NetTermRadioButton.Text = "Net Term";
            this.m_NetTermRadioButton.UseVisualStyleBackColor = true;
            // 
            // m_SelectButton
            // 
            this.m_SelectButton.Location = new System.Drawing.Point(33, 58);
            this.m_SelectButton.Name = "m_SelectButton";
            this.m_SelectButton.Size = new System.Drawing.Size(75, 23);
            this.m_SelectButton.TabIndex = 2;
            this.m_SelectButton.Text = "Select";
            this.m_SelectButton.UseVisualStyleBackColor = true;
            this.m_SelectButton.Click += new System.EventHandler(this.m_SelectButton_Click);
            // 
            // NewBillingMethodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(136, 85);
            this.Controls.Add(this.m_SelectButton);
            this.Controls.Add(this.m_NetTermRadioButton);
            this.Controls.Add(this.m_CreditCardRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewBillingMethodForm";
            this.Text = "Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton m_CreditCardRadioButton;
        private System.Windows.Forms.RadioButton m_NetTermRadioButton;
        private System.Windows.Forms.Button m_SelectButton;
    }
}