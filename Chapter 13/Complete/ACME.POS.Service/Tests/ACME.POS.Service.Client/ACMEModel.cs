using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Caching;
using ACME.POS.Service.Client;
using ACME.POS.Service.Client.ACMEStateWebService;
using ACME.POS.Service.Client.ACMECustomerWebService;
using ACME.POS.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation;


namespace ACME.POS.UI.Model
{
    public class ACMEModel
    {
        private CacheManager m_StaticDataCache;

        public ACMEModel()
        {
            m_StaticDataCache = CacheFactory.GetCacheManager("StaticData");
        }

        public State[] GetStates()
        {
            if (m_StaticDataCache == null)
                throw new ApplicationException("Static Data Cache is Null") ;

            State[] stateList = m_StaticDataCache["STATES"] as State[];

            if(stateList == null)
            {
                 //Attempt to retrieve the data form the web service and reset the cache 
                 //using the StateCacheRefreshAction class
                 StateCacheRefreshAction refreshAction = new StateCacheRefreshAction();
                 refreshAction.Refresh("STATES", null, CacheItemRemovedReason.Unknown);
                 stateList = m_StaticDataCache["STATES"] as State[];
            }

            return stateList;
        }

        public void SaveCustomer(Customer customer)
        {
            GetService().SaveCustomer(customer);
        }

        private CustomerServices GetService()
        {
            CustomerServices services = new CustomerServices();
            Uri uri = new Uri(services.Url);
            string dnsName = uri.DnsSafeHost;
            HostValidator hostValidator = new HostValidator();
            ValidationResults r = hostValidator.Validate(dnsName);

            if (r.IsValid)
                return services;
            else
                throw new Exception("Unable to save at this time");
        }

        public Customer[] GetCustomers()
        {
            return GetService().GetCustomerList();
        }
    }
}
