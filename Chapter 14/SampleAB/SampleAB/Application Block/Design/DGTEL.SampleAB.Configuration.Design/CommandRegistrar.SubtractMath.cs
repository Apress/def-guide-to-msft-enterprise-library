using System;
using DGTEL.SampleAB.Configuration.Design.Properties;

namespace DGTEL.SampleAB.Configuration.Design
{
    sealed partial class CommandRegistrar
    {
        private void AddSubtractMathCommand()
        {
            AddSingleChildNodeCommand(
                Resources.SubtractMathUICommandText,
                Resources.SubtractMathUICommandLongText,
                typeof(SubtractMath),
                typeof(DGTEL.SampleAB.Configuration.Design.ApplicationBlockSettingsNode));


        }
    }
}


