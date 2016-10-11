using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using ACME.POS.Service.Client.ACMECustomerWebService;

namespace ACME.POS.Service.Client
{
    public class CustomerListViewItem : ListViewItem
    {
        private Customer m_Customer;

        public Customer Customer
        {
            get { return m_Customer; }
            set { m_Customer = value; }
        }

        public CustomerListViewItem(Customer customer)
        {
            m_Customer = customer;
            RefreshCustomer();
        }

        internal void RefreshCustomer()
        {
            this.Text = m_Customer.FirstName + " " + m_Customer.LastName;
        }
    }
}
