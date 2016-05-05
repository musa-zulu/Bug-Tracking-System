using System;
using BugTracker.Core.Domains;
using BugTracker.Web.Models;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace BugTracker.Web.Tests.Models
{
    [TestFixture]
    public class TestUserViewModel
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(()=> new UserViewModel());
            //---------------Test Result -----------------------
        }

        [TestCase("UserId", typeof(Guid))]
        [TestCase("FirstName", typeof(string))]
        [TestCase("LastName", typeof(string))]
        [TestCase("Company", typeof(Company))]
        [TestCase("BugId", typeof(Guid))]
        [TestCase("Issue", typeof(Issue))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(UserViewModel);
            //---------------Assert Precondition----------------
            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
