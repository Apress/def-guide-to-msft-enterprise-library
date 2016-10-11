using System;
using System.ComponentModel;
using System.Diagnostics;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Configuration.
Design.Validation;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using ACME.POS.UserInterface.Configuration.Design.Properties;
using System.Drawing.Design;
namespace ACME.POS.UserInterface.Configuration.Design
{
    /// <summary>
    /// Represents the root configuration for the ACME POS Web Service Settings.
    /// </summary>
    public class WebServiceSettingsNode : ConfigurationNode
    {
        private WebServiceURLNode webServiceURLNode;
        private EventHandler<ConfigurationNodeChangedEventArgs>WebServiceSettingNodeRemovedHandler;

        public WebServiceSettingsNode() : base(Resources.DefaultWebServiceSettingsNodeName)
        {
            this.WebServiceSettingNodeRemovedHandler = 
                new EventHandler<ConfigurationNodeChangedEventArgs>(OnWebServiceSettingNodeRemoved);
        }

        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing)
                {
                    if (null != webServiceURLNode)
                    {
                        webServiceURLNode.Removed -= WebServiceSettingNodeRemovedHandler;
                    }
                }
            }
            finally
            {
                base.Dispose(disposing);
            }
        }

        [ReadOnly(true)]
        public override string Name
        {
            get { return base.Name; }
        }

        [Required]
        [SRDescription("DefaultWebServiceSettingDescription", typeof(Resources))]
        [Editor(typeof(ReferenceEditor), typeof(UITypeEditor))]
        [ReferenceType(typeof(WebServiceURLNode))]
        [SRCategory("CategoryGeneral", typeof(Resources))]
        public WebServiceURLNode DefaultWebServiceURLSetting
        {
            get { return webServiceURLNode; }
            set
            {
                webServiceURLNode = LinkNodeHelper.CreateReference<WebServiceURLNode>(webServiceURLNode, 
                    value, WebServiceSettingNodeRemovedHandler, null);
            }
        }

        protected override void OnChildAdded(ConfigurationNodeChangedEventArgs e)
        {
            base.OnChildAdded(e);

            if (Nodes.Count > 1 && e.Node.GetType() == typeof(WebServiceURLCollectionNode))
            {
                throw new InvalidOperationException("Oops you can only have one");
            }
        }

        private void OnWebServiceSettingNodeRemoved(object sender, ConfigurationNodeChangedEventArgs e)
        {
            this.webServiceURLNode = null;
        }
    }
}
