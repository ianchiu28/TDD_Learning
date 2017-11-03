using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD_Learning;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Learning.Tests
{
    [TestClass()]
    public class ValidationTests
    {
        [TestMethod()]
        public void CheckAuthenticationTest()
        {
            // arrange
            IAccountDao dao = new StubAccountDao();
            IHash hash = new StubHash();
            Validation target = new Validation(dao, hash);
            string id = string.Empty;
            string password = string.Empty;
            bool expected = true;

            // act
            bool actual;
            actual = target.CheckAuthentication(id, password);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}