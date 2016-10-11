using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
namespace ACME.POS.UserInterface.Configuration.Design
{
    public class WebServiceConfigurationDesignManager : ConfigurationDesignManager
    {
        public override void Register(IServiceProvider serviceProvider)
        {
            WebServiceCommandRegistrar webServiceCommandRegistrar =
                new WebServiceCommandRegistrar(serviceProvider);

            webServiceCommandRegistrar.Register();
        }

        protected override void OpenCore(IServiceProvider serviceProvider, 
            ConfigurationApplicationNode rootNode, ConfigurationSection section)
        {
            if (null != section)
            {
                WebServiceSettingsNodeBuilder builder = new WebServiceSettingsNodeBuilder(
                    serviceProvider, (WebServiceSettings)section);

                rootNode.AddNode(builder.Build());
            }
        }

        protected override ConfigurationSectionInfo GetConfigurationSectionInfo(
            IServiceProvider serviceProvider)
        {
            ConfigurationNode rootNode = ServiceHelper.GetCurrentRootNode(serviceProvider);

            WebServiceSettingsNode node = null;

            if (rootNode != null)
                node = (WebServiceSettingsNode)rootNode.Hierarchy.FindNodeByType(
                    rootNode,
                    typeof(WebServiceSettingsNode));

            WebServiceSettings webServiceSection = null;

            if (node == null)
            {
                webServiceSection = null;
            }
            else
            {
                WebServiceSettingsBuilder builder = new WebServiceSettingsBuilder(serviceProvider, node);
                webServiceSection = builder.Build();
            }

            return new ConfigurationSectionInfo(node, webServiceSection, WebServiceSettings.SectionName);
        }
    }
}
