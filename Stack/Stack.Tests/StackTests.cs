using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Stack.Tests
{
    [TestClass]
    public class StackTests
    {
        public StackTests() 
        { }

        [TestMethod]
        public void CanPopItemOffStack()
        {
            Stack<string> s = new Stack<string>();
            s.Push("foo");
            Assert.AreEqual("foo", s.Pop());
        }

        [TestMethod]
        public void IsLastInFirstOutOfStack()
        {
            Stack<string> s = new Stack<string>();
            s.Push("foo");
            s.Push("bar");
            Assert.AreEqual("bar", s.Pop());
            Assert.AreEqual("foo", s.Pop());
        }

        [TestMethod]
        public void FailsOnEmptyStack()
        {
            Stack<int> s = new Stack<int>();
            Assert.ThrowsException<InvalidOperationException>(() => s.Pop());
        }

        [TestMethod]
        public void CantPushNull()
        {
            Stack<string> s = new Stack<string>();
            Assert.ThrowsException<ArgumentNullException>(() => s.Push(null));
        }

        [TestMethod]
        public void CanIncrement()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Push(6);
            s.Push(7);
            s.Push(8);
            s.Push(9);
            s.Push(10);
            s.Push(11);
            s.Push(12);
            Assert.AreEqual(12, s.Pop());
            Assert.AreEqual(11, s.Pop());
            Assert.AreEqual(10, s.Pop());
        }

        [TestMethod]
        public void CanPopAndPush()
        {
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);
            s.Push(5);
            s.Push(6);
            s.Push(7);
            s.Push(8);
            s.Push(9);
            s.Push(10);
            s.Push(11);
            s.Push(12);
            s.Pop();
            s.Pop();
            s.Pop();
            s.Push(101);
            s.Push(102);
            s.Push(103);
            Assert.AreEqual(103, s.Pop());
            Assert.AreEqual(102, s.Pop());
            Assert.AreEqual(101, s.Pop());
            Assert.AreEqual(9, s.Pop());
        }
    }
}
