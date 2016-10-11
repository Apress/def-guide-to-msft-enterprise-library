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
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;

namespace DGTEL.SampleAB.Configuration.Design
{
    sealed partial class ApplicationBlockSettingsNodeBuilder : NodeBuilder
    {
        private ApplicationBlockSettings blockSettings;
        private ApplicationBlockSettingsNode node;

        public ApplicationBlockSettingsNodeBuilder(IServiceProvider serviceProvider, ApplicationBlockSettings blockSettings)
            : base(serviceProvider)
        {
            this.blockSettings = blockSettings;
        }

        public ApplicationBlockSettingsNode Build()
        {
            this.node = new ApplicationBlockSettingsNode();

            BuildProviders();

            return node;
        }

        private void BuildProviders()
        {
        
				BuildSampleProviderProviders();
		
}
    }
}
