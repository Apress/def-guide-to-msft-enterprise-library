//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ACME.POS.Service.DataTypes
{


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://ACME.POS.Service.DataTypes/2007/06", IsNullable = false)]
    public class BillingMethod
    {

        private int billingMethodId;

        private int customerId;

        private int paymentMethodId;

        private string creditCardNumber;

        private System.DateTime creditCardExpiration;

        private int creditCardBillingAddressId;

        private int netTermDays;

        private bool isActive;

        public int BillingMethodId
        {
            get
            {
                return this.billingMethodId;
            }
            set
            {
                this.billingMethodId = value;
            }
        }

        public int CustomerId
        {
            get
            {
                return this.customerId;
            }
            set
            {
                this.customerId = value;
            }
        }

        public int PaymentMethodId
        {
            get
            {
                return this.paymentMethodId;
            }
            set
            {
                this.paymentMethodId = value;
            }
        }

        public string CreditCardNumber
        {
            get
            {
                return this.creditCardNumber;
            }
            set
            {
                this.creditCardNumber = value;
            }
        }

        public System.DateTime CreditCardExpiration
        {
            get
            {
                return this.creditCardExpiration;
            }
            set
            {
                this.creditCardExpiration = value;
            }
        }

        public int CreditCardBillingAddressId
        {
            get
            {
                return this.creditCardBillingAddressId;
            }
            set
            {
                this.creditCardBillingAddressId = value;
            }
        }

        public int NetTermDays
        {
            get
            {
                return this.netTermDays;
            }
            set
            {
                this.netTermDays = value;
            }
        }

        public bool IsActive
        {
            get
            {
                return this.isActive;
            }
            set
            {
                this.isActive = value;
            }
        }
    }
}
