using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.POS.Service.BusinessEntities
{
    public partial class BillingMethod
    {
        public BillingMethod()
        {
        }

        public BillingMethod(System.Int32 billingMethodId, Nullable<System.Int32> creditCardBillingAddressId, Nullable<System.DateTime> creditCardExpiration, System.String creditCardNumber, System.Int32 customerId, System.Boolean isActive, Nullable<System.Int32> netTermDays, System.Int32 paymentMethodId)
        {
            this.billingMethodIdField = billingMethodId;
            this.creditCardBillingAddressIdField = creditCardBillingAddressId;
            this.creditCardExpirationField = creditCardExpiration;
            this.creditCardNumberField = creditCardNumber;
            this.customerIdField = customerId;
            this.isActiveField = isActive;
            this.netTermDaysField = netTermDays;
            this.paymentMethodIdField = paymentMethodId;
        }

        private System.Int32 billingMethodIdField;

        public System.Int32 BillingMethodId
        {
            get { return this.billingMethodIdField; }
            set { this.billingMethodIdField = value; }
        }

        private Nullable<System.Int32> creditCardBillingAddressIdField;

        public Nullable<System.Int32> CreditCardBillingAddressId
        {
            get { return this.creditCardBillingAddressIdField; }
            set { this.creditCardBillingAddressIdField = value; }
        }

        private Nullable<System.DateTime> creditCardExpirationField;

        public Nullable<System.DateTime> CreditCardExpiration
        {
            get { return this.creditCardExpirationField; }
            set { this.creditCardExpirationField = value; }
        }

        private System.String creditCardNumberField;

        public System.String CreditCardNumber
        {
            get { return this.creditCardNumberField; }
            set { this.creditCardNumberField = value; }
        }

        private System.Int32 customerIdField;

        public System.Int32 CustomerId
        {
            get { return this.customerIdField; }
            set { this.customerIdField = value; }
        }

        private System.Boolean isActiveField;

        public System.Boolean IsActive
        {
            get { return this.isActiveField; }
            set { this.isActiveField = value; }
        }

        private Nullable<System.Int32> netTermDaysField;

        public Nullable<System.Int32> NetTermDays
        {
            get { return this.netTermDaysField; }
            set { this.netTermDaysField = value; }
        }

        private System.Int32 paymentMethodIdField;

        public System.Int32 PaymentMethodId
        {
            get { return this.paymentMethodIdField; }
            set { this.paymentMethodIdField = value; }
        }

    }
}

