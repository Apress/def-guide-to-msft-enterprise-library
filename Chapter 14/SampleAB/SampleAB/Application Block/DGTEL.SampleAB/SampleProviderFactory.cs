using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Instrumentation;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;
using DGTEL.SampleAB.Properties;

namespace DGTEL.SampleAB
{
    /// <summary>
    /// Contains factory methods for creating SampleProvider objects.
    /// </summary>
    public static class SampleProviderFactory
    {
        /// <summary>
        /// Method for invoking a default  SampleProvider  object. Reads default settings
        /// from the ConnectionSettings.config file.
        /// </summary>
        /// <example>
        /// <code>
        /// ISampleProvider object = SampleProviderFactory.CreateSampleProvider();
        /// </code>
        /// </example>
        /// <returns>ISampleProvider</returns>
        /// <exception cref="System.Configuration.ConfigurationException">
        /// <para>An error occured while reading the configuration.</para>
        /// </exception>
        public static ISampleProvider CreateSampleProvider()
        {
            try
            {
                SampleProviderInstanceFactory factory = new SampleProviderInstanceFactory(ConfigurationSourceFactory.Create());
                return factory.CreateDefault();
            }
            catch (ConfigurationErrorsException configurationException)
            {
                TryLogConfigurationError(configurationException, "default");
                throw;
            }
        }

        /// <summary>
        /// Method for invoking a specified SampleProvider service object.  Reads service settings
        /// from the ConnectionSettings.config file.
        /// </summary>
        /// <example>
        /// <code>
        /// ISampleProvider object = SampleProviderFactory.CreateSampleProvider("instanceName");
        /// </code>
        /// </example>
        /// <param name="name">configuration key for SampleProvider </param>
        /// <returns>ISampleProvider</returns>
        /// <exception cref="System.Configuration.ConfigurationException">
        /// <para><paramref name="instanceName"/> is not defined in configuration.</para>
        /// <para>- or -</para>
        /// <para>An error exists in the configuration.</para>
        /// <para>- or -</para>
        /// <para>An error occured while reading the configuration.</para>        
        /// </exception>
        /// <exception cref="System.Reflection.TargetInvocationException">
        /// <para>The constructor being called throws an exception.</para>
        /// </exception>
        public static ISampleProvider CreateSampleProvider(string name)
        {
            try
            {
                SampleProviderInstanceFactory factory = new SampleProviderInstanceFactory(ConfigurationSourceFactory.Create());
                return factory.Create(name);
            }
            catch (ConfigurationErrorsException configurationException)
            {
                TryLogConfigurationError(configurationException, name);

                throw;
            }
        }

        private static void TryLogConfigurationError(ConfigurationErrorsException configurationException, string instanceName)
        {
            // TODO: Include your logging logic for SampleProvider configuration errors.
        }
    }
}
