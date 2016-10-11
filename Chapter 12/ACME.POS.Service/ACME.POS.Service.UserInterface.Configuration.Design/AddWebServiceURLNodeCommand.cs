using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;

namespace ACME.POS.UserInterface.Configuration.Design
{
    public class AddWebServiceURLNodeCommand : AddChildNodeCommand
    {
        public AddWebServiceURLNodeCommand(IServiceProvider serviceProvider)
            : base(serviceProvider, typeof(WebServiceURLNode))
        { }
    }
}
