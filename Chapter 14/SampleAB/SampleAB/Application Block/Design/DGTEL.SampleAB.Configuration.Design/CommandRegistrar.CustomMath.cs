using System;
using DGTEL.SampleAB.Configuration.Design.Properties;

namespace DGTEL.SampleAB.Configuration.Design
{
    sealed partial class CommandRegistrar
    {
        private void AddCustomMathCommand()
        {
            AddMultipleChildNodeCommand(
                Resources.CustomMathUICommandText,
                Resources.CustomMathUICommandLongText,
                typeof(CustomMath),
                typeof(DGTEL.SampleAB.Configuration.Design.ApplicationBlockSettingsNode));

        }
    }
}


