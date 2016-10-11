namespace ACME.POS.Service.Client
{
    partial class CustomerForm
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
            this.m_FirstNameLabel = new System.Windows.Forms.Label();
            this.m_LastNameLabel = new System.Windows.Forms.Label();
            this.m_MemberSinceLabel = new System.Windows.Forms.Label();
            this.m_BirthDateLabel = new System.Windows.Forms.Label();
            this.m_FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.m_LastNameTextBox = new System.Windows.Forms.TextBox();
            this.m_BirthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.m_MemberSinceDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.m_AddressGroupBox = new System.Windows.Forms.GroupBox();
            this.m_DeleteAddressButton = new System.Windows.Forms.Button();
            this.m_CreateAddressButton = new System.Windows.Forms.Button();
            this.m_AddressTabControl = new System.Windows.Forms.TabControl();
            this.m_BillingMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.m_DeleteBillingMethodButton = new System.Windows.Forms.Button();
            this.m_CreateBillingMethodButton = new System.Windows.Forms.Button();
            this.m_BillingMethodTabControl = new System.Windows.Forms.TabControl();
            this.m_SaveCustomerButton = new System.Windows.Forms.Button();
            this.m_CancelButton = new System.Windows.Forms.Button();
            this.m_AddressGroupBox.SuspendLayout();
            this.m_BillingMethodGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_FirstNameLabel
            // 
            this.m_FirstNameLabel.AutoSize = true;
            this.m_FirstNameLabel.Location = new System.Drawing.Point(13, 23);
            this.m_FirstNameLabel.Name = "m_FirstNameLabel";
            this.m_FirstNameLabel.Size = new System.Drawing.Size(63, 13);
            this.m_FirstNameLabel.TabIndex = 0;
            this.m_FirstNameLabel.Text = "First Name :";
            // 
            // m_LastNameLabel
            // 
            this.m_LastNameLabel.AutoSize = true;
            this.m_LastNameLabel.Location = new System.Drawing.Point(249, 23);
            this.m_LastNameLabel.Name = "m_LastNameLabel";
            this.m_LastNameLabel.Size = new System.Drawing.Size(64, 13);
            this.m_LastNameLabel.TabIndex = 1;
            this.m_LastNameLabel.Text = "Last Name :";
            // 
            // m_MemberSinceLabel
            // 
            this.m_MemberSinceLabel.AutoSize = true;
            this.m_MemberSinceLabel.Location = new System.Drawing.Point(249, 50);
            this.m_MemberSinceLabel.Name = "m_MemberSinceLabel";
            this.m_MemberSinceLabel.Size = new System.Drawing.Size(81, 13);
            this.m_MemberSinceLabel.TabIndex = 2;
            this.m_MemberSinceLabel.Text = "Member Since :";
            // 
            // m_BirthDateLabel
            // 
            this.m_BirthDateLabel.AutoSize = true;
            this.m_BirthDateLabel.Location = new System.Drawing.Point(13, 50);
            this.m_BirthDateLabel.Name = "m_BirthDateLabel";
            this.m_BirthDateLabel.Size = new System.Drawing.Size(60, 13);
            this.m_BirthDateLabel.TabIndex = 3;
            this.m_BirthDateLabel.Text = "Birth Date :";
            // 
            // m_FirstNameTextBox
            // 
            this.m_FirstNameTextBox.Location = new System.Drawing.Point(82, 20);
            this.m_FirstNameTextBox.Name = "m_FirstNameTextBox";
            this.m_FirstNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.m_FirstNameTextBox.TabIndex = 4;
            // 
            // m_LastNameTextBox
            // 
            this.m_LastNameTextBox.Location = new System.Drawing.Point(330, 20);
            this.m_LastNameTextBox.Name = "m_LastNameTextBox";
            this.m_LastNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.m_LastNameTextBox.TabIndex = 5;
            // 
            // m_BirthDateDateTimePicker
            // 
            this.m_BirthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_BirthDateDateTimePicker.Location = new System.Drawing.Point(82, 44);
            this.m_BirthDateDateTimePicker.Name = "m_BirthDateDateTimePicker";
            this.m_BirthDateDateTimePicker.Size = new System.Drawing.Size(115, 20);
            this.m_BirthDateDateTimePicker.TabIndex = 6;
            // 
            // m_MemberSinceDateTimePicker
            // 
            this.m_MemberSinceDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_MemberSinceDateTimePicker.Location = new System.Drawing.Point(330, 46);
            this.m_MemberSinceDateTimePicker.Name = "m_MemberSinceDateTimePicker";
            this.m_MemberSinceDateTimePicker.Size = new System.Drawing.Size(115, 20);
            this.m_MemberSinceDateTimePicker.TabIndex = 7;
            // 
            // m_AddressGroupBox
            // 
            this.m_AddressGroupBox.Controls.Add(this.m_DeleteAddressButton);
            this.m_AddressGroupBox.Controls.Add(this.m_CreateAddressButton);
            this.m_AddressGroupBox.Controls.Add(this.m_AddressTabControl);
            this.m_AddressGroupBox.Location = new System.Drawing.Point(16, 83);
            this.m_AddressGroupBox.Name = "m_AddressGroupBox";
            this.m_AddressGroupBox.Size = new System.Drawing.Size(475, 163);
            this.m_AddressGroupBox.TabIndex = 8;
            this.m_AddressGroupBox.TabStop = false;
            this.m_AddressGroupBox.Text = "Address";
            // 
            // m_DeleteAddressButton
            // 
            this.m_DeleteAddressButton.Location = new System.Drawing.Point(122, 131);
            this.m_DeleteAddressButton.Name = "m_DeleteAddressButton";
            this.m_DeleteAddressButton.Size = new System.Drawing.Size(105, 23);
            this.m_DeleteAddressButton.TabIndex = 13;
            this.m_DeleteAddressButton.Text = "Delete Address";
            this.m_DeleteAddressButton.UseVisualStyleBackColor = true;
            // 
            // m_CreateAddressButton
            // 
            this.m_CreateAddressButton.Location = new System.Drawing.Point(11, 131);
            this.m_CreateAddressButton.Name = "m_CreateAddressButton";
            this.m_CreateAddressButton.Size = new System.Drawing.Size(105, 23);
            this.m_CreateAddressButton.TabIndex = 12;
            this.m_CreateAddressButton.Text = "Create Address";
            this.m_CreateAddressButton.UseVisualStyleBackColor = true;
            // 
            // m_AddressTabControl
            // 
            this.m_AddressTabControl.Location = new System.Drawing.Point(7, 20);
            this.m_AddressTabControl.Name = "m_AddressTabControl";
            this.m_AddressTabControl.SelectedIndex = 0;
            this.m_AddressTabControl.Size = new System.Drawing.Size(462, 105);
            this.m_AddressTabControl.TabIndex = 0;
            // 
            // m_BillingMethodGroupBox
            // 
            this.m_BillingMethodGroupBox.Controls.Add(this.m_DeleteBillingMethodButton);
            this.m_BillingMethodGroupBox.Controls.Add(this.m_CreateBillingMethodButton);
            this.m_BillingMethodGroupBox.Controls.Add(this.m_BillingMethodTabControl);
            this.m_BillingMethodGroupBox.Location = new System.Drawing.Point(16, 256);
            this.m_BillingMethodGroupBox.Name = "m_BillingMethodGroupBox";
            this.m_BillingMethodGroupBox.Size = new System.Drawing.Size(475, 156);
            this.m_BillingMethodGroupBox.TabIndex = 9;
            this.m_BillingMethodGroupBox.TabStop = false;
            this.m_BillingMethodGroupBox.Text = "Billing Method";
            // 
            // m_DeleteBillingMethodButton
            // 
            this.m_DeleteBillingMethodButton.Location = new System.Drawing.Point(136, 127);
            this.m_DeleteBillingMethodButton.Name = "m_DeleteBillingMethodButton";
            this.m_DeleteBillingMethodButton.Size = new System.Drawing.Size(123, 23);
            this.m_DeleteBillingMethodButton.TabIndex = 12;
            this.m_DeleteBillingMethodButton.Text = "Delete Billing Method";
            this.m_DeleteBillingMethodButton.UseVisualStyleBackColor = true;
            // 
            // m_CreateBillingMethodButton
            // 
            this.m_CreateBillingMethodButton.Location = new System.Drawing.Point(11, 127);
            this.m_CreateBillingMethodButton.Name = "m_CreateBillingMethodButton";
            this.m_CreateBillingMethodButton.Size = new System.Drawing.Size(119, 23);
            this.m_CreateBillingMethodButton.TabIndex = 11;
            this.m_CreateBillingMethodButton.Text = "Create Billing Method";
            this.m_CreateBillingMethodButton.UseVisualStyleBackColor = true;
            // 
            // m_BillingMethodTabControl
            // 
            this.m_BillingMethodTabControl.Location = new System.Drawing.Point(7, 20);
            this.m_BillingMethodTabControl.Name = "m_BillingMethodTabControl";
            this.m_BillingMethodTabControl.SelectedIndex = 0;
            this.m_BillingMethodTabControl.Size = new System.Drawing.Size(462, 101);
            this.m_BillingMethodTabControl.TabIndex = 0;
            // 
            // m_SaveCustomerButton
            // 
            this.m_SaveCustomerButton.Location = new System.Drawing.Point(287, 422);
            this.m_SaveCustomerButton.Name = "m_SaveCustomerButton";
            this.m_SaveCustomerButton.Size = new System.Drawing.Size(105, 23);
            this.m_SaveCustomerButton.TabIndex = 10;
            this.m_SaveCustomerButton.Text = "Save Customer";
            this.m_SaveCustomerButton.UseVisualStyleBackColor = true;
            this.m_SaveCustomerButton.Click += new System.EventHandler(this.m_SaveCustomerButton_Click);
            // 
            // m_CancelButton
            // 
            this.m_CancelButton.Location = new System.Drawing.Point(416, 422);
            this.m_CancelButton.Name = "m_CancelButton";
            this.m_CancelButton.Size = new System.Drawing.Size(75, 23);
            this.m_CancelButton.TabIndex = 11;
            this.m_CancelButton.Text = "Cancel";
            this.m_CancelButton.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 457);
            this.Controls.Add(this.m_CancelButton);
            this.Controls.Add(this.m_SaveCustomerButton);
            this.Controls.Add(this.m_BillingMethodGroupBox);
            this.Controls.Add(this.m_AddressGroupBox);
            this.Controls.Add(this.m_MemberSinceDateTimePicker);
            this.Controls.Add(this.m_BirthDateDateTimePicker);
            this.Controls.Add(this.m_LastNameTextBox);
            this.Controls.Add(this.m_FirstNameTextBox);
            this.Controls.Add(this.m_BirthDateLabel);
            this.Controls.Add(this.m_MemberSinceLabel);
            this.Controls.Add(this.m_LastNameLabel);
            this.Controls.Add(this.m_FirstNameLabel);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.m_AddressGroupBox.ResumeLayout(false);
            this.m_BillingMethodGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_FirstNameLabel;
        private System.Windows.Forms.Label m_LastNameLabel;
        private System.Windows.Forms.Label m_MemberSinceLabel;
        private System.Windows.Forms.Label m_BirthDateLabel;
        private System.Windows.Forms.TextBox m_FirstNameTextBox;
        private System.Windows.Forms.TextBox m_LastNameTextBox;
        private System.Windows.Forms.DateTimePicker m_BirthDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker m_MemberSinceDateTimePicker;
        private System.Windows.Forms.GroupBox m_AddressGroupBox;
        private System.Windows.Forms.TabControl m_AddressTabControl;
        private System.Windows.Forms.GroupBox m_BillingMethodGroupBox;
        private System.Windows.Forms.TabControl m_BillingMethodTabControl;
        private System.Windows.Forms.Button m_SaveCustomerButton;
        private System.Windows.Forms.Button m_CancelButton;
        private System.Windows.Forms.Button m_DeleteAddressButton;
        private System.Windows.Forms.Button m_CreateAddressButton;
        private System.Windows.Forms.Button m_DeleteBillingMethodButton;
        private System.Windows.Forms.Button m_CreateBillingMethodButton;
    }
}