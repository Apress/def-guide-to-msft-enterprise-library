using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.PolicyInjection.CallHandlers;
using ACME.POS.Service.Client.ACMECustomerWebService;
using ACME.POS.UI.Model;

namespace ACME.POS.Service.Client
{
    public partial class CustomerForm : Form, ICustomer
    {
        private Customer m_Customer;

        public CustomerForm(Customer customer)
        {
            InitializeComponent();
            m_Customer = customer;
        }

        public Customer Customer
        {
            get { return m_Customer; }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomer();
        }

        private void LoadCustomer()
        {
            m_FirstNameTextBox.Text = m_Customer.FirstName;
            m_LastNameTextBox.Text = m_Customer.LastName;
            m_MemberSinceDateTimePicker.Value = m_Customer.MemberSince;
            m_BirthDateDateTimePicker.Value = m_Customer.BirthDate;

            LoadAddresses();
            LoadBillingMethods();
        }

        private void LoadAddresses()
        {
            m_AddressTabControl.TabPages.Clear();

            if (m_Customer.Addresses != null)
            {
                foreach (Address address in m_Customer.Addresses)
                {
                    AddAddress(address);
                }
            }
        }

        private void AddAddress(Address address)
        {
            if (address.IsActive)
            {
                TabPage tabPage = new TabPage("Address");
                AddressUserControl addressUC = new AddressUserControl(address);
                tabPage.Controls.Add(addressUC);
                m_AddressTabControl.TabPages.Add(tabPage);
            }
        }

        private void LoadBillingMethods()
        {
            m_BillingMethodTabControl.TabPages.Clear();

            if (m_Customer.BillingMethods != null)
            {
                foreach (BillingMethod billingMethod in m_Customer.BillingMethods)
                {
                    AddBillingMethod(billingMethod);
                }
            }
        }

        private void AddBillingMethod(BillingMethod billingMethod)
        {
            String paymentMethod;
            UserControl billingMethodUC;

            if (billingMethod.PaymentMethodId == 1)
            {
                paymentMethod = "Credit Card";
                billingMethodUC = new CreditCardUserControl(
                    billingMethod, m_Customer.Addresses);
            }
            else
            {
                paymentMethod = "Net Term";
                billingMethodUC = new NetTermUserControl(billingMethod);
            }

            TabPage tabPage = new TabPage(paymentMethod);
            tabPage.Controls.Add(billingMethodUC);
            m_BillingMethodTabControl.TabPages.Add(tabPage);
        }

        private void m_SaveCustomerButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        #region ICustomer Members

        [ExceptionCallHandler("CustomerSaveExceptionPolicy")]
        public void Save()
        {
            PersistCustomerData();
            ACMEModel model = new ACMEModel();
            model.SaveCustomer(m_Customer);
        }

        #endregion

        private void PersistCustomerData()
        {
            m_Customer.IsModified = true;
            m_Customer.FirstName = m_FirstNameTextBox.Text;
            m_Customer.LastName = m_LastNameTextBox.Text;
            m_Customer.MemberSince = m_MemberSinceDateTimePicker.Value;
            m_Customer.BirthDate = m_BirthDateDateTimePicker.Value;
        }

        private Control GetControl(Control parentControl, Type type)
        {
            foreach (Control control in parentControl.Controls)
            {
                if (control.GetType() == type) return control;
            }
            return null;
        }

        private void m_CreateAddressButton_Click(object sender, EventArgs e)
        {
            Address[] newAddresses = m_Customer.Addresses;

            if (newAddresses != null)
            {
                Array.Resize<Address>(ref newAddresses, m_Customer.Addresses.Length + 1);
                newAddresses[m_Customer.Addresses.Length] = new Address();
                newAddresses[m_Customer.Addresses.Length].IsActive = true;
                m_Customer.Addresses = newAddresses;
            }
            else
            {
                m_Customer.Addresses = new Address[1];
                m_Customer.Addresses[0] = new Address();
                m_Customer.Addresses[0].IsActive = true;
            }

            LoadAddresses();

            m_AddressTabControl.SelectTab(m_AddressTabControl.TabPages.Count - 1);
        }

        private void m_DeleteAddressButton_Click(object sender, EventArgs e)
        {
            if (m_AddressTabControl.SelectedTab != null)
            {
                AddressUserControl control = GetControl(m_AddressTabControl.SelectedTab, typeof(AddressUserControl)) as AddressUserControl;
                control.Address.IsActive = false;
            }

            LoadAddresses();
        }

        private void m_CreateBillingMethodButton_Click(object sender, EventArgs e)
        {
            //Determine Payment Method
            NewBillingMethodForm dialog = new NewBillingMethodForm();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                
                BillingMethod[] newBillingMethods = m_Customer.BillingMethods;

                if (newBillingMethods != null)
                {
                    Array.Resize<BillingMethod>(ref newBillingMethods, m_Customer.BillingMethods.Length + 1);
                    newBillingMethods[m_Customer.BillingMethods.Length] = new BillingMethod();
                    newBillingMethods[m_Customer.BillingMethods.Length].IsActive = true;
                    newBillingMethods[m_Customer.BillingMethods.Length].PaymentMethodId =
                        dialog.PaymentMethodId;
                    m_Customer.BillingMethods = newBillingMethods;
                }
                else
                {
                    m_Customer.BillingMethods = new BillingMethod[1];
                    m_Customer.BillingMethods[0] = new BillingMethod();
                    m_Customer.BillingMethods[0].IsActive = true;
                    m_Customer.BillingMethods[0].PaymentMethodId = dialog.PaymentMethodId;
                }

                LoadBillingMethods();

                m_BillingMethodTabControl.SelectTab(m_BillingMethodTabControl.TabPages.Count - 1);
            }
            dialog.Close();
            dialog.Dispose();
        }

        private void m_DeleteBillingMethodButton_Click(object sender, EventArgs e)
        {
            if (m_BillingMethodTabControl.SelectedTab != null)
            {
                NetTermUserControl netControl = GetControl(m_BillingMethodTabControl.SelectedTab, typeof(NetTermUserControl)) as NetTermUserControl;
                if (netControl != null)
                {
                    netControl.BillingMethod.IsActive = false;
                }
                else
                {
                    CreditCardUserControl ccControl = GetControl(m_BillingMethodTabControl.SelectedTab, typeof(CreditCardUserControl)) as CreditCardUserControl;
                    if (ccControl != null) ccControl.BillingMethod.IsActive = false;
                }
            }

            LoadBillingMethods();
        }

        private void m_CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}