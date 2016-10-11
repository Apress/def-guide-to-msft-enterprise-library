using System;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using DGTEL.SampleAB;

namespace DGTEL.SampleAB.Configuration
{
    public partial class ApplicationBlockSettings
    {

        private const string defaultSampleProviderNameProperty = "defaultSampleProviderInstance";

        /// <summary>
        /// The instance name of the default <see cref="SampleProvider"/> instance.
        /// </summary>
        [ConfigurationProperty(defaultSampleProviderNameProperty, IsRequired = false)]
        public string DefaultSampleProviderName
        {
            get
            {
                return (string)this[defaultSampleProviderNameProperty];
            }
            set
            {
                this[defaultSampleProviderNameProperty] = value;
            }
        }

        // TODO: Verify that the plural property value is correct.
        private const string SampleProviderProperty = "SampleProviders";


        /// <summary>
        /// <para>Gets the collection of <see cref="SampleProviderData"/>.</para>
        /// </summary>
        /// <value>
        /// <para>The SampleProvider available in configuration. The default is an empty collection.</para>
        /// </value>
        /// <remarks>
        /// <para>This property maps to the <c>SampleProviderProviders</c> element in configuration.</para>
        /// </remarks>
        [ConfigurationProperty(SampleProviderProperty, IsRequired = true)]
        public NameTypeConfigurationElementCollection<SampleProviderData, SampleProviderData> SampleProviderProviders
        {
            get { return (NameTypeConfigurationElementCollection<SampleProviderData, SampleProviderData>)base[SampleProviderProperty]; }
        }


    }
}
