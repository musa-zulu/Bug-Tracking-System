using System;
using BugTracker.Core.Domains;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace BugTracker.Core.Tests.Domains
{
    [TestFixture]
    class TestIssue
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Issue());
            //---------------Test Result -----------------------
        }
        
        [TestCase("UserId", typeof(Guid))]
        [TestCase("BugId", typeof(Guid))]
        [TestCase("CompanyId", typeof(Guid))]
        [TestCase("UserId", typeof(Guid))]
        [TestCase("User", typeof(User))]
        [TestCase("Company", typeof(Company))]
        [TestCase("ProjectId", typeof(Guid))]
        [TestCase("Project", typeof(Project))]
        [TestCase("Priority", typeof(string))]
        [TestCase("Category", typeof(Category))]
        [TestCase("Status", typeof(Status))]
        [TestCase("OpenedBy", typeof(string))]
        [TestCase("DateLogged", typeof(DateTime))]
        [TestCase("DueDate", typeof(DateTime))]
        [TestCase("Summary", typeof(string))]
        [TestCase("Resolution", typeof(string))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Issue);

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
