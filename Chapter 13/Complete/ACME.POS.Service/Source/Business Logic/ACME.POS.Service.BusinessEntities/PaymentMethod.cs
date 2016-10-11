using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.POS.Service.BusinessEntities
{
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
        }

        public PaymentMethod(System.String name, System.Int32 paymentMethodId)
        {
            this.nameField = name;
            this.paymentMethodIdField = paymentMethodId;
        }

        private System.String nameField;

        public System.String Name
        {
            get { return this.nameField; }
            set { this.nameField = value; }
        }

        private System.Int32 paymentMethodIdField;

        public System.Int32 PaymentMethodId
        {
            get { return this.paymentMethodIdField; }
            set { this.paymentMethodIdField = value; }
        }

    }
}

