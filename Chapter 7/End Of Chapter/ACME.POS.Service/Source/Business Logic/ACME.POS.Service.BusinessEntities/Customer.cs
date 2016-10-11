using System;
using System.Collections.Generic;
using System.Text;
using ACME.POS.Service.BusinessEntities;

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

    }
}
