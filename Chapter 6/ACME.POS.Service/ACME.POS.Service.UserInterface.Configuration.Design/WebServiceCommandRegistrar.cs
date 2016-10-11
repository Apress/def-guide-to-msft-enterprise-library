using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
namespace ACME.POS.UserInterface.Configuration.Design
{
    public class WebServiceCommandRegistrar : CommandRegistrar
    {
        public WebServiceCommandRegistrar(IServiceProvider serviceProvider)
            : base(serviceProvider)
        { }

        public override void Register()
        {
            ConfigurationUICommand cmd = ConfigurationUICommand.CreateSingleUICommand(
                ServiceProvider,
                "ACME POS WebService Settings",
                "Add ACME POS WebService Settings",
                new AddWebServiceSettingsNodeCommand(ServiceProvider),
                typeof(WebServiceSettingsNode));

            AddUICommand(cmd, typeof(ConfigurationApplicationNode));

            AddDefaultCommands(typeof(WebServiceSettingsNode));

            ConfigurationUICommand item = ConfigurationUICommand.CreateMultipleUICommand(
                ServiceProvider,
                "Web Service URL",
                "Add Web Service URL",
                new AddWebServiceURLNodeCommand(ServiceProvider),
                typeof(WebServiceURLNode));

            AddUICommand(item, typeof(WebServiceURLCollectionNode));

            AddDefaultCommands(typeof(WebServiceURLNode));
        }
    }
}
