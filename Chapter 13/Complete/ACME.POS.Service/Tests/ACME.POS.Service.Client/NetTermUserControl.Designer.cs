namespace ACME.POS.Service.Client
{
    partial class NetTermUserControl
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
            this.m_NetTermDaysLabel = new System.Windows.Forms.Label();
            this.m_NetTermDaysNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.m_NetTermDaysNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // m_NetTermDaysLabel
            // 
            this.m_NetTermDaysLabel.AutoSize = true;
            this.m_NetTermDaysLabel.Location = new System.Drawing.Point(3, 17);
            this.m_NetTermDaysLabel.Name = "m_NetTermDaysLabel";
            this.m_NetTermDaysLabel.Size = new System.Drawing.Size(84, 13);
            this.m_NetTermDaysLabel.TabIndex = 0;
            this.m_NetTermDaysLabel.Text = "Net Term Days :";
            // 
            // m_NetTermDaysNumericUpDown
            // 
            this.m_NetTermDaysNumericUpDown.Location = new System.Drawing.Point(93, 15);
            this.m_NetTermDaysNumericUpDown.Maximum = new decimal(new int[] {
            730,
            0,
            0,
            0});
            this.m_NetTermDaysNumericUpDown.Name = "m_NetTermDaysNumericUpDown";
            this.m_NetTermDaysNumericUpDown.Size = new System.Drawing.Size(52, 20);
            this.m_NetTermDaysNumericUpDown.TabIndex = 1;
            this.m_NetTermDaysNumericUpDown.ValueChanged += new System.EventHandler(this.m_NetTermDaysNumericUpDown_ValueChanged);
            // 
            // NetTermUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_NetTermDaysNumericUpDown);
            this.Controls.Add(this.m_NetTermDaysLabel);
            this.Name = "NetTermUserControl";
            this.Size = new System.Drawing.Size(396, 49);
            this.Load += new System.EventHandler(this.NetTermUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_NetTermDaysNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_NetTermDaysLabel;
        private System.Windows.Forms.NumericUpDown m_NetTermDaysNumericUpDown;
    }
}
