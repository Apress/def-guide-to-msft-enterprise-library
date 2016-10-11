using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ACME.POS.Service.Client.ACMECustomerWebService;
using ACME.POS.UI.Model;
using Microsoft.Practices.EnterpriseLibrary.PolicyInjection;

namespace ACME.POS.Service.Client
{
    public partial class SearchForm : Form
    {
        ACMEModel m_Model;

        public SearchForm()
        {
            InitializeComponent();
            m_Model = new ACMEModel();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            RefreshCustomers();
        }

        private void RefreshCustomers()
        {
            Customer[] customers;

            try
            {
                customers = m_Model.GetCustomers();

                m_CustomerListView.Items.Clear();

                for (int i = 0; i < customers.Length; i++)
                {
                    m_CustomerListView.Items.Add(new CustomerListViewItem(customers[i]));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveCustomer(CustomerForm dialog)
        {
            try
            {
                ICustomer ic = PolicyInjection.Wrap<ICustomer>(dialog);
                ic.Save();

                RefreshCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void m_CreateCustomerButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            customer.MemberSince = DateTime.Now;
            customer.BirthDate = DateTime.Now;
            customer.IsActive = true;
            customer.IsModified = true;

            CustomerForm dialog = new CustomerForm(customer);

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                SaveCustomer(dialog);
            }

            dialog.Close();
            dialog.Dispose();
            
        }

        private void m_EditCustomerButton_Click(object sender, EventArgs e)
        {
            if (m_CustomerListView.SelectedItems.Count == 1)
            {
                CustomerListViewItem customer = m_CustomerListView.SelectedItems[0] as CustomerListViewItem;
                CustomerForm dialog = new CustomerForm(customer.Customer);
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    SaveCustomer(dialog);
                }

                dialog.Close();
                dialog.Dispose();
            }
        }

        private void m_DeleteCustomerButton_Click(object sender, EventArgs e)
        {
            if (m_CustomerListView.SelectedItems.Count == 1)
            {
                CustomerListViewItem customerListViewItem = 
                    m_CustomerListView.SelectedItems[0] as CustomerListViewItem;

                customerListViewItem.Customer.IsActive = false;
                customerListViewItem.Customer.IsModified = true;

                m_Model.SaveCustomer(customerListViewItem.Customer);

                RefreshCustomers();
            }
        }
    }
}