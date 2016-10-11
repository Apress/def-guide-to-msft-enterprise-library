using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration;
using Microsoft.Practices.EnterpriseLibrary.Common.Configuration.ObjectBuilder;
using Microsoft.Practices.EnterpriseLibrary.Common.Instrumentation;

namespace DGTEL.SampleAB
{
    /// <summary>
    /// Subtracts two numbers
    /// </summary>
    [ConfigurationElementType(typeof(DGTEL.SampleAB.Configuration.CustomSampleProviderData))]
    public class SubtractProvider : DGTEL.SampleAB.SampleProvider
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="SubtractProvider"/>.</para>
        /// </summary>
        /// <param name="values">The value collection used to set the runtime values.</param>
        public SubtractProvider(NameValueCollection values)
        {
            // TODO: Later. Use the NameValueCollection object to set runtime values for the SubtractProvider
        }

        protected override int Calculate(int x, int y)
        {
            return x - y;
        }
    }
}

