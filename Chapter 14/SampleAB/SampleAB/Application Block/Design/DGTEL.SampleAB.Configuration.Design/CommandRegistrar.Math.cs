using System;
using DGTEL.SampleAB.Configuration.Design.Properties;

namespace DGTEL.SampleAB.Configuration.Design
{
    sealed partial class CommandRegistrar
    {
        private void AddMathCommand()
        {
            AddMultipleChildNodeCommand(
                Resources.MathUICommandText,
                Resources.MathUICommandLongText,
                typeof(Math),
                typeof(DGTEL.SampleAB.Configuration.Design.ApplicationBlockSettingsNode));

        }
    }
}


