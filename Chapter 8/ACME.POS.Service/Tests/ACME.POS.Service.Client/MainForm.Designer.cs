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
            this.SearchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_GetStatesButton = new System.Windows.Forms.Button();
            this.m_GetCustomerListTestButton = new System.Windows.Forms.Button();
            this.m_SaveCustomerButton = new System.Windows.Forms.Button();
            this.m_ExceptionTestButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExecuteButton
            // 
            this.ExecuteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExecuteButton.Location = new System.Drawing.Point(279, 14);
            this.ExecuteButton.Name = "ExecuteButton";
            this.ExecuteButton.Size = new System.Drawing.Size(65, 23);
            this.ExecuteButton.TabIndex = 1;
            this.ExecuteButton.Text = "&Execute";
            this.ExecuteButton.Click += new System.EventHandler(this.ExecuteButton_Click);
            // 
            // SearchText
            // 
            this.SearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchText.Location = new System.Drawing.Point(58, 16);
            this.SearchText.Name = "SearchText";
            this.SearchText.Size = new System.Drawing.Size(215, 20);
            this.SearchText.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search:";
            // 
            // m_GetStatesButton
            // 
            this.m_GetStatesButton.Location = new System.Drawing.Point(58, 134);
            this.m_GetStatesButton.Name = "m_GetStatesButton";
            this.m_GetStatesButton.Size = new System.Drawing.Size(134, 23);
            this.m_GetStatesButton.TabIndex = 3;
            this.m_GetStatesButton.Text = "Get States Test";
            this.m_GetStatesButton.UseVisualStyleBackColor = true;
            this.m_GetStatesButton.Click += new System.EventHandler(this.m_GetStatesButton_Click);
            // 
            // m_GetCustomerListTestButton
            // 
            this.m_GetCustomerListTestButton.Location = new System.Drawing.Point(58, 93);
            this.m_GetCustomerListTestButton.Name = "m_GetCustomerListTestButton";
            this.m_GetCustomerListTestButton.Size = new System.Drawing.Size(134, 23);
            this.m_GetCustomerListTestButton.TabIndex = 6;
            this.m_GetCustomerListTestButton.Text = "Get Customer List Test";
            this.m_GetCustomerListTestButton.UseVisualStyleBackColor = true;
            this.m_GetCustomerListTestButton.Click += new System.EventHandler(this.m_GetCustomerListTestButton_Click);
            // 
            // m_SaveCustomerButton
            // 
            this.m_SaveCustomerButton.Location = new System.Drawing.Point(58, 51);
            this.m_SaveCustomerButton.Name = "m_SaveCustomerButton";
            this.m_SaveCustomerButton.Size = new System.Drawing.Size(134, 23);
            this.m_SaveCustomerButton.TabIndex = 5;
            this.m_SaveCustomerButton.Text = "Save Customer Test";
            this.m_SaveCustomerButton.UseVisualStyleBackColor = true;
            this.m_SaveCustomerButton.Click += new System.EventHandler(this.m_SaveCustomerTestButton_Click);
            // 
            // m_ExceptionTestButton
            // 
            this.m_ExceptionTestButton.Location = new System.Drawing.Point(210, 51);
            this.m_ExceptionTestButton.Name = "m_ExceptionTestButton";
            this.m_ExceptionTestButton.Size = new System.Drawing.Size(134, 23);
            this.m_ExceptionTestButton.TabIndex = 7;
            this.m_ExceptionTestButton.Text = "Exception Handling Test";
            this.m_ExceptionTestButton.UseVisualStyleBackColor = true;
            this.m_ExceptionTestButton.Click += new System.EventHandler(this.m_ExceptionTestButton_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.ExecuteButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 175);
            this.Controls.Add(this.m_ExceptionTestButton);
            this.Controls.Add(this.m_GetCustomerListTestButton);
            this.Controls.Add(this.m_SaveCustomerButton);
            this.Controls.Add(this.m_GetStatesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchText);
            this.Controls.Add(this.ExecuteButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExecuteButton;
        private System.Windows.Forms.TextBox SearchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_GetStatesButton;
        private System.Windows.Forms.Button m_GetCustomerListTestButton;
        private System.Windows.Forms.Button m_SaveCustomerButton;
        private System.Windows.Forms.Button m_ExceptionTestButton;

    }
}