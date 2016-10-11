using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Configuration.
Design.Properties;
using ACME.POS.UserInterface.Configuration;
namespace ACME.POS.UserInterface.Configuration.Design
{
    public class WebServiceSettingsBuilder
    {
        private WebServiceSettingsNode webServiceSettingsNode;
        private IConfigurationUIHierarchy hierarchy;
        private WebServiceSettings webServiceSettings;

        public WebServiceSettingsBuilder(IServiceProvider serviceProvider, 
            WebServiceSettingsNode webServiceSettingsNode)
        {
            this.webServiceSettingsNode = webServiceSettingsNode;
            hierarchy = ServiceHelper.GetCurrentHierarchy(serviceProvider);
            webServiceSettings = new WebServiceSettings();
        }

        public WebServiceSettings Build()
        {
            webServiceSettings.DefaultWebServiceURL = 
                webServiceSettingsNode.DefaultWebServiceURLSetting.Name;

            foreach (WebServiceURLNode webServiceURLNode in 
                hierarchy.FindNodesByType(webServiceSettingsNode, typeof(WebServiceURLNode)))
            {
                webServiceSettings.WebServiceURLs.Add(new
                    WebServiceURL(webServiceURLNode.Name, webServiceURLNode.URL));
            }

            return webServiceSettings;
        }
    }
}
