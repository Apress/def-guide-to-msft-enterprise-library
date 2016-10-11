using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DGTEL.SampleAB;

namespace SampleABTestHarness
{
    public partial class SampleABForm : Form
    {
        public SampleABForm()
        {
            InitializeComponent();
        }

        private void m_DoMathButton_Click(object sender, EventArgs e)
        {
            ISampleProvider math = SampleProviderFactory.CreateSampleProvider();

            int result = math.DoMath(Convert.ToInt32(m_XTextBox.Text, 10),
                Convert.ToInt32(m_YTextBox.Text, 10));

            m_ResultLabel.Text = result.ToString();
        }
    }
}