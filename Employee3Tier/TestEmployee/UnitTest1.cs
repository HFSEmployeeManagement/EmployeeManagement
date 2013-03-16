using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeEntity;
using EmployeeBusinesslayer;
using System.Collections.Generic;

namespace TestEmployee
{
    
    [TestClass]
    public class UnitTest1
    {
        Entity ent = new Entity();
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void TestCreate()
        {
            Business b = new Business();
            ent.Employeeid = 27;
            ent.Firstname = "Prakash";
            ent.Lastname = "Pawar";
            ent.Birthdate = "5/5/1945";
            ent.Sex = "Male";
            int i= b.CreateEmp(ent);
            Assert.AreEqual(1, i);
        }
        [TestMethod]
        public void CheckId()
        {
            Business b = new Business();
            ent.Employeeid = 2;
            int i = b.GetId(ent);
            Assert.AreEqual(1, i);
        }
        [TestMethod]
        public void CheckAge()
        {
            Business b = new Business();
            ent.Birthdate = "5/5/1988 00:00:00";
            //string birth = "10/19/2005 00:00:00";
            int i = b.CheckAge(ent);
            Assert.AreEqual(1, i);
        }
      
    }
}
