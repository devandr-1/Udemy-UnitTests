using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using NUnit.Framework;
using UnitTestsLessons;

namespace UnitTestsLessonsTests
{
    [TestFixture]
    public class MathTests
    {
        private Math _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Math();
        }

        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            int result = _math.Add(2, 3);
            Assert.AreEqual(5, result);
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturTheGreaterArgument(int a, int b, int expected)
        {
            int result = _math.Max(a, b);
            Assert.AreEqual(expected, result);
        }
    }
}
