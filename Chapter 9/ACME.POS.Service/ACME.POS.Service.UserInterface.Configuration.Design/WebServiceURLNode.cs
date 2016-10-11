using System;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Validation;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using System.Configuration;
using ACME.POS.UserInterface.Configuration.Design.Properties;
namespace ACME.POS.UserInterface.Configuration.Design
{
    public class WebServiceURLNode : ConfigurationNode
    {
        private string url;
        public WebServiceURLNode()
            : this(new WebServiceURL("Default URL", "HTTP://someURL.com"))
        {
        }

        public WebServiceURLNode(WebServiceURL webServiceURL)
            : base((webServiceURL == null) ? "" : webServiceURL.Name)
        {
            if (webServiceURL == null)
            {
                throw new ArgumentNullException("webServiceURL");
            }

            this.url = webServiceURL.URL;
        }

        [Required]
        [SRDescription("URLDescription", typeof(Resources))]
        [SRCategory("CategoryGeneral", typeof(Resources))]
        public string URL
        {
            get { return url; }
            set { url = value; }
        }
    }
}
