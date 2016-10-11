using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
namespace ACME.POS.UserInterface.Configuration
{
    public class WebServiceSettings : SerializableConfigurationSection
    {
        public const string SectionName = "webServiceSettingsConfiguration";
        private const string defaultWebServiceURL = "defaultWebServiceURL";
        private const string webServiceURLs = "webServiceURLs";

        [ConfigurationProperty(defaultWebServiceURL, IsRequired = true)]
        public string DefaultWebServiceURL
        {
            get { return (string)base[defaultWebServiceURL]; }
            set { base[defaultWebServiceURL] = value; }
        }

        [ConfigurationProperty(webServiceURLs, IsRequired = true)]
        public NamedElementCollection<WebServiceURL> WebServiceURLs
        {
            get
            {
                return (NamedElementCollection<WebServiceURL>)base[webServiceURLs];
            }
        }
    }
}
