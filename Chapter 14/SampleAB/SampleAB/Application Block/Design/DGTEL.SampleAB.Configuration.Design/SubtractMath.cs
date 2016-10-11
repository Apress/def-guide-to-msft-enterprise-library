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
    public class SubtractMath : DGTEL.SampleAB.Configuration.Design.Math
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="SubtractMath"/> class.
        /// </summary>
        public SubtractMath()
            : this(new DGTEL.SampleAB.Configuration.SampleProviderData(Resources.SubtractMathName, typeof(SubtractProvider)))
        {
        }

        /// <summary>
        /// Initialize a new instance of the <see cref="SubtractMath"/> class with a <see cref="DGTEL.SampleAB.Configuration.CustomSampleProviderData"/> instance.
        /// </summary>
        /// <param name="data">A <see cref="DGTEL.SampleAB.Configuration.SampleProviderData"/> instance</param>
        public SubtractMath(DGTEL.SampleAB.Configuration.SampleProviderData data)
        {
            if (null == data) throw new ArgumentNullException("data");

            Rename(data.Name);
        }

        /// <summary>
        /// Gets the <see cref="DGTEL.SampleAB.Configuration.SampleProviderData"/> this node represents.
        /// </summary>
        /// <value>
        /// The <see cref="DGTEL.SampleAB.Configuration.SampleProviderData"/> this node represents.
        /// </value>
        [Browsable(false)]
        public override DGTEL.SampleAB.Configuration.SampleProviderData SampleProviderData
        {
            get
            {
                // TODO: Complete the DGTEL.SampleAB.Configuration.CustomSampleProviderData constructor parameters using the SubtractMath properties and fields
                DGTEL.SampleAB.Configuration.SampleProviderData data = new DGTEL.SampleAB.Configuration.SampleProviderData(this.Name, typeof(SubtractProvider));
                return data;
            }
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="SubtractMath"/> and optionally releases the managed resources.
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
