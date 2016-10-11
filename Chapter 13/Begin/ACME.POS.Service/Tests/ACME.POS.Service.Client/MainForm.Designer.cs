namespace ACME.POS.Service.Client
{
    public partial class MainForm : System.Windows.Forms.Form
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
            this.ExecuteButton = new System.Windows.Forms.Button();
            this.m_GetStatesButton = new System.Windows.Forms.Button();
            this.m_GetCustomerListTestButton = new System.Windows.Forms.Button();
            this.m_SaveCustomerButton = new System.Windows.Forms.Button();
            this.m_ExceptionTestButton = new System.Windows.Forms.Button();
            this.m_SaveCustomerToServiceTestButton = new System.Windows.Forms.Button();
            this.m_GetCustomerListFromServiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.Location = new System.Drawing.Point(15, 12);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(65, 23);
            this.ExecuteButton.TabIndex = 1;
            this.ExecuteButton.Text = "&Execute";
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // m_GetStatesButton
            // 
            this.m_GetStatesButton.Location = new System.Drawing.Point(15, 134);
            this.m_GetStatesButton.Name = "m_GetStatesButton";
            this.m_GetStatesButton.Size = new System.Drawing.Size(134, 23);
            this.m_GetStatesButton.TabIndex = 3;
            this.m_GetStatesButton.Text = "Get States Test";
            this.m_GetStatesButton.UseVisualStyleBackColor = true;
            this.m_GetStatesButton.Click += new System.EventHandler(this.m_GetStatesButton_Click);
            // 
            // m_GetCustomerListTestButton
            // 
            this.m_GetCustomerListTestButton.Location = new System.Drawing.Point(15, 93);
            this.m_GetCustomerListTestButton.Name = "m_GetCustomerListTestButton";
            this.m_GetCustomerListTestButton.Size = new System.Drawing.Size(134, 23);
            this.m_GetCustomerListTestButton.TabIndex = 6;
            this.m_GetCustomerListTestButton.Text = "Get Customer List Test";
            this.m_GetCustomerListTestButton.UseVisualStyleBackColor = true;
            this.m_GetCustomerListTestButton.Click += new System.EventHandler(this.m_GetCustomerListTestButton_Click);
            // 
            // m_SaveCustomerButton
            // 
            this.m_SaveCustomerButton.Location = new System.Drawing.Point(15, 51);
            this.m_SaveCustomerButton.Name = "m_SaveCustomerButton";
            this.m_SaveCustomerButton.Size = new System.Drawing.Size(134, 23);
            this.m_SaveCustomerButton.TabIndex = 5;
            this.m_SaveCustomerButton.Text = "Save Customer Test";
            this.m_SaveCustomerButton.UseVisualStyleBackColor = true;
            this.m_SaveCustomerButton.Click += new System.EventHandler(this.m_SaveCustomerTestButton_Click);
            // 
            // m_ExceptionTestButton
            // 
            this.m_ExceptionTestButton.Location = new System.Drawing.Point(155, 134);
            this.m_ExceptionTestButton.Name = "m_ExceptionTestButton";
            this.m_ExceptionTestButton.Size = new System.Drawing.Size(177, 23);
            this.m_ExceptionTestButton.TabIndex = 7;
            this.m_ExceptionTestButton.Text = "Exception Handling Test";
            this.m_ExceptionTestButton.UseVisualStyleBackColor = true;
            this.m_ExceptionTestButton.Click += new System.EventHandler(this.m_ExceptionTestButton_Click);
            // 
            // m_SaveCustomerToServiceTestButton
            // 
            this.m_SaveCustomerToServiceTestButton.Location = new System.Drawing.Point(155, 51);
            this.m_SaveCustomerToServiceTestButton.Name = "m_SaveCustomerToServiceTestButton";
            this.m_SaveCustomerToServiceTestButton.Size = new System.Drawing.Size(177, 23);
            this.m_SaveCustomerToServiceTestButton.TabIndex = 8;
            this.m_SaveCustomerToServiceTestButton.Text = "Save Customer To Service Test";
            this.m_SaveCustomerToServiceTestButton.UseVisualStyleBackColor = true;
            this.m_SaveCustomerToServiceTestButton.Click += new System.EventHandler(this.m_SaveCustomerToServiceTestButton_Click);
            // 
            // m_GetCustomerListFromServiceButton
            // 
            this.m_GetCustomerListFromServiceButton.Location = new System.Drawing.Point(155, 93);
            this.m_GetCustomerListFromServiceButton.Name = "m_GetCustomerListFromServiceButton";
            this.m_GetCustomerListFromServiceButton.Size = new System.Drawing.Size(177, 23);
            this.m_GetCustomerListFromServiceButton.TabIndex = 9;
            this.m_GetCustomerListFromServiceButton.Text = "Customer List From Service Test";
            this.m_GetCustomerListFromServiceButton.UseVisualStyleBackColor = true;
            this.m_GetCustomerListFromServiceButton.Click += new System.EventHandler(this.m_GetCustomerListFromServiceButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.ExecuteButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 181);
            this.Controls.Add(this.m_GetCustomerListFromServiceButton);
            this.Controls.Add(this.m_SaveCustomerToServiceTestButton);
            this.Controls.Add(this.m_ExceptionTestButton);
            this.Controls.Add(this.m_GetCustomerListTestButton);
            this.Controls.Add(this.m_SaveCustomerButton);
            this.Controls.Add(this.m_GetStatesButton);
            this.Controls.Add(this.ExecuteButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.Button m_GetStatesButton;
        private System.Windows.Forms.Button m_GetCustomerListTestButton;
        private System.Windows.Forms.Button m_SaveCustomerButton;
        private System.Windows.Forms.Button m_ExceptionTestButton;
        private System.Windows.Forms.Button m_SaveCustomerToServiceTestButton;
        private System.Windows.Forms.Button m_GetCustomerListFromServiceButton;

    }
}