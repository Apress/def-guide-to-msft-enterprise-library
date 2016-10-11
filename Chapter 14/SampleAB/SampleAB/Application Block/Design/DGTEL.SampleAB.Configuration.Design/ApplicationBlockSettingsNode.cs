//===============================================================================
// Microsoft patterns & practices Enterprise Library
// Application Block Software Factory
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY
// OF ANY KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT
// LIMITED TO THE IMPLIED WARRANTIES OF MERCHANTABILITY AND
// FITNESS FOR A PARTICULAR PURPOSE.
//===============================================================================

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Design;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
using DGTEL.SampleAB.Configuration.Design.Properties;

namespace DGTEL.SampleAB.Configuration.Design
{
    /// <summary>
    /// Represents the <see cref="ApplicationBlockSettings"/> configuration section.
    /// </summary>
    public sealed class ApplicationBlockSettingsNode : ConfigurationNode
    {
        private Math m_DefaultMathNode;

        /// <summary>
        /// Initialize a new instance of the <see cref="ApplicationBlockSettingsNode"/> class.
        /// </summary>
        public ApplicationBlockSettingsNode()
        {
        }

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="ApplicationBlockSettingsNode"/> and optionally releases the managed resources.
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

        /// <summary>
        /// Gets the name of the node.
        /// </summary>
        /// <value>
        /// The name of the node.
        /// </value>
        [ReadOnly(true)]
        public override string Name
        {
            get { return base.Name; }
        }

        /// <summary>
        /// Gets or sets the default database connection to use when none is specified.
        /// </summary>
        /// <value>
        /// The default database connection to use when none is specified.
        /// </value>
        [Editor(typeof(ReferenceEditor), typeof(UITypeEditor))]
        [ReferenceType(typeof(DGTEL.SampleAB.Configuration.Design.Math))]
        [SRCategory("CategoryGeneral", typeof(Resources))]
        [SRDescription("DefaultMathDescription", typeof(Resources))]
        public DGTEL.SampleAB.Configuration.Design.Math DefaultDatabase
        {
            get { return m_DefaultMathNode; }
            set
            {
                m_DefaultMathNode = value;
            }
        } 
    }
}
