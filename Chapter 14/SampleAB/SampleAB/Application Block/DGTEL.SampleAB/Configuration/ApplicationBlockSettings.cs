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

using System.Configuration;
using System.Configuration.Provider;
using System.ComponentModel;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace DGTEL.SampleAB.Configuration
{
    /// <summary>
    /// Represents the configuration data for the DGTEL.SampleAB providers.
    /// </summary>
    public partial class ApplicationBlockSettings : SerializableConfigurationSection
    {
        /// <summary>
        /// The name of the configuration section for the DGTEL.SampleAB providers.
        /// </summary>
        public const string SectionName = "DGTEL.SampleAB";

        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationBlockSettings"/> class.
        /// </summary>
        public ApplicationBlockSettings()
        {
        }

        /// <summary>
        /// Retrieves the <see cref="ApplicationBlockSettings"/> section from the configuration source.
        /// </summary>
        /// <param name="configurationSource">The <see cref="IConfigurationSource"/> to get the section from.</param>
        /// <returns>The logging section.</returns>
        public static ApplicationBlockSettings GetApplicationBlockSettings(IConfigurationSource configurationSource)
        {
            return (ApplicationBlockSettings)configurationSource.GetSection(SectionName);
        }
    }
}