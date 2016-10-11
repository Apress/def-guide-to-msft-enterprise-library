using System;
using System.Net;
using System.Net.NetworkInformation;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

namespace ACME.POS.Validators
{
    public class HostValidator : ValueValidator<string>
    {
        //constuctors
        #region constructors…
        public HostValidator()
            : this(null)
        { }

        public HostValidator(bool negated)
            : this(null, negated)
        { }

        public HostValidator(string messageTemplate)
            : base(messageTemplate, null, false)
        { }

        public HostValidator(string messageTemplate, bool negated)
            : base(messageTemplate, null, negated)
        { }

        #endregion

        protected override void DoValidate(string objectToValidate,
            object currentTarget,
            string key,
            ValidationResults validationResults)
        {
            IPAddress ip = null;

            if (!string.IsNullOrEmpty(objectToValidate)
            && (IPAddress.TryParse(objectToValidate, out ip)
            || IsValidHost(objectToValidate)))
            {
                Ping ping = new Ping();
                PingReply reply = ping.Send(objectToValidate);
                if (reply.Status != IPStatus.Success)
                {
                    string message = this.MessageTemplate;
                    LogValidationResult(validationResults, message, currentTarget, key);
                }
            }
            else
            {
                string message = this.MessageTemplate;
                LogValidationResult(validationResults, message, currentTarget, key);
            }
        }

        private bool IsValidHost(string hostName)
        {
            IPHostEntry host;
            
            try
            {
                host = Dns.GetHostEntry(hostName);
                if (host.AddressList.Length > 0)
                    return true;
                else
                    return false;
            }
            catch
            {
                    return false;
            }
        }

        protected override string DefaultNegatedMessageTemplate
        {
            get { return "Host Name or IP Address is valid."; }
        }

        protected override string DefaultNonNegatedMessageTemplate
        {
            get { return "Host Name or IP Address is not valid."; }
        }
    }
}
