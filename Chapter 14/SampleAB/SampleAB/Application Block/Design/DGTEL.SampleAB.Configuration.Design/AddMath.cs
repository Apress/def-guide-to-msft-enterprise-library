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
    public class AddMath : DGTEL.SampleAB.Configuration.Design.Math
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="AddMath"/> class.
        /// </summary>
        public AddMath()
            : this(new DGTEL.SampleAB.Configuration.SampleProviderData(Resources.AddMathName, typeof(AddProvider)))
        {
        }

        /// <summary>
        /// Initialize a new instance of the <see cref="AddMath"/> class with a <see cref="DGTEL.SampleAB.Configuration.CustomSampleProviderData"/> instance.
        /// </summary>
        /// <param name="data">A <see cref="DGTEL.SampleAB.Configuration.SampleProviderData"/> instance</param>
        public AddMath(DGTEL.SampleAB.Configuration.SampleProviderData data)
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
                // TODO: Complete the DGTEL.SampleAB.Configuration.SampleProviderData constructor parameters using the AddMath properties and fields
                DGTEL.SampleAB.Configuration.SampleProviderData data = new DGTEL.SampleAB.Configuration.SampleProviderData(this.Name, typeof(AddProvider));
                return data;
            }
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="AddMath"/> and optionally releases the managed resources.
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
