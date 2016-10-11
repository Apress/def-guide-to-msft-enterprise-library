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
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;

namespace DGTEL.SampleAB.Configuration.Design
{
    /// <summary>
    /// Intercepts creation of the ExceptionTypeDesignNode
    /// </summary>
    class AddApplicationBlockSettingsNodeCommand : AddChildNodeCommand
    {
        private IServiceProvider serviceProvider;

        /// <summary>
        /// Initialize a new instance of the <see cref="AddApplicationBlockSettingsNodeCommand"/> class with an <see cref="IServiceProvider"/>.
        /// </summary>
        /// <param name="serviceProvider">The a mechanism for retrieving a service object; that is, an object that provides custom support to other objects.</param>
        public AddApplicationBlockSettingsNodeCommand(IServiceProvider serviceProvider)
            : base(serviceProvider, typeof(ApplicationBlockSettingsNode))
        {
            this.serviceProvider = serviceProvider;
        }
        /// <summary>
        /// Adds the default nodes.
        /// </summary>
        /// <param name="node">The <see cref="ApplicationBlockSettingsNode"/> added.</param>
        protected override void ExecuteCore(ConfigurationNode node)
        {
            base.ExecuteCore(node);
            ApplicationBlockSettingsNode blockSettingsNode = ChildNode as ApplicationBlockSettingsNode;
            if (blockSettingsNode == null) return;

            blockSettingsNode.Name = "Math";
        }
    }
}
