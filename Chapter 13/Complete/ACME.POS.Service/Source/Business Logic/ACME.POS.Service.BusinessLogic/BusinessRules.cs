using System;
using System.Collections.Generic;
using System.Text;
using ACME.POS.Domain.Entity;
using ACME.POS.Domain.DAL;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.PolicyInjection.CallHandlers;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
namespace ACME.POS.Domain
{
    public class BusinessRules : ACME.POS.Domain.IBusinessRules
    {
        [ValidationCallHandler]
        public void SaveCustomerData([NotNullValidator]CustomerList customers)
        {
            CustomerList modifiedCustomers = customers.ModifiedCustomers;
            LogEntry logEntry = new LogEntry();
            logEntry.Message = "Modifying Customers";
            logEntry.Categories.Add("Customer");
            logEntry.ExtendedProperties.Add("UserId", modifiedCustomers.EmployeeId);
            logEntry.TimeStamp = DateTime.Now;
            logEntry.ExtendedProperties.Add("LogData", modifiedCustomers.ToXmlString());

            if (Logger.ShouldLog(logEntry))
                Logger.Write(logEntry);

            //Send data to DAL
            CustomerDAL customersDal = new CustomerDAL();
            customersDal.SaveCustomers(modifiedCustomers);
        }

        public CustomerList GetAllCustomers(String employeeId)
        {
            LogEntry logEntry = new LogEntry();
            logEntry.Message = "Getting Customers";
            logEntry.Categories.Add("Customer");
            logEntry.ExtendedProperties.Add("UserId", employeeId);
            logEntry.TimeStamp = DateTime.Now;

            if (Logger.ShouldLog(logEntry))
                Logger.Write(logEntry);

            //Get customer data from DAL
            CustomerDAL customersDal = new CustomerDAL();
            CustomerList customers = customersDal.GetAllCustomers();

            return customers;
        }
    }
}
