using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
namespace ACME.POS.UserInterface.Configuration
{
    public class WebServiceURL : NamedConfigurationElement
    {
        private const string m_Url = "url";

        public WebServiceURL()
        {}

        public WebServiceURL(string name, string url) : base(name)
        {
            this.URL = url;
        }

        [ConfigurationProperty(m_Url, IsRequired = true)]
        public string URL
        {
            get { return (string)base[m_Url]; }
            set { base[m_Url] = value; }
        }
    }
}
