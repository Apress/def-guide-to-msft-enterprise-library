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
using System.Collections.Generic;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
using DGTEL.SampleAB.Configuration.Design.Properties;

namespace DGTEL.SampleAB.Configuration.Design
{
    sealed class NodeMapRegistrar : Microsoft.Practices.EnterpriseLibrary.Configuration.Design.NodeMapRegistrar
    {
        public NodeMapRegistrar(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public override void Register()
        {
        
 			 AddMultipleNodeMap(Resources.CustomMathUICommandText,
				typeof(CustomMath),
				typeof(DGTEL.SampleAB.Configuration.CustomSampleProviderData));             
 

 			 AddSingleNodeMap(Resources.AddMathUICommandText,
				typeof(AddMath),
				typeof(DGTEL.SampleAB.Configuration.SampleProviderData));             
 

 			 AddSingleNodeMap(Resources.SubtractMathUICommandText,
				typeof(SubtractMath),
				typeof(DGTEL.SampleAB.Configuration.SampleProviderData));                     
 
        }
    }
}
