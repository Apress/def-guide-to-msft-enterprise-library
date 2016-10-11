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
using ACME.POS.Domain;
using ACME.POS.Service.BusinessEntities;

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

            //Adding address so it is logged
            customer.Addresses = new AddressList();
            customer.Addresses.Add(new Address("0000 Some St.", 0, "A City", 0, true, true, "IL", "00000"));
            
            //Adding Billing Methos so it logged
            customer.BillingMethods = new BillingMethodList();
            customer.BillingMethods.Add(new BillingMethod(0, null, null, String.Empty, 0, true, 30, 2));
            
            list.Add(customer);

            list.EmployeeId = Environment.UserName;

            BusinessRules rules = new BusinessRules();
            rules.SaveCustomerData(list);

            //Using business rules now
            //CustomerDAL dal = new CustomerDAL();
            //dal.SaveCustomers(list);
        }

        private void m_GetCustomerListTestButton_Click(object sender, EventArgs e)
        {
            BusinessRules rules = new BusinessRules();
            CustomerList list = rules.GetAllCustomers(Environment.UserName);

            //Using business rules now
            //CustomerDAL dal = new CustomerDAL();
            //CustomerList list = dal.GetAllCustomers();

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

        private void m_SaveCustomerToServiceTestButton_Click(object sender, EventArgs e)
        {
            OfflineManager manager = new OfflineManager();
            ACME.POS.Service.Client.ACMECustomerWebService.Customer[] customers = 
                new ACME.POS.Service.Client.ACMECustomerWebService.Customer[1];

            ACME.POS.Service.Client.ACMECustomerWebService.Customer customer = 
                new ACME.POS.Service.Client.ACMECustomerWebService.Customer();
            customer.FirstName = "Test";
            customer.LastName = "Test";
            customer.MemberSince = DateTime.Now;
            customer.CustomerId = 0;
            customer.BirthDate = DateTime.Now;
            customer.IsActive = true;
            customer.IsModified = true;

            customer.Addresses = new ACME.POS.Service.Client.ACMECustomerWebService.Address[1];
            ACME.POS.Service.Client.ACMECustomerWebService.Address address = new 
                ACME.POS.Service.Client.ACMECustomerWebService.Address();
            address.StreetAddress = "0000 Some St.";
            address.AddressId = 0;
            address.City = "A City";
            address.CustomerId = 0;
            address.IsPrimaryShipping = true;
            address.IsActive = true;
            address.State = "IL";
            address.Zipcode = "00000";
            customer.Addresses[0] = address;

            customer.BillingMethods = new ACME.POS.Service.Client.ACMECustomerWebService.BillingMethod[1];
            ACME.POS.Service.Client.ACMECustomerWebService.BillingMethod billingMethod = 
                new ACME.POS.Service.Client.ACMECustomerWebService.BillingMethod();
            billingMethod.BillingMethodId = 0;
            billingMethod.CreditCardExpiration = DateTime.MinValue;
            billingMethod.CreditCardBillingAddressId = 0;
            billingMethod.CustomerId = 0;
            billingMethod.IsActive = true;
            billingMethod.NetTermDays = 30;
            billingMethod.PaymentMethodId = 2;
            customer.BillingMethods[0] = billingMethod;

            customers[0] = customer;

            manager.SaveData(customers);
        }

        private void m_GetCustomerListFromServiceButton_Click(object sender, EventArgs e)
        {
            OfflineManager manager = new OfflineManager();
            ACME.POS.Service.Client.ACMECustomerWebService.Customer[] customers = 
                manager.ReadCustomerData();
            MessageBox.Show("Records returned from service : " + customers.Length.ToString());
        }
    }
}