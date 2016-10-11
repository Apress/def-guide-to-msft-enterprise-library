using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using ACME.POS.Domain.DAL;
using ACME.POS.Domain.Entity;

namespace ACME.POS.Service.BusinessLogic
{
    public class CustomerBusinessRules
    {
        public void SaveCustomerData(CustomerList customers)
        {
            CustomerList modifiedCustomers = customers.ModifiedCustomers;

            LogEntry logEntry = new LogEntry();
            logEntry.Message = "Modifying Customers";
            logEntry.Categories.Add("Customer");
            logEntry.TimeStamp = DateTime.Now;
            logEntry.ExtendedProperties.Add("LogData", modifiedCustomers.ToXmlString());

            if (Logger.ShouldLog(logEntry))
                Logger.Write(logEntry);

            //Send data to DAL
            CustomerDAL customerDal = new CustomerDAL();
            customerDal.SaveCustomers(modifiedCustomers);
        }


        public CustomerList GetAllCustomers()
        {
            LogEntry logEntry = new LogEntry();
            logEntry.Message = "Getting Customers";
            logEntry.Categories.Add("Customer");
            logEntry.TimeStamp = DateTime.Now;

            if (Logger.ShouldLog(logEntry))
                Logger.Write(logEntry);

            //Get customer data from DAL
            CustomerDAL customerDal = new CustomerDAL();
            return customerDal.GetAllCustomers();

        }

    }
}
