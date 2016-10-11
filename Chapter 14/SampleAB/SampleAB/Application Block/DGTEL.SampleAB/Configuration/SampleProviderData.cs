using System;
using System.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;
using DGTEL.SampleAB;

namespace DGTEL.SampleAB.Configuration
{
    /// <summary>
    ///  
    /// </summary>
    [Assembler(typeof(TypeInstantiationAssembler<ISampleProvider, SampleProviderData>))]
    public class SampleProviderData : NameTypeConfigurationElement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SampleProviderData"/> class.
        /// </summary>
        public SampleProviderData()
        {
        }

        /// <summary>
        /// Initialize an instance of the <see cref="SampleProviderData"/> class.
        /// </summary>
        /// <param name="name">The name of the element.</param>
        /// <param name="type">The <see cref="Type"/> that this element is the configuration for.</param>
        public SampleProviderData(string name, Type type)
            : base(name, type)
        {
        }
    }
}
