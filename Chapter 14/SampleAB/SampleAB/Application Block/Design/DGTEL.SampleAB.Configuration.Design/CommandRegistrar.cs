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
using System.Text;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Configuration.Design;
using DGTEL.SampleAB.Configuration.Design.Properties;

namespace DGTEL.SampleAB.Configuration.Design
{
    sealed partial class CommandRegistrar : Microsoft.Practices.EnterpriseLibrary.Configuration.Design.CommandRegistrar
    {
        public CommandRegistrar(IServiceProvider serviceProvider)
            : base(serviceProvider)
        {
        }

        public override void Register()
        {
            AddBlockCommand();
            AddDefaultCommands(typeof(ApplicationBlockSettingsNode));
        
			AddCustomMathCommand();
			AddDefaultCommands(typeof(CustomMath));
			// TODO: Add other non-default commands to the CustomMath Design-Time Node.

			AddAddMathCommand();
			AddDefaultCommands(typeof(AddMath));
			// TODO: Add other non-default commands to the AddMath Design-Time Node.

			AddSubtractMathCommand();
			AddDefaultCommands(typeof(SubtractMath));
			// TODO: Add other non-default commands to the SubtractMath Design-Time Node.
}

        public void AddBlockCommand()
        {
            ConfigurationUICommand cmd = ConfigurationUICommand.CreateSingleUICommand(ServiceProvider,
                Resources.DGTEL_SampleAB,
                Resources.AddDGTEL_SampleAB,
                new AddApplicationBlockSettingsNodeCommand(ServiceProvider),
                typeof(ApplicationBlockSettingsNode));
            AddUICommand(cmd, typeof(ConfigurationApplicationNode));
        }
    }
}
