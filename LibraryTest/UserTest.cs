using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class UserTest
    {
        private User user;

        [SetUp]
        public void Init()
        {
            user = new User();
        }

        [Test]
        public void TestUserValid()
        {
            var userName = "admin";
            var password = "admin";

            Assert.IsTrue(user.IsValidUser(userName, password));
        }
    }
}
