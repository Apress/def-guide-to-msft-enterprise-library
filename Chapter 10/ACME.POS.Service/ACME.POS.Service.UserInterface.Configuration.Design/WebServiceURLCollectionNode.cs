using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;


namespace ACME.POS.UserInterface.Configuration.Design
{
    public class WebServiceURLCollectionNode : ConfigurationNode
    {
        public WebServiceURLCollectionNode()
            : base("Web Service URL's")
        {
        }

        [ReadOnly(true)]
        public override string Name
        {
            get { return base.Name; }
        }
    }
}
