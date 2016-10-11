using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;

namespace ACME.POS.Service.ServiceImplementation
{
    [System.Web.Services.WebService(Namespace = "http://ACME.POS.Service.ServiceContracts/2007/06", Name = "Customer")]
    [System.Web.Services.WebServiceBindingAttribute(ConformsTo = System.Web.Services.WsiProfiles.BasicProfile1_1, EmitConformanceClaims = true)]
    public class Customer : ACME.POS.Service.ServiceContracts.ICustomer
    {
        #region ICustomer Members

public ACME.POS.Service.DataTypes.Customer[] GetCustomerList()
{
    try
    {
        throw new Exception("The method or operation is not implemented.");
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
                throw new Exception("The method or operation is not implemented.");
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
