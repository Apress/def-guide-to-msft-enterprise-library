using System;
using System.Collections.Generic;
using System.Text;

namespace ACME.POS.Service.BusinessEntities
{
    public partial class Address
    {
        public Address()
        {
        }

        public Address(System.String address, System.Int32 addressId, System.String city, System.Int32 customerId, System.Boolean isActive, System.Boolean isPrimaryShipping, System.String state, System.String zipCode)
        {
            this.addressField = address;
            this.addressIdField = addressId;
            this.cityField = city;
            this.customerIdField = customerId;
            this.isActiveField = isActive;
            this.isPrimaryShippingField = isPrimaryShipping;
            this.stateField = state;
            this.zipCodeField = zipCode;
        }

        private System.String addressField;

        public System.String StreetAddress
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        private System.Int32 addressIdField;

        public System.Int32 AddressId
        {
            get { return this.addressIdField; }
            set { this.addressIdField = value; }
        }

        private System.String cityField;

        public System.String City
        {
            get { return this.cityField; }
            set { this.cityField = value; }
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

        private System.Boolean isPrimaryShippingField;

        public System.Boolean IsPrimaryShipping
        {
            get { return this.isPrimaryShippingField; }
            set { this.isPrimaryShippingField = value; }
        }

        private System.String stateField;

        public System.String State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        private System.String zipCodeField;

        public System.String ZipCode
        {
            get { return this.zipCodeField; }
            set { this.zipCodeField = value; }
        }

    }
}

