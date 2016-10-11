namespace ACME.POS.Service.Client
{
    partial class SearchForm
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
            this.m_CustomerListView = new System.Windows.Forms.ListView();
            this.m_CreateCustomerButton = new System.Windows.Forms.Button();
            this.m_EditCustomerButton = new System.Windows.Forms.Button();
            this.m_DeleteCustomerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_CustomerListView
            // 
            this.m_CustomerListView.Location = new System.Drawing.Point(13, 13);
            this.m_CustomerListView.Name = "m_CustomerListView";
            this.m_CustomerListView.Size = new System.Drawing.Size(497, 289);
            this.m_CustomerListView.TabIndex = 0;
            this.m_CustomerListView.UseCompatibleStateImageBehavior = false;
            // 
            // m_CreateCustomerButton
            // 
            this.m_CreateCustomerButton.Location = new System.Drawing.Point(13, 320);
            this.m_CreateCustomerButton.Name = "m_CreateCustomerButton";
            this.m_CreateCustomerButton.Size = new System.Drawing.Size(107, 23);
            this.m_CreateCustomerButton.TabIndex = 1;
            this.m_CreateCustomerButton.Text = "Create Customer";
            this.m_CreateCustomerButton.UseVisualStyleBackColor = true;
            this.m_CreateCustomerButton.Click += new System.EventHandler(this.m_CreateCustomerButton_Click);
            // 
            // m_EditCustomerButton
            // 
            this.m_EditCustomerButton.Location = new System.Drawing.Point(290, 320);
            this.m_EditCustomerButton.Name = "m_EditCustomerButton";
            this.m_EditCustomerButton.Size = new System.Drawing.Size(107, 23);
            this.m_EditCustomerButton.TabIndex = 2;
            this.m_EditCustomerButton.Text = "Edit Customer";
            this.m_EditCustomerButton.UseVisualStyleBackColor = true;
            this.m_EditCustomerButton.Click += new System.EventHandler(this.m_EditCustomerButton_Click);
            // 
            // m_DeleteCustomerButton
            // 
            this.m_DeleteCustomerButton.Location = new System.Drawing.Point(403, 320);
            this.m_DeleteCustomerButton.Name = "m_DeleteCustomerButton";
            this.m_DeleteCustomerButton.Size = new System.Drawing.Size(107, 23);
            this.m_DeleteCustomerButton.TabIndex = 3;
            this.m_DeleteCustomerButton.Text = "Delete Customer";
            this.m_DeleteCustomerButton.UseVisualStyleBackColor = true;
            this.m_DeleteCustomerButton.Click += new System.EventHandler(this.m_DeleteCustomerButton_Click);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 355);
            this.Controls.Add(this.m_DeleteCustomerButton);
            this.Controls.Add(this.m_EditCustomerButton);
            this.Controls.Add(this.m_CreateCustomerButton);
            this.Controls.Add(this.m_CustomerListView);
            this.Name = "SearchForm";
            this.Text = "Search for Customer";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView m_CustomerListView;
        private System.Windows.Forms.Button m_CreateCustomerButton;
        private System.Windows.Forms.Button m_EditCustomerButton;
        private System.Windows.Forms.Button m_DeleteCustomerButton;
    }
}