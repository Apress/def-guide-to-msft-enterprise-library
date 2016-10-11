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

                    customer.Addresses = GetAddressList(customer.CustomerId);
                    customer.BillingMethods = GetBillingMethodList(customer.CustomerId);

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
            m_CustomerDb.AddParameter(command, "CustomerId", DbType.Int32, 4, 
                ParameterDirection.InputOutput, true, 0, 0, String.Empty, 
                DataRowVersion.Default, DBNull.Value);

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

                    if (customer.Addresses != null && customer.CustomerId >= 1)
                        SaveAddressList(customer.Addresses, customer.CustomerId);

                    if (customer.BillingMethods != null && customer.CustomerId >= 1)
                        SaveBillingMethodList(customer.BillingMethods, customer.CustomerId);

                    customer.IsModified = false;
                }
            }
        }

        private void SaveAddressList(AddressList addressList, Int32 customerId)
        {
            DbCommand command = m_CustomerDb.GetStoredProcCommand("usp_Address_Save");
            m_CustomerDb.AddInParameter(command, "CustomerId", DbType.Int32);
            m_CustomerDb.AddInParameter(command, "Address", DbType.String);
            m_CustomerDb.AddInParameter(command, "City", DbType.String);
            m_CustomerDb.AddInParameter(command, "ZipCode", DbType.String);
            m_CustomerDb.AddInParameter(command, "State", DbType.String);
            m_CustomerDb.AddInParameter(command, "IsPrimaryShipping", DbType.Boolean);
            m_CustomerDb.AddInParameter(command, "IsActive", DbType.Boolean);
            m_CustomerDb.AddParameter(command, "AddressId", DbType.Int32, 4,
                ParameterDirection.InputOutput, true, 0, 0, String.Empty,
                DataRowVersion.Default, DBNull.Value);

            foreach (Address address in addressList)
            {
                m_CustomerDb.SetParameterValue(command,
                    "AddressId", address.AddressId);
                m_CustomerDb.SetParameterValue(command,
                    "CustomerId", customerId);
                m_CustomerDb.SetParameterValue(command,
                    "Address", address.StreetAddress);
                m_CustomerDb.SetParameterValue(command,
                    "City", address.City);
                m_CustomerDb.SetParameterValue(command,
                    "ZipCode", address.ZipCode);
                m_CustomerDb.SetParameterValue(command,
                    "State", address.State);
                m_CustomerDb.SetParameterValue(command,
                    "IsPrimaryShipping", address.IsPrimaryShipping);
                m_CustomerDb.SetParameterValue(command,
                    "IsActive", address.IsActive);

                m_CustomerDb.ExecuteNonQuery(command);

                if (address.AddressId < 1)
                    address.AddressId = (int)m_CustomerDb.GetParameterValue(command, "AddressId");

            }
        }

        private void SaveBillingMethodList(BillingMethodList billingMethodList, Int32 customerId)
        {
            DbCommand command = m_CustomerDb.GetStoredProcCommand("usp_BillingMethod_Save");
            m_CustomerDb.AddInParameter(command, "CustomerId", DbType.Int32);
            m_CustomerDb.AddInParameter(command, "NetTermDays", DbType.Int32);
            m_CustomerDb.AddInParameter(command, "CreditCardBillingAddressId", DbType.Int32);
            m_CustomerDb.AddInParameter(command, "CreditCardExpiration", DbType.Date);
            m_CustomerDb.AddInParameter(command, "CreditCardNumber", DbType.String);
            m_CustomerDb.AddInParameter(command, "PaymentMethodId", DbType.Int32);
            m_CustomerDb.AddInParameter(command, "IsActive", DbType.Boolean);
            m_CustomerDb.AddParameter(command, "BillingMethodId", DbType.Int32, 4,
                ParameterDirection.InputOutput, true, 0, 0, String.Empty,
                DataRowVersion.Default, DBNull.Value);

            foreach (BillingMethod billingMethod in billingMethodList)
            {
                m_CustomerDb.SetParameterValue(command,
                    "BillingMethodId", billingMethod.BillingMethodId);

                m_CustomerDb.SetParameterValue(command,
                    "CustomerId", customerId);

                m_CustomerDb.SetParameterValue(command,
                    "PaymentMethodId", billingMethod.PaymentMethodId);

                if(billingMethod.NetTermDays.HasValue)
                    m_CustomerDb.SetParameterValue(command,
                        "NetTermDays", billingMethod.NetTermDays.Value);

                if (billingMethod.CreditCardBillingAddressId.HasValue)
                    m_CustomerDb.SetParameterValue(command,
                        "CreditCardBillingAddressId", billingMethod.CreditCardBillingAddressId.Value);

                if (billingMethod.CreditCardExpiration.HasValue)
                    m_CustomerDb.SetParameterValue(command,
                        "CreditCardExpiration", billingMethod.CreditCardExpiration.Value);

                m_CustomerDb.SetParameterValue(command,
                    "CreditCardNumber", billingMethod.CreditCardNumber);

                m_CustomerDb.SetParameterValue(command,
                    "IsActive", billingMethod.IsActive);

                m_CustomerDb.ExecuteNonQuery(command);

                if (billingMethod.BillingMethodId < 1)
                    billingMethod.BillingMethodId = (int)m_CustomerDb.GetParameterValue(command, "BillingMethodId");

            }
        }

        private AddressList GetAddressList(Int32 customerId)
        {
            AddressList addressList = new AddressList();
            DbCommand command = m_CustomerDb.GetStoredProcCommand("usp_Address_List");

            m_CustomerDb.AddInParameter(command, "CustomerId", DbType.Int32);
            m_CustomerDb.SetParameterValue(command, "CustomerId", customerId);

            using (IDataReader reader = m_CustomerDb.ExecuteReader(command))
            {
                Address address;

                Int32 addressIdOrdinal = reader.GetOrdinal("AddressId");
                Int32 cityOrdinal = reader.GetOrdinal("City");
                Int32 stateOrdinal = reader.GetOrdinal("State");
                Int32 zipCodeOrdinal = reader.GetOrdinal("Zipcode");
                Int32 streetAddressOrdinal = reader.GetOrdinal("Address");
                Int32 isPrimaryShippingOrdinal = reader.GetOrdinal("IsPrimaryShipping");

                while (reader.Read())
                {
                    
                    if (!reader.IsDBNull(addressIdOrdinal))
                    {
                        address = new Address();

                        address.CustomerId = customerId;
                        address.IsActive = true;

                        address.AddressId = reader.GetInt32(addressIdOrdinal);

                        if (!reader.IsDBNull(stateOrdinal))
                            address.State = reader.GetString(stateOrdinal);

                        if (!reader.IsDBNull(cityOrdinal))
                            address.City = reader.GetString(cityOrdinal);

                        if (!reader.IsDBNull(streetAddressOrdinal))
                            address.StreetAddress = reader.GetString(streetAddressOrdinal);

                        if (!reader.IsDBNull(zipCodeOrdinal))
                            address.ZipCode = reader.GetString(zipCodeOrdinal);

                        if (!reader.IsDBNull(isPrimaryShippingOrdinal))
                            address.IsPrimaryShipping = reader.GetBoolean(isPrimaryShippingOrdinal);

                        addressList.Add(address);
                    }
                }
            }
            return addressList;
        }

        private BillingMethodList GetBillingMethodList(Int32 customerId)
        {
            BillingMethodList billingMethodList = new BillingMethodList();
            DbCommand command = m_CustomerDb.GetStoredProcCommand("usp_BillingMethod_List");

            m_CustomerDb.AddInParameter(command, "CustomerId", DbType.Int32);
            m_CustomerDb.SetParameterValue(command, "CustomerId", customerId);

            using (IDataReader reader = m_CustomerDb.ExecuteReader(command))
            {
                BillingMethod billingMethod;

                Int32 billingMethodIdOrdinal = reader.GetOrdinal("BillingMethodId");
                Int32 paymentMethodIdOrdinal = reader.GetOrdinal("PaymentMethodId");
                Int32 netTermDaysOrdinal = reader.GetOrdinal("NetTermDays");
                Int32 creditCardBillingAddressIdOrdinal = reader.GetOrdinal("CreditCardBillingAddressId");
                Int32 creditCardExpirationOrdinal = reader.GetOrdinal("CreditCardExpiration");
                Int32 creditCardNumberOrdinal = reader.GetOrdinal("CreditCardNumber");

                while (reader.Read())
                {
                    if (!reader.IsDBNull(billingMethodIdOrdinal)
                        && !reader.IsDBNull(paymentMethodIdOrdinal))
                    {
                        billingMethod = new BillingMethod();
                        billingMethod.CustomerId = customerId;
                        billingMethod.BillingMethodId = reader.GetInt32(billingMethodIdOrdinal);
                        billingMethod.PaymentMethodId = reader.GetInt32(paymentMethodIdOrdinal);

                        if (!reader.IsDBNull(netTermDaysOrdinal))
                            billingMethod.NetTermDays = reader.GetInt32(netTermDaysOrdinal);
                        else
                            billingMethod.NetTermDays = null;

                        if (!reader.IsDBNull(creditCardBillingAddressIdOrdinal))
                            billingMethod.CreditCardBillingAddressId = reader.GetInt32(creditCardBillingAddressIdOrdinal);
                        else
                            billingMethod.CreditCardBillingAddressId = null;

                        if (!reader.IsDBNull(creditCardExpirationOrdinal))
                            billingMethod.CreditCardExpiration = reader.GetDateTime(creditCardExpirationOrdinal);
                        else
                            billingMethod.CreditCardExpiration = null;

                        if (!reader.IsDBNull(creditCardNumberOrdinal))
                            billingMethod.CreditCardNumber = reader.GetString(creditCardNumberOrdinal);
                        else
                            billingMethod.CreditCardNumber = null;

                        billingMethod.IsActive = true;
                        billingMethodList.Add(billingMethod);
                    }
                }
            }

            return billingMethodList;
        }
    }
}
