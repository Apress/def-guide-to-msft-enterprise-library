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
    /// Represents a <see cref="DGTEL.SampleAB.Configuration.CustomSampleProviderData"/> configuration element. 
    /// </summary>
    public class CustomMath : Math
    {
        private List<EditableKeyValue> editableAttributes = new List<EditableKeyValue>();
        private string customTypeName;

        /// <summary>
        /// Initialize a new instance of the <see cref="CustomMath"/> class.
        /// </summary>
        public CustomMath()
            : this(new DGTEL.SampleAB.Configuration.CustomSampleProviderData(Resources.CustomMathName, string.Empty))
        { }

        /// <summary>
        /// Initialize a new instance of the <see cref="CustomMath"/> class with a <see cref="DGTEL.SampleAB.Configuration.CustomSampleProviderData"/> instance.
        /// </summary>
        /// <param name="customData">A <see cref="DGTEL.SampleAB.Configuration.CustomSampleProviderData"/> instance</param>
        public CustomMath(DGTEL.SampleAB.Configuration.CustomSampleProviderData customData)
        {
            if (null == customData) throw new ArgumentNullException("customData");

            Rename(customData.Name);

            customTypeName = customData.TypeName;
            foreach (string key in customData.Attributes)
            {
                editableAttributes.Add(new EditableKeyValue(key, customData.Attributes[key]));
            }
        }

        /// <summary>
        /// Gets the custom attributes for the filter.
        /// </summary>
        /// <value>
        /// The custom attributes for the filter.
        /// </value>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists"), SRCategory("CategoryGeneral", typeof(Resources))]
        [SRDescription("CustomFilterExtensionsDescription", typeof(Resources))]
        [CustomAttributesValidation]
        public List<EditableKeyValue> Attributes
        {
            get
            {
                return editableAttributes;
            }
        }

        /// <summary>
        /// Gets or sets the <see cref="Type"/> of the custom provider.
        /// </summary>
        /// <value>
        /// The <see cref="Type"/> of the custom provider.
        /// </value>
        [Required]
        [Editor(typeof(TypeSelectorEditor), typeof(UITypeEditor))]
        [BaseType(typeof(object))]
        [SRCategory("CategoryGeneral", typeof(Resources))]
        [SRDescription("CustomTypeDescription", typeof(Resources))]
        public string Type
        {
            get { return customTypeName; }
            set { customTypeName = value; }
        }

        /// <summary>
        /// Gets the <see cref="DGTEL.SampleAB.Configuration.CustomSampleProviderData"/> this node represents.
        /// </summary>
        /// <value>
        /// The <see cref="DGTEL.SampleAB.Configuration.CustomSampleProviderData"/> this node represents.
        /// </value>
        [Browsable(false)]
        public override DGTEL.SampleAB.Configuration.SampleProviderData SampleProviderData
        {
            get
            {
                DGTEL.SampleAB.Configuration.CustomSampleProviderData customData = new DGTEL.SampleAB.Configuration.CustomSampleProviderData(Name, Type);

                foreach (EditableKeyValue kv in editableAttributes)
                {
                    customData.Attributes.Add(kv.Key, kv.Value);
                }

                return customData;
            }
        }
    }
}
