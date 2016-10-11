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
        }

        public CustomerListViewItem(Customer customer)
        {
            m_Customer = customer;
            this.Text = customer.FirstName + " " + customer.LastName;
        }
    }
}
