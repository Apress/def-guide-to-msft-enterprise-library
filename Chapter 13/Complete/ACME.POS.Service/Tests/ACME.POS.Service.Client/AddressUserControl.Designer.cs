namespace ACME.POS.Service.Client
{
    partial class AddressUserControl
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
            this.m_StreetAddressLabel = new System.Windows.Forms.Label();
            this.m_StreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.m_CityLabel = new System.Windows.Forms.Label();
            this.m_CityTextBox = new System.Windows.Forms.TextBox();
            this.m_StateLabel = new System.Windows.Forms.Label();
            this.m_StateComboBox = new System.Windows.Forms.ComboBox();
            this.m_ZipCodeLabel = new System.Windows.Forms.Label();
            this.m_PrimaryShippingAddressCheckbox = new System.Windows.Forms.CheckBox();
            this.m_ZipCodeMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // m_StreetAddressLabel
            // 
            this.m_StreetAddressLabel.AutoSize = true;
            this.m_StreetAddressLabel.Location = new System.Drawing.Point(7, 16);
            this.m_StreetAddressLabel.Name = "m_StreetAddressLabel";
            this.m_StreetAddressLabel.Size = new System.Drawing.Size(51, 13);
            this.m_StreetAddressLabel.TabIndex = 0;
            this.m_StreetAddressLabel.Text = "Address :";
            // 
            // m_StreetAddressTextBox
            // 
            this.m_StreetAddressTextBox.Location = new System.Drawing.Point(60, 13);
            this.m_StreetAddressTextBox.Name = "m_StreetAddressTextBox";
            this.m_StreetAddressTextBox.Size = new System.Drawing.Size(362, 20);
            this.m_StreetAddressTextBox.TabIndex = 1;
            this.m_StreetAddressTextBox.TextChanged += new System.EventHandler(this.m_StreetAddressTextBox_TextChanged);
            // 
            // m_CityLabel
            // 
            this.m_CityLabel.AutoSize = true;
            this.m_CityLabel.Location = new System.Drawing.Point(28, 41);
            this.m_CityLabel.Name = "m_CityLabel";
            this.m_CityLabel.Size = new System.Drawing.Size(30, 13);
            this.m_CityLabel.TabIndex = 2;
            this.m_CityLabel.Text = "City :";
            // 
            // m_CityTextBox
            // 
            this.m_CityTextBox.Location = new System.Drawing.Point(60, 38);
            this.m_CityTextBox.Name = "m_CityTextBox";
            this.m_CityTextBox.Size = new System.Drawing.Size(125, 20);
            this.m_CityTextBox.TabIndex = 3;
            this.m_CityTextBox.TextChanged += new System.EventHandler(this.m_CityTextBox_TextChanged);
            // 
            // m_StateLabel
            // 
            this.m_StateLabel.AutoSize = true;
            this.m_StateLabel.Location = new System.Drawing.Point(196, 41);
            this.m_StateLabel.Name = "m_StateLabel";
            this.m_StateLabel.Size = new System.Drawing.Size(38, 13);
            this.m_StateLabel.TabIndex = 4;
            this.m_StateLabel.Text = "State :";
            // 
            // m_StateComboBox
            // 
            this.m_StateComboBox.FormattingEnabled = true;
            this.m_StateComboBox.Location = new System.Drawing.Point(236, 38);
            this.m_StateComboBox.Name = "m_StateComboBox";
            this.m_StateComboBox.Size = new System.Drawing.Size(62, 21);
            this.m_StateComboBox.TabIndex = 5;
            this.m_StateComboBox.SelectionChangeCommitted += new System.EventHandler(this.m_StateComboBox_SelectionChangeCommitted);
            // 
            // m_ZipCodeLabel
            // 
            this.m_ZipCodeLabel.AutoSize = true;
            this.m_ZipCodeLabel.Location = new System.Drawing.Point(306, 41);
            this.m_ZipCodeLabel.Name = "m_ZipCodeLabel";
            this.m_ZipCodeLabel.Size = new System.Drawing.Size(28, 13);
            this.m_ZipCodeLabel.TabIndex = 6;
            this.m_ZipCodeLabel.Text = "Zip :";
            // 
            // m_PrimaryShippingAddressCheckbox
            // 
            this.m_PrimaryShippingAddressCheckbox.AutoSize = true;
            this.m_PrimaryShippingAddressCheckbox.Location = new System.Drawing.Point(60, 64);
            this.m_PrimaryShippingAddressCheckbox.Name = "m_PrimaryShippingAddressCheckbox";
            this.m_PrimaryShippingAddressCheckbox.Size = new System.Drawing.Size(145, 17);
            this.m_PrimaryShippingAddressCheckbox.TabIndex = 8;
            this.m_PrimaryShippingAddressCheckbox.Text = "Primary Shipping Address";
            this.m_PrimaryShippingAddressCheckbox.UseVisualStyleBackColor = true;
            this.m_PrimaryShippingAddressCheckbox.CheckedChanged += new System.EventHandler(this.m_PrimaryShippingAddressCheckbox_CheckedChanged);
            // 
            // m_ZipCodeMaskedTextBox
            // 
            this.m_ZipCodeMaskedTextBox.Location = new System.Drawing.Point(345, 38);
            this.m_ZipCodeMaskedTextBox.Mask = "00000-9999";
            this.m_ZipCodeMaskedTextBox.Name = "m_ZipCodeMaskedTextBox";
            this.m_ZipCodeMaskedTextBox.Size = new System.Drawing.Size(76, 20);
            this.m_ZipCodeMaskedTextBox.TabIndex = 9;
            this.m_ZipCodeMaskedTextBox.TextChanged += new System.EventHandler(this.m_ZipCodeMaskedTextBox_TextChanged);
            // 
            // AddressUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_ZipCodeMaskedTextBox);
            this.Controls.Add(this.m_PrimaryShippingAddressCheckbox);
            this.Controls.Add(this.m_ZipCodeLabel);
            this.Controls.Add(this.m_StateComboBox);
            this.Controls.Add(this.m_StateLabel);
            this.Controls.Add(this.m_CityTextBox);
            this.Controls.Add(this.m_CityLabel);
            this.Controls.Add(this.m_StreetAddressTextBox);
            this.Controls.Add(this.m_StreetAddressLabel);
            this.Name = "AddressUserControl";
            this.Size = new System.Drawing.Size(432, 87);
            this.Load += new System.EventHandler(this.AddressUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_StreetAddressLabel;
        private System.Windows.Forms.TextBox m_StreetAddressTextBox;
        private System.Windows.Forms.Label m_CityLabel;
        private System.Windows.Forms.TextBox m_CityTextBox;
        private System.Windows.Forms.Label m_StateLabel;
        private System.Windows.Forms.ComboBox m_StateComboBox;
        private System.Windows.Forms.Label m_ZipCodeLabel;
        private System.Windows.Forms.CheckBox m_PrimaryShippingAddressCheckbox;
        private System.Windows.Forms.MaskedTextBox m_ZipCodeMaskedTextBox;
    }
}
