using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using ACME.POS.Service.Client.ACMECustomerWebService;
using ACME.POS.UI.Model;
using ACME.POS.Service.Client.ACMEStateWebService;

namespace ACME.POS.Service.Client
{
    public partial class AddressUserControl : UserControl
    {
        private Address m_Address;

        public Address Address
        {
            get { return m_Address; }
        }

        public AddressUserControl(Address address)
        {
            InitializeComponent();
            m_Address = address;
        }

        private void AddressUserControl_Load(object sender, EventArgs e)
        {
            LoadStates();
            LoadAddress();
        }

        private void LoadAddress()
        {
            m_StreetAddressTextBox.Text = m_Address.StreetAddress;
            m_CityTextBox.Text = m_Address.City;
            m_StateComboBox.SelectedItem = m_Address.State;
            m_ZipCodeMaskedTextBox.Text = m_Address.Zipcode;
            m_PrimaryShippingAddressCheckbox.Checked = m_Address.IsPrimaryShipping;
        }

        private void LoadStates()
        {
            ACMEModel model = new ACMEModel();
            State[] states = model.GetStates();

            for (int i = 0; i < states.Length; i++)
            {
                m_StateComboBox.Items.Add(states[i].Abbrv);
            }
        }

        private void m_StreetAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            m_Address.StreetAddress = m_StreetAddressTextBox.Text;
        }

        private void m_CityTextBox_TextChanged(object sender, EventArgs e)
        {
            m_Address.City = m_CityTextBox.Text;
        }

        private void m_ZipCodeMaskedTextBox_TextChanged(object sender, EventArgs e)
        {
            m_Address.Zipcode = m_ZipCodeMaskedTextBox.Text;
        }

        private void m_StateComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            m_Address.State = m_StateComboBox.SelectedItem as String;
        }

        private void m_PrimaryShippingAddressCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            m_Address.IsPrimaryShipping = m_PrimaryShippingAddressCheckbox.Checked;
        }


    }
}
