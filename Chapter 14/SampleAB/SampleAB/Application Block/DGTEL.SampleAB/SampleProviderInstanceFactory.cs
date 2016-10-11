using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;

namespace DGTEL.SampleAB
{
    /// <summary>
    /// Provides methods for the creation of
    /// <see cref="ISampleProvider"/> instances.
    /// </summary>
    public class SampleProviderInstanceFactory : NameTypeFactoryBase<ISampleProvider>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SampleProviderFactory"/> class 
        /// with the default configuration source.</para>
        /// </summary>
        protected SampleProviderInstanceFactory()
            : base()
        {
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SampleProviderFactory"/> class 
        /// with the given configuration source.</para>
        /// </summary>
        /// <param name="configurationSource">The source for configuration information.</param>
        public SampleProviderInstanceFactory(IConfigurationSource configurationSource)
            : base(configurationSource)
        {
        }
    }
}

