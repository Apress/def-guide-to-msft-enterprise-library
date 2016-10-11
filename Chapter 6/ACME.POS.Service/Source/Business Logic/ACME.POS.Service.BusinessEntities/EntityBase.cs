using System;
using System.Collections.Generic;
using System.Text;

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
}
