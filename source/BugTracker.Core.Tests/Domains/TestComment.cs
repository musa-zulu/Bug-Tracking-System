using System;
using System.Collections.Generic;
using BugTracker.Core.Domains;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace BugTracker.Core.Tests.Domains
{
    [TestFixture]
    public class TestComment
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new Comment());
            //---------------Test Result -----------------------
        }

        
        [TestCase("CommentId", typeof(Guid))]
        [TestCase("BugId", typeof(Guid))]
        [TestCase("Issue", typeof(Issue))]
        [TestCase("UserId", typeof(Guid))]
        [TestCase("User", typeof(User))]
        [TestCase("Company", typeof(Company))]
        [TestCase("ProjectId", typeof(Guid))]
        [TestCase("Project", typeof(Project))]
        [TestCase("CommentNote", typeof(string))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(Comment);

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}
