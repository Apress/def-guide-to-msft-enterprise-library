using System;
using System.Collections.Generic;
using System.Text;
using ACME.POS.Service.DataTypes;
using ACME.POS.Service.BusinessEntities;
using ACME.POS.Domain.Entity;

namespace ACME.POS.Service.ServiceImplementation.Translators
{
    public class BusinessEntityToDataType
    {
        public static DataTypes.Customer[] CustomerTranslate(CustomerList customerList)
        {
            DataTypes.Customer[] customers = new DataTypes.Customer[customerList.Count];
            DataTypes.Customer customer;

            for (Int32 i = 0; i < customerList.Count; i++)
            {
                customer = new DataTypes.Customer();
                customer.CustomerId = customerList[i].CustomerId;
                customer.BirthDate = customerList[i].BirthDate;
                customer.FirstName = customerList[i].FirstName;
                customer.LastName = customerList[i].LastName;
                customer.MemberSince = customerList[i].MemberSince;
                customer.IsActive = customerList[i].IsActive;
                if (customerList[i].Addresses != null)
                {
                    customer.Addresses =
                        BusinessEntityToDataType.AddressTranslate(customerList[i].Addresses);
                }
                if (customerList[i].BillingMethods != null)
                {
                    customer.BillingMethods =
                        BusinessEntityToDataType.BillingMethodTranslate(customerList[i].BillingMethods);
                }

                customers[i] = customer;
            }

            return customers;
        }

        public static DataTypes.Address[] AddressTranslate(AddressList addressList)
        {
            DataTypes.Address[] addresses = new DataTypes.Address[addressList.Count];
            DataTypes.Address address;

            for (Int32 i = 0; i < addressList.Count; i++)
            {
                address = new DataTypes.Address();
                address.AddressId = addressList[i].AddressId;
                address.StreetAddress = addressList[i].StreetAddress;
                address.City = addressList[i].City;
                address.CustomerId = addressList[i].CustomerId;
                address.IsActive = addressList[i].IsActive;
                address.IsPrimaryShipping = addressList[i].IsPrimaryShipping;
                address.State = addressList[i].State;
                address.Zipcode = addressList[i].ZipCode;

                addresses[i] = address;
            }

            return addresses;
        }

        public static DataTypes.BillingMethod[] BillingMethodTranslate(BillingMethodList billingMethodList)
        {
            DataTypes.BillingMethod[] billingMethods = new DataTypes.BillingMethod[billingMethodList.Count];
            DataTypes.BillingMethod billingMethod;
            for(Int32 i = 0; i < billingMethodList.Count; i ++)
            {
                billingMethod = new DataTypes.BillingMethod();
                billingMethod.BillingMethodId = billingMethodList[i].BillingMethodId;
                billingMethod.PaymentMethodId = billingMethodList[i].PaymentMethodId;
                billingMethod.IsActive = billingMethodList[i].IsActive;
                billingMethod.CustomerId = billingMethodList[i].CustomerId;

                if (billingMethodList[i].PaymentMethodId == 1)
                { //credit card
                    if (billingMethodList[i].CreditCardBillingAddressId.HasValue)
                        billingMethod.CreditCardBillingAddressId = billingMethodList[i].CreditCardBillingAddressId.Value;
                    else
                        billingMethod.CreditCardBillingAddressId = -1;

                    billingMethod.CreditCardNumber = billingMethodList[i].CreditCardNumber;

                    if (billingMethodList[i].CreditCardExpiration.HasValue)
                        billingMethod.CreditCardExpiration = billingMethodList[i].CreditCardExpiration.Value;
                    else
                        billingMethod.CreditCardExpiration = DateTime.MinValue;
                }
                else
                {// net term
                    if (billingMethodList[i].NetTermDays.HasValue)
                        billingMethod.NetTermDays = billingMethodList[i].NetTermDays.Value;
                    else
                        billingMethod.NetTermDays = 0;
                }

                billingMethods[i] = billingMethod;
            }

            return billingMethods;
        }
    }
}
