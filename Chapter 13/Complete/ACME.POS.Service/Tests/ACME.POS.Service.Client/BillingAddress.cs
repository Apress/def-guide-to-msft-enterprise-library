using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.POS.Service.Client
{
    public class BillingAddress
    {
        private Int32 m_AddressId;
        private String m_AddressText;

        public BillingAddress(Int32 addressId, String streetAddress, 
            String city, String state, String zipcode)
        {
            m_AddressId = addressId;
            m_AddressText = streetAddress + ", " + city + ", " + state + ", " + zipcode;
        }

        public Int32 AddressId
        {
            get { return m_AddressId; }
        }

        public override string ToString()
        {
            return m_AddressText;
        }
    }
}
