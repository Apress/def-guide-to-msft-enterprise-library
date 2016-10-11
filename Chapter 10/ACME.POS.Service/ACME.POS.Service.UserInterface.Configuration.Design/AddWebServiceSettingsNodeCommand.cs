using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
namespace ACME.POS.UserInterface.Configuration.Design
{
    /// <summary>
    /// Represents a command for adding the ACME POS Web Service
    /// configuration section to the current application.
    /// </summary>
    public class AddWebServiceSettingsNodeCommand : AddChildNodeCommand
    {
        public AddWebServiceSettingsNodeCommand(IServiceProvider serviceProvider)
            : base(serviceProvider, typeof(WebServiceSettingsNode))
        { }

        protected override void OnExecuted(EventArgs e)
        {
            base.OnExecuted(e);
            WebServiceSettingsNode node = ChildNode as
            WebServiceSettingsNode;
            WebServiceURLCollectionNode webServiceURLCollectionNode =
            new WebServiceURLCollectionNode();
            node.AddNode(webServiceURLCollectionNode);
        }
    }
}
