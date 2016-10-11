using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ACME.POS.Service.Client
{
    public partial class NewBillingMethodForm : Form
    {
        public NewBillingMethodForm()
        {
            InitializeComponent();
        }

        private void m_SelectButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public Int32 PaymentMethodId
        {
            get 
            {
                if (m_CreditCardRadioButton.Checked)
                    return 1;
                else
                    return 2;
            }
        }
    }
}