using System;
using DGTEL.SampleAB.Configuration.Design.Properties;

namespace DGTEL.SampleAB.Configuration.Design
{
    sealed partial class CommandRegistrar
    {
        private void AddAddMathCommand()
        {
            AddSingleChildNodeCommand(
                Resources.AddMathUICommandText,
                Resources.AddMathUICommandLongText,
                typeof(AddMath),
                typeof(DGTEL.SampleAB.Configuration.Design.ApplicationBlockSettingsNode));

        }
    }
}


