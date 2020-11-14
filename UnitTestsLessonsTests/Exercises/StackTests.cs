using System;
using System.Text;
using NUnit.Framework;
using UnitTestsLessons.Exercises;

namespace UnitTestsLessonsTests.Exercises
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<string>();
        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_PushNull_ThrowsArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_PushObject_CountShouldIncrease()
        {
            _stack.Push("a");

            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_WhenCalledOnEmptyStack_ThrowsInvalidOperationException()
        {
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Pop_WhenCalled_ReturnLastElementAndRemoveItFromStack()
        {
            _stack.Push("a");
            _stack.Push("b");

            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo("b"));
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Peek_WhenCalledOnEmptyStack_ThrowInvalidOperationException()
        {
            Assert.That(() => _stack.Peek(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_WhenCalled_ReturnLastElementWithoutRemoving()
        {
            _stack.Push("a");
            _stack.Push("b");

            var result = _stack.Peek();

            Assert.That(result, Is.EqualTo("b"));
            Assert.That(_stack.Count, Is.EqualTo(2));
        }
    }
}
