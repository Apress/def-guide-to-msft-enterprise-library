using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.POS.Domain.Entity
{
    
    public class Customer : EntityBase
    {
        private int m_CustomerId;
        private string m_FirstName;
        private string m_LastName;
        private DateTime m_MemberSince;
        private DateTime m_BirthDate;
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

        public bool IsActive
        {
            get { return m_IsActive; }
            set { m_IsActive = value; }
        }

    }
}
