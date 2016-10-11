using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;

namespace DGTEL.SampleAB.Configuration.Design
{
    sealed partial class ApplicationBlockSettingsBuilder
    {
        
        private void BuildSampleProviderProviders()
        {
            foreach (Math node in hierarchy.FindNodesByType(blockSettingsNode, typeof(Math)))
            {
                blockSettings.SampleProviderProviders.Add(node.SampleProviderData);
            }

            ApplicationBlockSettingsNode appNode = 
                hierarchy.FindNodeByType(typeof(ApplicationBlockSettingsNode)) as ApplicationBlockSettingsNode;

            //Provides setting of default database
            if (appNode != null && appNode.DefaultDatabase != null)
                blockSettings.DefaultSampleProviderName = appNode.DefaultDatabase.Name;
        }
    }
}
