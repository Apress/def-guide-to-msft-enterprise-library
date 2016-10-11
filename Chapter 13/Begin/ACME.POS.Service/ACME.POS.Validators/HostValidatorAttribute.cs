using System;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace ACME.POS.Validators
{
    [AttributeUsage(AttributeTargets.Property
        | AttributeTargets.Field
        | AttributeTargets.Method
        | AttributeTargets.Parameter,
    AllowMultiple = true,
    Inherited = false)]
    public sealed class HostValidatorAttribute : ValueValidatorAttribute
    {
        public HostValidatorAttribute()
        { }

        protected override Validator DoCreateValidator(Type targetType)
        {
            return new HostValidator();
        }
    }
}
