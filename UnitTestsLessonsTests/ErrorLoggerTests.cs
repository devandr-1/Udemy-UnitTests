using NUnit.Framework;
using System;
using UnitTestsLessons;

namespace UnitTestsLessonsTests
{
    [TestFixture]
    public class ErrorLoggerTests
    {
        [Test]
        public void Log_WhenCalled_SetTheLastErrorProperty()
        {
            ErrorLogger logger = new ErrorLogger();
            string errorMessage = "a";

            logger.Log(errorMessage);

            Assert.That(logger.LastError, Is.EqualTo(errorMessage));
        }

        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase(" ")]
        public void Log_InvalidError_ThrowArgumentNullException(string error)
        {
            ErrorLogger logger = new ErrorLogger();

            Assert.That(() => logger.Log(error), Throws.ArgumentNullException);
        }

        [Test]
        public void Log_ValidError_RaiseErrorLoggedEvent()
        {
            ErrorLogger logger = new ErrorLogger();

            var id = Guid.Empty;
            logger.ErrorLogged += (sender, args) => { id = args; };

            logger.Log("a");

            Assert.That(id, Is.Not.EqualTo(Guid.Empty));
        }
    }
}
