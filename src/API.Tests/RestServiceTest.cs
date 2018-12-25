using API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Refit;
using System;

namespace API.Tests
{
    [TestClass]
    public class RestServiceTest
    {
        [TestMethod]
        public void TestGetUser()
        {
            var service = RestService.For<IUserApi>("http://localhost:51018");
            var r = service.GetUser(1, "test", new DateTime(1998, 1, 1)).Result as User;
            Assert.IsTrue(r != null && r.Id == 1 && r.Name == "test");
        }

        [TestMethod]
        public void TestGetUserByParas()
        {
            var service = RestService.For<IUserApi>("http://localhost:51018");
            var p = new Paras()
            {
                Name = "pan",
                Birthday = new DateTime(1995, 1, 1)
            };
            var r = service.GetUserByParas(1, p).Result as User;
            Assert.IsTrue(r != null && r.Id == 1 && r.Name == p.Name);
        }

        [TestMethod]
        public void TestCreate()
        {
            var service = RestService.For<IUserApi>("http://localhost:51018");
            var p = new Paras()
            {
                Name = "pan",
                Birthday = new DateTime(1995, 1, 1)
            };
            var r = service.Create(p).Result;
            Assert.IsTrue(r != null && r.Id == 1 && r.Name == p.Name);
        }
    }
}
