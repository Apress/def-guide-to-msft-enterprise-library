using System;
using System.Configuration;
using System.Collections.Generic;
using Microsoft.Practices.ObjectBuilder;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;
using DGTEL.SampleAB.Configuration;
using DGTEL.SampleAB.Properties;

namespace DGTEL.SampleAB
{
    /// <summary>
    /// Represents the general process to build an <see cref="ISampleProvider"/> object given a concrete sublcass of <see cref="SampleProviderData"/>.
    /// </summary>
    /// <remarks>
    /// This type leverages the generic implementation from AssemblerBasedObjectFactory.
    /// </remarks>
    public class SampleProviderCustomFactory : AssemblerBasedCustomFactory<ISampleProvider, SampleProviderData>
    {
        /// <summary>
        /// Looks up a specified <see cref="SampleProvider"/>'s configuration from the given <paramref name="configurationSource"/>. 
        /// </summary>
        /// <param name="name">The name of the <see cref="SampleProvider"/> for which the configuration should be looked up.</param>
        /// <param name="configurationSource">The configuration source which should be used.</param>
        /// <returns>The configuration for the specified <see cref="SampleProvider"/>.</returns>
        protected override SampleProviderData GetConfiguration(string name, IConfigurationSource configurationSource)
        {
            ApplicationBlockSettings settings = ApplicationBlockSettings.GetApplicationBlockSettings(configurationSource);
            return settings.SampleProviderProviders.Get(name);
        }
    }
}
