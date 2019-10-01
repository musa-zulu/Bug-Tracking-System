using System;
using BugTracker.Core.Domains;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace BugTracker.Core.Tests.Domains
{
    [TestFixture]
    class TestCompany
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Company());
            //---------------Test Result -----------------------
        }

        [TestCase("CompanyId", typeof(Guid))]
        [TestCase("Email", typeof(string))]
        [TestCase("CompanyName", typeof(string))]
        [TestCase("HomePhone", typeof(long))]
        [TestCase("MobilePhone", typeof(long))]
        [TestCase("Fax", typeof(long))]
        [TestCase("Address", typeof(string))]
        [TestCase("City", typeof(string))]
        [TestCase("Zip", typeof(int))]
        [TestCase("Country", typeof(string))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Company);

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
