
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestMethodFalseQuery()
        {
            try
            {
                ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
                forSQL.SQLcommand("чушь");
                Assert.Fail();
            }
            catch
            {
                Assert.IsTrue(true);
            }
            

        }
        [TestMethod]
        public void TestMethodTrueQuery()
        {
            try
            {
                ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
                forSQL.SQLcommand("Select * from account");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }


        }
        [TestMethod]
        public void TestMethodAccount()
        {
            try
            {
                ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
                forSQL.SelectionRequest("account");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMethodBuyers()
        {
            try
            {
                ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
                forSQL.SelectionRequest("buyers");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMethodFurniture_models()
        {
            try
            {
                ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
                forSQL.SelectionRequest("furniture_models");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMethodSale()
        {
            try
            {
                ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
                forSQL.SelectionRequest("sale");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMethodSale_contracts()
        {
            try
            {
                ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
                forSQL.SelectionRequest("sale_contracts");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMethodSale_sale_contracts()
        {
            try
            {
                ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
                forSQL.SelectionRequest("sale_sale_contracts");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMethodEmployee()
        {
            try
            {
                ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
                forSQL.SelectionRequest("employee");
                Assert.IsTrue(true);
            }
            catch
            {
                Assert.Fail();
            }
        }
        [TestMethod]
        public void TestMethodErrorTable()
        {
            try
            {
                ForSQLClass.ForSqlClass forSQL = new ForSQLClass.ForSqlClass();
                forSQL.SelectionRequest("ErrorTable");
                Assert.Fail();               
            }
            catch
            {
                Assert.IsTrue(true);
            }
        }
    }
}
