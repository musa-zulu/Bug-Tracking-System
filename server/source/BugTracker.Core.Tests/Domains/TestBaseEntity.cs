using System;
using BugTracker.Core.Domains;
using NUnit.Framework;
using PeanutButter.TestUtils.Generic;

namespace BugTracker.Core.Tests.Domains
{
    [TestFixture]
    public class TestBaseEntity
    {
        [Test]
        public void Construct()
        {
            //---------------Set up test pack-------------------

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            Assert.DoesNotThrow(() => new BaseEntity());
            //---------------Test Result -----------------------
        }

        [TestCase("DateCreated", typeof(DateTime?))]
        [TestCase("CreatedUsername", typeof(string))]
        [TestCase("DateLastModified", typeof(DateTime?))]
        [TestCase("LastModifiedUsername", typeof(string))]
        public void Type_ShouldHaveProperty(string propertyName, Type propertyType)
        {
            //---------------Set up test pack-------------------
            var sut = typeof(BaseEntity);

            //---------------Assert Precondition----------------

            //---------------Execute Test ----------------------
            sut.ShouldHaveProperty(propertyName, propertyType);
            //---------------Test Result -----------------------
        }
    }
}

