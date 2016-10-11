//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Application Block Software Factory
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.Text;
using System.Configuration;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;

namespace DGTEL.SampleAB.Configuration.Design
{

    /// <summary>
    /// Represents the design manager for the DGTEL.SampleAB settings configuration section.
    /// </summary>
    public sealed class ConfigurationDesignManager : Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ConfigurationDesignManager
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationDesignManager"/> class.
        /// </summary>
        public ConfigurationDesignManager()
        {
        }

        /// <summary>
        /// Register the commands and node maps needed for the design manager into the design time.
        /// </summary>
        /// <param name="serviceProvider">The a mechanism for retrieving a service object; that is, an object that provides custom support to other objects.</param>
        public override void Register(IServiceProvider serviceProvider)
        {
            CommandRegistrar cmdRegistrar = new CommandRegistrar(serviceProvider);
            cmdRegistrar.Register();
            NodeMapRegistrar nodeRegistrar = new NodeMapRegistrar(serviceProvider);
            nodeRegistrar.Register();
        }

        /// <summary>
        /// Gets the a <see cref="ConfigurationSectionInfo"/> for the security settings configuration section.
        /// </summary>
        /// <param name="serviceProvider">The a mechanism for retrieving a service object; that is, an object that provides custom support to other objects.</param>
        /// <returns>A <see cref="ConfigurationSectionInfo"/> for the security settings configuration section.</returns>
        protected override ConfigurationSectionInfo GetConfigurationSectionInfo(IServiceProvider serviceProvider)
        {
            ConfigurationNode rootNode = ServiceHelper.GetCurrentRootNode(serviceProvider);
            ApplicationBlockSettingsNode node = null;
            if (null != rootNode) node = rootNode.Hierarchy.FindNodeByType(rootNode, typeof(ApplicationBlockSettingsNode)) as ApplicationBlockSettingsNode;
            ApplicationBlockSettings blockSettings = null;
            if (node != null)
            {
                ApplicationBlockSettingsBuilder builder = new ApplicationBlockSettingsBuilder(serviceProvider, node);
                blockSettings = builder.Build();
            }
            return new ConfigurationSectionInfo(node, blockSettings, ApplicationBlockSettings.SectionName);
        }

        /// <summary>
        /// Initializes the DGTEL.SampleAB.
        /// </summary>
        /// <param name="serviceProvider">The a mechanism for retrieving a service object; that is, an object that provides custom support to other objects.</param>
        /// <param name="rootNode">The root node of the application.</param>
        /// <param name="section">The <see cref="ConfigurationSection"/> that was opened from the <see cref="Microsoft.Practices.EnterpriseLibrary.Common.Configuration.IConfigurationSource"/>.</param>
        protected override void OpenCore(IServiceProvider serviceProvider, ConfigurationApplicationNode rootNode, System.Configuration.ConfigurationSection section)
        {
            if (null != section)
            {
                ApplicationBlockSettingsNodeBuilder builder = new ApplicationBlockSettingsNodeBuilder(serviceProvider, (ApplicationBlockSettings)section);
                rootNode.AddNode(builder.Build());
            }
        }
    }
}
