using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;
using DGTEL.SampleAB;

namespace DGTEL.SampleAB.Configuration
{
    internal class SampleProviderDataRetriever : IConfigurationNameMapper
    {
        public string MapName(string name, IConfigurationSource configSource)
        {
            if (name != null)
            {
                return name;
            }
            else
            {
                ApplicationBlockSettings settings = ApplicationBlockSettings.GetApplicationBlockSettings(configSource);
                return settings.DefaultSampleProviderName;
            }
        }
    }
}

