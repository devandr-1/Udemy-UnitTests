using NUnit.Framework;
using UnitTestsLessons;

namespace UnitTestsLessonsTests
{
    [TestFixture]
    public class HtmlFormaterTests
    {
        [Test]
        public void FormatAsBold_WhenCalled_ShouldEncloseTheStringWithStrongElement()
        {
            HtmlFormater formater = new HtmlFormater();
            string content = "abc";
            
            string result = formater.FormatAsBold(content);

            Assert.That(result, Does.StartWith("<strong>").IgnoreCase);
            Assert.That(result, Does.EndWith("</strong>").IgnoreCase);
            Assert.That(result, Does.Contain(content));
        }
    }
}
