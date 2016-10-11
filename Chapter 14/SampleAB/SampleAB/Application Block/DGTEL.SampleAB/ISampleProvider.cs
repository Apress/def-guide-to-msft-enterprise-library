using DGTEL.SampleAB.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;

namespace DGTEL.SampleAB
{
    /// <summary>
    /// Defines the basic functionality of an SampleProvider
    /// </summary>
    [ConfigurationNameMapper(typeof(SampleProviderDataRetriever))]
    [CustomFactory(typeof(SampleProviderCustomFactory))]
    public interface ISampleProvider
    {
        int DoMath(int x, int y);
    }
}
