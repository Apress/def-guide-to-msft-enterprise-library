using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.PolicyInjection.CallHandlers;
using ACME.POS.Service.Client.ACMECustomerWebService;

namespace ACME.POS.Service.Client
{
    public partial class CustomerForm : Form
    {
        private Customer m_Customer;

        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            m_Customer = customer;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void m_SaveCustomerButton_Click(object sender, EventArgs e)
        {

        }

        
    }
}