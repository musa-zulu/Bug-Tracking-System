using System;
using BugTracker.Core.Domains;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace BugTracker.Core.Tests.Domains
{
    [TestFixture]
    class TestProject
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Project());
            //---------------Test Result -----------------------
        }

        [TestCase("ProjectId", typeof(Guid))]
        [TestCase("ProjectName", typeof(string))]
        [TestCase("CompanyId", typeof(Guid))]
        [TestCase("Company", typeof(Company))]
        [TestCase("UserId", typeof(Guid))]
        [TestCase("User", typeof(User))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Project);

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
