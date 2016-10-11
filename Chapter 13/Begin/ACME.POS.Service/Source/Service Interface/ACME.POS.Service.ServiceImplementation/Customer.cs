using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using ACME.POS.Domain;
using ACME.POS.Domain.Entity;

namespace ACME.POS.Service.ServiceImplementation
{
    [System.Web.Services.WebService(Namespace = "http://ACME.POS.Service.ServiceContracts/2007/06", Name = "CustomerServices")]
    [System.Web.Services.WebServiceBindingAttribute(ConformsTo = System.Web.Services.WsiProfiles.BasicProfile1_1, EmitConformanceClaims = true)]
    public class Customer : ACME.POS.Service.ServiceContracts.ICustomer
    {
        #region ICustomer Members

        public ACME.POS.Service.DataTypes.Customer[] GetCustomerList()
        {
            try
            {
                BusinessRules rules = new BusinessRules();

                //strictly using Environment.UserName for demo purposes.
                return Translators.BusinessEntityToDataType.CustomerTranslate(
                    rules.GetAllCustomers(Environment.UserName));
            }
            catch (Exception ex)
            {
                if(ExceptionPolicy.HandleException(ex, "ACMEServiceExceptionPolicy")) throw;
            }

            return null;
        }

        public ACME.POS.Service.DataTypes.Customer SaveCustomer(ACME.POS.Service.DataTypes.Customer SaveCustomerRequest)
        {
            try
            {
                BusinessRules rules = new BusinessRules();
                DataTypes.Customer[] customers = new DataTypes.Customer[1];
                customers[0] = SaveCustomerRequest;
                CustomerList list = Translators.DataTypeToBusinessEntity.CustomerTranslate(customers);
                //strictly using Environment.UserName for demo purposes.
                list.EmployeeId = Environment.UserName;
                rules.SaveCustomerData(list);
            }
            catch (Exception ex)
            {
                if (ExceptionPolicy.HandleException(ex, "ACMEServiceExceptionPolicy")) throw;
            }

            return SaveCustomerRequest;
        }

        #endregion
    }
}
