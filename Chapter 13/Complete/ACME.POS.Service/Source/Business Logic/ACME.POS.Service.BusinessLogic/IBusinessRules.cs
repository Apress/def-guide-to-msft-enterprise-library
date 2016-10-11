using System;
namespace ACME.POS.Domain
{
    public interface IBusinessRules
    {
        ACME.POS.Domain.Entity.CustomerList GetAllCustomers(string employeeId);
        void SaveCustomerData(ACME.POS.Domain.Entity.CustomerList customers);
    }
}
