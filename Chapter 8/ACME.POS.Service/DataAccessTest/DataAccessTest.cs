using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ACME.POS.Domain.DAL;
using ACME.POS.Domain.Entity;

namespace DataAccessTest
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class DataAccessUnitTest
    {
        public DataAccessUnitTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void SaveCustomerTest()
        {
            CustomerList list = new CustomerList();
            Customer customer = new Customer();
            customer.FirstName = "Test";
            customer.LastName = "Test";
            customer.MemberSince = DateTime.Now;
            customer.CustomerId = 0;
            customer.BirthDate = DateTime.Now;
            customer.IsActive = true;
            list.Add(customer);

            CustomerDAL dal = new CustomerDAL();
            dal.SaveCustomers(list);
        }
    }
}
