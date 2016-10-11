using System;
using System.Collections.Generic;
using System.Text;
using ACME.POS.Service.DataTypes;
using ACME.POS.Service.BusinessEntities;
using ACME.POS.Domain.Entity;

namespace ACME.POS.Service.ServiceImplementation.Translators
{
    public class DataTypeToBusinessEntity
    {
        public static CustomerList CustomerTranslate(DataTypes.Customer[] customers)
        {
            CustomerList list = new CustomerList();
            Domain.Entity.Customer customer;

            for (int i = 0; i < customers.Length; i++)
            {
                customer = new Domain.Entity.Customer();
                customer.CustomerId = customers[i].CustomerId;
                customer.FirstName = customers[i].FirstName;
                customer.LastName = customers[i].LastName;
                customer.BirthDate = customers[i].BirthDate;
                customer.MemberSince = customers[i].MemberSince;
                customer.IsModified = customers[i].IsModified;
                customer.IsActive = customers[i].IsActive;
                if (customers[i] != null && customers[i].Addresses != null)
                {
                    customer.Addresses = DataTypeToBusinessEntity.AddressTranslate(customers[i].Addresses);
                }
                if (customers[i] != null && customers[i].BillingMethods != null)
                {
                    customer.BillingMethods =
                        DataTypeToBusinessEntity.BillingMethodTranslate(customers[i].BillingMethods);
                }

                list.Add(customer);
            }

            return list;
        }

        public static AddressList AddressTranslate(DataTypes.Address[] addresses)
        {
            AddressList list = new AddressList();
            BusinessEntities.Address address;

            for (int i = 0; i < addresses.Length; i++)
            {
                address = new BusinessEntities.Address();
                address.AddressId = addresses[i].AddressId;
                address.CustomerId = addresses[i].CustomerId;
                address.StreetAddress = addresses[i].StreetAddress;
                address.City = addresses[i].City;
                address.State = addresses[i].State;
                address.ZipCode = addresses[i].Zipcode;
                address.IsPrimaryShipping = addresses[i].IsPrimaryShipping;
                address.IsActive = addresses[i].IsActive;

                list.Add(address);
            }

            return list;
        }

        public static BillingMethodList BillingMethodTranslate(DataTypes.BillingMethod[] billingMethods)
        {
            BillingMethodList list = new BillingMethodList();
            BusinessEntities.BillingMethod billingMethod;

            for (int i = 0; i < billingMethods.Length; i++)
            {
                billingMethod = new BusinessEntities.BillingMethod();
                billingMethod.BillingMethodId = billingMethods[i].BillingMethodId;
                billingMethod.CustomerId = billingMethods[i].CustomerId;
                billingMethod.PaymentMethodId = billingMethods[i].PaymentMethodId;
                billingMethod.IsActive = billingMethods[i].IsActive;

                if (billingMethods[i].PaymentMethodId == 1)
                { //credit card
                    if (billingMethods[i].CreditCardBillingAddressId < 0)
                    {
                        billingMethod.CreditCardBillingAddressId = null;
                    }
                    else
                    {
                        billingMethod.CreditCardBillingAddressId =
                            billingMethods[i].CreditCardBillingAddressId;
                    }


                    if (billingMethods[i].CreditCardExpiration == DateTime.MinValue)
                    {
                        billingMethod.CreditCardExpiration = null;
                    }
                    else
                    {
                        billingMethod.CreditCardExpiration = billingMethods[i].CreditCardExpiration;
                    }

                    billingMethod.CreditCardNumber = billingMethods[i].CreditCardNumber;
                }
                else
                {//net term
                    if (billingMethods[i].NetTermDays < 0)
                    {
                        billingMethod.NetTermDays = null;
                    }
                    else
                    {
                        billingMethod.NetTermDays = billingMethods[i].NetTermDays;
                    }
                }

                list.Add(billingMethod);
            }

            return list;
        }
    }
}
