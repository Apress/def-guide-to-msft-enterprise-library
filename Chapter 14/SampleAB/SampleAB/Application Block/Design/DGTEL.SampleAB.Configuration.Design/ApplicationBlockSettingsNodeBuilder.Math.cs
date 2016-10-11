using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;

namespace DGTEL.SampleAB.Configuration.Design
{
    sealed partial class ApplicationBlockSettingsNodeBuilder
    {
        private void BuildSampleProviderProviders()
        {
            foreach (DGTEL.SampleAB.Configuration.SampleProviderData providerData in blockSettings.SampleProviderProviders)
            {
                Math providerNode = NodeCreationService.CreateNodeByDataType(providerData.GetType(), new object[] { providerData }) as Math;
                node.AddNode(providerNode);

                //if there is a default instance specify it.
                if (blockSettings.DefaultSampleProviderName == providerData.Name)
                    node.DefaultDatabase = providerNode;
            }
        }

        
    }
}
