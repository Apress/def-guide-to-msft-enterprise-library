using Microsoft.Practices.EnterpriseLibrary.Common.Instrumentation;
using DGTEL.SampleAB.Configuration;

namespace DGTEL.SampleAB
{
    /// <summary>
    /// Abstract implementation of the <see cref="ISampleProvider"/> interface.
    /// </summary>
    public abstract class SampleProvider : ISampleProvider
    {
        #region ISampleProvider Members

        public int DoMath(int x, int y)
        {
            int z = Calculate(x, y);
            if (z < 0)
                z = 0;
            return z;
        }

        #endregion

        protected abstract int Calculate(int x, int y);
    }
}
