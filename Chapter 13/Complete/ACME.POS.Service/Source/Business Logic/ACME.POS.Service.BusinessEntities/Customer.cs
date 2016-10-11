using System;
using System.Collections.Generic;
using System.Text;
using ACME.POS.Service.BusinessEntities;
using System.Xml;

namespace ACME.POS.Domain.Entity
{
    public class EntityBase
    {
        private bool m_IsModified;

        public bool IsModified
        {
            get { return m_IsModified; }
            set { m_IsModified = value; }
        }
    }
    public class Customer : EntityBase
    {
        private int m_CustomerId;
        private string m_FirstName;
        private string m_LastName;
        private DateTime m_MemberSince;
        private DateTime m_BirthDate;
        private AddressList m_Addresses;
        private BillingMethodList m_BillingMethods;
        private bool m_IsActive;

        public int CustomerId
        {
            get { return m_CustomerId; }
            set { m_CustomerId = value; }
        }

        public string FirstName
        {
            get { return m_FirstName; }
            set { m_FirstName = value; }
        }

        public string LastName
        {
            get { return m_LastName; }
            set { m_LastName = value; }
        }

        public DateTime MemberSince
        {
            get { return m_MemberSince; }
            set { m_MemberSince = value; }
        }

        public DateTime BirthDate
        {
            get { return m_BirthDate; }
            set { m_BirthDate = value; }
        }

        public AddressList Addresses
        {
            get { return m_Addresses; }
            set { m_Addresses = value; }
        }

        public BillingMethodList BillingMethods
        {
            get { return m_BillingMethods; }
            set { m_BillingMethods = value; }
        }

        public bool IsActive
        {
            get { return m_IsActive; }
            set { m_IsActive = value; }
        }

        
    }

    public class CustomerList : List<Customer>
    {
        private String m_EmployeeId;

        public String EmployeeId
        {
            get { return m_EmployeeId; }
            set { m_EmployeeId = value; }
        }

        public CustomerList ModifiedCustomers
        {
            get
            {
                return GetModifiedCustomers();
            }
        }

        private CustomerList GetModifiedCustomers()
        {
            CustomerList modified = new CustomerList();

            foreach (Customer customer in this)
            {
                if (customer.IsModified) modified.Add(customer);
            }

            modified.EmployeeId = this.EmployeeId;

            return modified;
        }

        public String ToXmlString()
        {
            //Just going to use an XmlWriter here
            StringBuilder sb = new StringBuilder();
            XmlWriter writer = XmlWriter.Create(sb);
            writer.WriteStartElement("customers");

            foreach (Customer customer in this)
            {
                writer.WriteStartElement("customer");
                writer.WriteAttributeString("customerId", customer.CustomerId.ToString());
                writer.WriteAttributeString("firstName", customer.FirstName);
                writer.WriteAttributeString("lastName", customer.LastName);
                writer.WriteAttributeString("memberSince", customer.MemberSince.ToShortDateString());
                writer.WriteAttributeString("birthDate", customer.BirthDate.ToShortDateString());
                writer.WriteAttributeString("isActive", customer.IsActive.ToString());

                if (customer.Addresses != null)
                {
                    foreach (Address address in customer.Addresses)
                    {
                        AddAddressXml(address, writer);
                    }
                }

                if (customer.BillingMethods != null)
                {
                    foreach (BillingMethod billingMethod in customer.BillingMethods)
                    {
                        AddBillingMethodXml(billingMethod, writer);
                    }
                }

                writer.WriteEndElement();
            }

            writer.WriteEndElement();
            writer.Flush();

            return sb.ToString();
        }

        private void AddAddressXml(Address address, XmlWriter writer)
        {
            writer.WriteStartElement("address");
            writer.WriteAttributeString("addressId", address.AddressId.ToString());
            writer.WriteAttributeString("streetAddress", address.StreetAddress);
            writer.WriteAttributeString("city", address.City);
            writer.WriteAttributeString("state", address.State);
            writer.WriteAttributeString("zipCode", address.ZipCode);
            writer.WriteAttributeString("isPrimaryShipping", address.IsPrimaryShipping.ToString());
            writer.WriteAttributeString("isActive", address.IsActive.ToString());

            writer.WriteEndElement();
        }

        private void AddBillingMethodXml(BillingMethod billingMethod, XmlWriter writer)
        {
            writer.WriteStartElement("billingMethod");
            writer.WriteAttributeString("billingMethodId", billingMethod.BillingMethodId.ToString());
            writer.WriteAttributeString("paymentMethodId", billingMethod.PaymentMethodId.ToString());


            if (billingMethod.PaymentMethodId == 1)
            {
                writer.WriteAttributeString("creditCardNumber", billingMethod.CreditCardNumber);
                writer.WriteAttributeString("creditCardExpiration",
                    billingMethod.CreditCardExpiration.Value.ToShortDateString());
                writer.WriteAttributeString("creditCardBillingAddressId",
                    billingMethod.CreditCardBillingAddressId.ToString());
            }
            else
            {
                writer.WriteAttributeString("netTermDays", billingMethod.NetTermDays.Value.ToString());
            }

            writer.WriteAttributeString("isActive", billingMethod.IsActive.ToString());

            writer.WriteEndElement();
        }
    }
}
