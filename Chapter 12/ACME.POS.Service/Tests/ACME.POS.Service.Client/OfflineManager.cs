using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;
using Microsoft.Practices.EnterpriseLibrary.Caching;
using ACME.POS.Service.Client.ACMECustomerWebService;
using ACME.POS.UserInterface.Configuration;
using System.Configuration;

namespace ACME.POS.Service.Client
{
    public class OfflineManager
    {
        private string m_Url;

        public Customer[] ReadCustomerData()
        {
            string url = GetUrl;
            Customer[] customers;
            //check to see if server is available
            if (TestWebServer(url, 10000))
            {
                customers = ReadCustomerDataFromServer(url);
            }
            else
            {
                CacheManager cache = CacheFactory.GetCacheManager();
                customers = cache.GetData("customers") as Customer[];
            }
            return customers;
        }

        public void SaveData(Customer[] customers)
        {
            string url = GetUrl;
            //check to see if server is available
            if (TestWebServer(url, 10000))
            {
                CustomerServices service = new CustomerServices();
                service.Url = url;
                //save data
                for (int i = 0; i < customers.Length; i++)
                {
                    if (customers[i].IsModified)
                    {
                        customers[i] = service.SaveCustomer(customers[i]);
                    }
                }
            }
            else
            {
                CacheManager cache = CacheFactory.GetCacheManager();
                cache.Add("customers", customers);
            }
        }

        private Customer[] ReadCustomerDataFromServer(string url)
        {
            CustomerServices service = new CustomerServices();
            service.Url = url;
            return service.GetCustomerList();
        }

        private bool TestWebServer(string Url, int Timeout)
        {
            HttpWebRequest httpRequest = WebRequest.Create(Url) as HttpWebRequest;
            HttpWebResponse httpResponse = null;
            bool testResult = false;
            try
            {
                //Don't allow infinite timeouts
                if (Timeout > 0)
                    httpRequest.Timeout = Timeout;
                // Set resource limits
                httpRequest.MaximumAutomaticRedirections = 4;
                httpRequest.MaximumResponseHeadersLength = 4;
                // Set credentials
                httpRequest.Credentials = CredentialCache.DefaultCredentials;
                httpResponse = httpRequest.GetResponse() as HttpWebResponse;
                testResult = true;
            }
            catch(Exception ex)
            {
                //Ignore any exception that occurs
                string x = ex.Message;
            }
            finally
            {
                if (httpResponse != null)
                {
                    httpResponse.Close();
                }
            }
            return testResult;
        }

        private string GetUrl
        {
            get
            {
                if (String.IsNullOrEmpty(m_Url))
                {
                    WebServiceSettings settings = ConfigurationManager.GetSection(WebServiceSettings.SectionName) as WebServiceSettings;
                    m_Url = settings.WebServiceURLs.Get(settings.DefaultWebServiceURL).URL;
                }
                return m_Url;
            }
        }
    }
}
