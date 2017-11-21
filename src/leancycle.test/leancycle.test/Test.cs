﻿using NUnit.Framework;
using System;
namespace leancycle.test
{
    [TestFixture("Oscar")]
    [TestFixture("Paul")]
    [TestFixture("Peter")]
    public class NameTest
    {
        private string _name;

        public NameTest(string name)
        {
            _name = name;
        }

        [Test]
        public void Test_something_that_depends_on_name()
        {
            Assert.That(_name, Is.Not.Null);
        }

        [Test]
        public void Test_something_that_also_depends_on_name()
        {
            Assert.That(_name, Is.Not.Empty);
        }
    }
}
