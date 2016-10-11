using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
namespace ACME.POS.UserInterface.Configuration.Design
{
    public class WebServiceSettingsNodeBuilder : NodeBuilder
    {
        private WebServiceSettings webServiceSettings;
        private WebServiceURLNode defaultNode;

        public WebServiceSettingsNodeBuilder(IServiceProvider serviceProvider, 
            WebServiceSettings webServiceSettings)
            : base(serviceProvider)
        {
            this.webServiceSettings = webServiceSettings;
        }

        public WebServiceSettingsNode Build()
        {
            WebServiceSettingsNode rootNode = new WebServiceSettingsNode();
            WebServiceURLCollectionNode node = new WebServiceURLCollectionNode();
            WebServiceURLNode webServiceURLNode;

            foreach (WebServiceURL data in webServiceSettings.WebServiceURLs)
            {
                webServiceURLNode = new WebServiceURLNode(data);
                node.AddNode(webServiceURLNode);

                if (webServiceURLNode.Name == webServiceSettings.DefaultWebServiceURL)
                    defaultNode = webServiceURLNode;
            }

            rootNode.AddNode(node);
            rootNode.DefaultWebServiceURLSetting = defaultNode;

            return rootNode;
        }
    }
}
