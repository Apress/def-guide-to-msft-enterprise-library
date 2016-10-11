namespace SampleABTestHarness
{
    partial class SampleABForm
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
            this.m_XTextBox = new System.Windows.Forms.TextBox();
            this.m_YTextBox = new System.Windows.Forms.TextBox();
            this.m_DoMathButton = new System.Windows.Forms.Button();
            this.m_ResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_XTextBox
            // 
            this.m_XTextBox.Location = new System.Drawing.Point(28, 12);
            this.m_XTextBox.Name = "m_XTextBox";
            this.m_XTextBox.Size = new System.Drawing.Size(100, 20);
            this.m_XTextBox.TabIndex = 1;
            // 
            // m_YTextBox
            // 
            this.m_YTextBox.Location = new System.Drawing.Point(28, 38);
            this.m_YTextBox.Name = "m_YTextBox";
            this.m_YTextBox.Size = new System.Drawing.Size(100, 20);
            this.m_YTextBox.TabIndex = 3;
            // 
            // m_DoMathButton
            // 
            this.m_DoMathButton.Location = new System.Drawing.Point(28, 64);
            this.m_DoMathButton.Name = "m_DoMathButton";
            this.m_DoMathButton.Size = new System.Drawing.Size(100, 23);
            this.m_DoMathButton.TabIndex = 4;
            this.m_DoMathButton.Text = "Do Math";
            this.m_DoMathButton.UseVisualStyleBackColor = true;
            this.m_DoMathButton.Click += new System.EventHandler(this.m_DoMathButton_Click);
            // 
            // m_ResultLabel
            // 
            this.m_ResultLabel.AutoSize = true;
            this.m_ResultLabel.Location = new System.Drawing.Point(49, 100);
            this.m_ResultLabel.Name = "m_ResultLabel";
            this.m_ResultLabel.Size = new System.Drawing.Size(54, 13);
            this.m_ResultLabel.TabIndex = 5;
            this.m_ResultLabel.Text = "<Results>";
            this.m_ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SampleABForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(156, 135);
            this.Controls.Add(this.m_ResultLabel);
            this.Controls.Add(this.m_DoMathButton);
            this.Controls.Add(this.m_YTextBox);
            this.Controls.Add(this.m_XTextBox);
            this.Name = "SampleABForm";
            this.Text = "Test Harness";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_XTextBox;
        private System.Windows.Forms.TextBox m_YTextBox;
        private System.Windows.Forms.Button m_DoMathButton;
        private System.Windows.Forms.Label m_ResultLabel;
    }
}

