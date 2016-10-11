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
    /// This provider adds two numbers and returns the result.
    /// </summary>
    [ConfigurationElementType(typeof(
    SampleAB.Configuration.CustomSampleProviderData))]
    public class AddProvider : SampleAB.SampleProvider
    {
        /// <summary>
        /// <para>Initializes a new instance of the
        /// <see cref="AddProvider"/>.</para>
        /// </summary>
        /// <param name="values">The value collection used to
        /// set the runtime values.</param>
        public AddProvider(NameValueCollection values)
        {
            // TODO: Later. Use the NameValueCollection object
            // to set runtime values for the AddProvider
        }

        protected override int Calculate(int x, int y)
        {
            return x + y;
        }
    }
}

