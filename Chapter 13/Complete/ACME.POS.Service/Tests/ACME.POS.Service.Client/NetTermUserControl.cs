using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ACME.POS.Service.Client.ACMECustomerWebService;

namespace ACME.POS.Service.Client
{
    public partial class NetTermUserControl : UserControl
    {
        private BillingMethod m_BillingMethod;

        public BillingMethod BillingMethod
        {
            get { return m_BillingMethod; }
        }

        public NetTermUserControl(BillingMethod billingMethod)
        {
            InitializeComponent();
            m_BillingMethod = billingMethod;
        }

        private void NetTermUserControl_Load(object sender, EventArgs e)
        {
            m_NetTermDaysNumericUpDown.Value = m_BillingMethod.NetTermDays;
        }

        public String TitleText
        {
            get { return "Net : " + m_BillingMethod.NetTermDays.ToString(); }
        }

        private void m_NetTermDaysNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            m_BillingMethod.NetTermDays = (Int32)m_NetTermDaysNumericUpDown.Value;
        }
    }
}
