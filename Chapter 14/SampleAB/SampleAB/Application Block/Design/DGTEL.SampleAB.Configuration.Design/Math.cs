using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Drawing.Design;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design.Validation;
using DGTEL.SampleAB.Configuration.Design.Properties;

namespace DGTEL.SampleAB.Configuration.Design
{
    /// <summary>
    /// Represents a <see cref="DGTEL.SampleAB.Configuration.SampleProviderData"/> configuration element. 
    /// </summary>
    public abstract class Math : Microsoft.Practices.EnterpriseLibrary.Configuration.Design.ConfigurationNode
    {

        /// <summary>
        /// Initialize a new instance of the <see cref="Math"/> class.
        /// </summary>
        public Math()
        {
        }

        /// <summary>
        /// Gets the <see cref="DGTEL.SampleAB.Configuration.SampleProviderData"/> this node represents.
        /// </summary>
        /// <value>
        /// The <see cref="DGTEL.SampleAB.Configuration.SampleProviderData"/> this node represents.
        /// </value>
        [Browsable(false)]
        public abstract DGTEL.SampleAB.Configuration.SampleProviderData SampleProviderData { get; }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="Math"/> and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// <see langword="true"/> to release both managed and unmanaged resources; <see langword="false"/> to release only unmanaged resources.
        /// </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
            base.Dispose(disposing);
        }

    }
}
