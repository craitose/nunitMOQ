using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathOperations;
using Moq;

namespace NUnitTest
{
    [TestFixture]
    public class MathTestClass
    {
        public int i = 10, j = 25;
        public bool result;

        [SetUp]
        public void checkNonNegative()
        {
            if(i>0 && j>0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

        }

        [TearDown]
        public void setupDefaultvalues()
        {
            result = false;
        }

        [Test]
        public void testSum()
        {
            if (result) // if result is true
            {
                Maths m = new Maths();
                Assert.AreEqual(35, m.sum(i, j));
            }
            else
            {
                Assert.Fail();
            }
        }

        [Test]
        [TestCase(10,5,5)]
        [TestCase(10,5,1)]
        public void testSub(int a,int b, int expected)
        {
            Maths m = new Maths();
            Assert.AreEqual(expected, m.sub(a, b));
        }

        [Test]
        [Ignore("Not yet Implemented")]
        public void testMul()
        {
            Maths m = new Maths();
            Assert.AreEqual(250, m.mul(i, j));

        }

        [Test]
        public void checkValues()
        {
            Mock<Maths> mock = new Mock<Maths>(); // create new object in mock
            mock.Setup(x => x.checkDigitsOnly()).Returns(true); // overrride the virtaul result
            
            Assert.AreEqual(true, mock.Object.checkDigitsOnly()); // compare the exptected to mock object

        }

    }
}
