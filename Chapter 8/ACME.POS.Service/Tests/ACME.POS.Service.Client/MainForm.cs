using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ACME.POS.Domain.DAL;
using ACME.POS.Domain.Entity;
using ACME.POS.UI.Model;
using ACME.POS.Service.Client.ACMEStateWebService;

namespace ACME.POS.Service.Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ExecuteButton_Click(object sender, EventArgs e)
        {
            //TODO: Call proxy method
        }

        private void m_SaveCustomerTestButton_Click(object sender, EventArgs e)
        {
            SaveCustomerTest();
        }


        public void SaveCustomerTest()
        {
            CustomerList list = new CustomerList();
            Customer customer = new Customer();
            customer.FirstName = "Test";
            customer.LastName = "Test";
            customer.MemberSince = DateTime.Now;
            customer.CustomerId = 0;
            customer.BirthDate = DateTime.Now;
            customer.IsActive = true;
            customer.IsModified = true;
            list.Add(customer);

            CustomerDAL dal = new CustomerDAL();
            dal.SaveCustomers(list);
        }

        private void m_GetCustomerListTestButton_Click(object sender, EventArgs e)
        {
            CustomerDAL dal = new CustomerDAL();
            CustomerList list = dal.GetAllCustomers();
            MessageBox.Show("Records returned : " + list.Count.ToString());
        }

        private void m_GetStatesButton_Click(object sender, EventArgs e)
        {
            ACMEModel test = new ACMEModel();
            State[] states = test.GetStates();
            MessageBox.Show("States Returned : " + states.Length.ToString());
        }

        private void m_ExceptionTestButton_Click(object sender, EventArgs e)
        {
            throw new Exception("This is a test exception");
        }
    }
}