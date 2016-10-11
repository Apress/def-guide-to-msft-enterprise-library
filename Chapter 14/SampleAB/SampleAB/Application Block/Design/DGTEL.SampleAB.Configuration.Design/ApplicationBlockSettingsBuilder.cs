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
    sealed partial class ApplicationBlockSettingsBuilder
    {
        private ApplicationBlockSettingsNode blockSettingsNode;
        private IConfigurationUIHierarchy hierarchy;
        private ApplicationBlockSettings blockSettings;

        public ApplicationBlockSettingsBuilder(IServiceProvider serviceProvider, ApplicationBlockSettingsNode blockSettingsNode)
        {
            this.blockSettingsNode = blockSettingsNode;
            hierarchy = ServiceHelper.GetCurrentHierarchy(serviceProvider);
        }

        public ApplicationBlockSettings Build()
        {
            blockSettings = new ApplicationBlockSettings();

            BuildProviders();

            return blockSettings;
        }

        private void BuildProviders()
        {
        
				BuildSampleProviderProviders();
		
}
    }
}
