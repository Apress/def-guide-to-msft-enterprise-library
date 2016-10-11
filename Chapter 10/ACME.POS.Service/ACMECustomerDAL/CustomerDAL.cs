using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Data;
using ACME.POS.Domain.Entity;
using ACME.POS.Service.BusinessEntities;

namespace ACME.POS.Domain.DAL
{
    public class CustomerDAL
    {
        Database m_CustomerDb;

        public CustomerDAL()
        {
            m_CustomerDb = DatabaseFactory.CreateDatabase();
        }

        public CustomerList GetAllCustomers()
        {
            CustomerList customers = new CustomerList();
            DbCommand command = m_CustomerDb.GetStoredProcCommand("usp_Customer_List");
            
            using(IDataReader reader = m_CustomerDb.ExecuteReader(command))
            {
                Customer customer;
                while (reader.Read())
                {
                    customer = new Customer();
                    customer.CustomerId = (int)reader["CustomerId"];
                    customer.FirstName = (string)reader["FirstName"];
                    customer.LastName = (string)reader["LastName"];
                    customer.BirthDate = (DateTime)reader["BirthDate"];
                    customer.MemberSince= (DateTime)reader["MemberSince"];
                    customer.IsActive = true;
                    customers.Add(customer);
                }
            }
            return customers;
        }

        public void SaveCustomers(CustomerList customers)
        {
            DbCommand command = m_CustomerDb.GetStoredProcCommand("usp_Customer_Save");
            m_CustomerDb.AddInParameter(command, "FirstName", DbType.String);
            m_CustomerDb.AddInParameter(command, "LastName", DbType.String);
            m_CustomerDb.AddInParameter(command, "BirthDate", DbType.String);
            m_CustomerDb.AddInParameter(command, "MemberSince", DbType.String);
            m_CustomerDb.AddInParameter(command, "IsActive", DbType.Boolean);
            m_CustomerDb.AddOutParameter(command, "CustomerId", DbType.Int32, 4);

            foreach (Customer customer in customers)
            {
                if (customer.IsModified)
                {
                    m_CustomerDb.SetParameterValue(command,
                    "FirstName", customer.FirstName);
                    m_CustomerDb.SetParameterValue(command,
                    "LastName", customer.LastName);
                    m_CustomerDb.SetParameterValue(command,
                    "BirthDate", customer.BirthDate);
                    m_CustomerDb.SetParameterValue(command,
                    "MemberSince", customer.MemberSince);
                    m_CustomerDb.SetParameterValue(command,
                    "IsActive", customer.IsActive);
                    m_CustomerDb.SetParameterValue(command,
                    "CustomerId", customer.CustomerId);
                    m_CustomerDb.ExecuteNonQuery(command);

                    if (customer.CustomerId < 1)
                        customer.CustomerId = (int)m_CustomerDb.GetParameterValue(command, "CustomerId");

                    customer.IsModified = false;
                }
            }
        }
    }
}
