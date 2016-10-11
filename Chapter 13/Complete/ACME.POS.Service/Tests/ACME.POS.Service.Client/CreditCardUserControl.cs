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
    public partial class CreditCardUserControl : UserControl
    {
        private BillingMethod m_BillingMethod;
        private Address[] m_Addresses;

        public BillingMethod BillingMethod
        {
            get { return m_BillingMethod; }
        }

        public CreditCardUserControl(BillingMethod billingMethod, Address[] addresses)
        {
            InitializeComponent();
            m_BillingMethod = billingMethod;
            m_Addresses = addresses;
        }

        private void CreditCardUserControl_Load(object sender, EventArgs e)
        {
            m_ExpirationMaskedTextBox.Text =
                m_BillingMethod.CreditCardExpiration.Month.ToString() + "/"
                + m_BillingMethod.CreditCardExpiration.Year.ToString();

            m_CardNumberTextBox.Text = m_BillingMethod.CreditCardNumber;

            BuildBillingAddressComboBox();
        }

        private void BuildBillingAddressComboBox()
        {
            m_BillingAddressComboBox.Items.Clear();

            for (int i = 0; i < m_Addresses.Length; i++)
            {
                m_BillingAddressComboBox.Items.Add(
                    new BillingAddress(m_Addresses[i].AddressId,
                        m_Addresses[i].StreetAddress, 
                        m_Addresses[i].City,
                        m_Addresses[i].State,
                        m_Addresses[i].Zipcode));

                if (m_BillingMethod.CreditCardBillingAddressId == m_Addresses[i].AddressId)
                    m_BillingAddressComboBox.SelectedIndex = i;
            }
        }

        private void m_CardNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            m_BillingMethod.CreditCardNumber = m_CardNumberTextBox.Text;
        }

        private void m_ExpirationMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            Int32 month, year;

            String[] splitExp = m_ExpirationMaskedTextBox.Text.Split('/');

            if(splitExp.Length == 2 && Int32.TryParse(splitExp[0], out month) 
                && Int32.TryParse(splitExp[1], out year))
            {
                m_BillingMethod.CreditCardExpiration = new DateTime(year, month, 1);
            }
        }

        private void m_BillingAddressComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            BillingAddress address = m_BillingAddressComboBox.SelectedItem as BillingAddress;

            if (address != null)
            {
                m_BillingMethod.CreditCardBillingAddressId = address.AddressId;
            }
        }
    }
}
