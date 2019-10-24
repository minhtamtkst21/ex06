using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Problem2;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTeststack
    {
        [TestMethod]
        public void TestPush()
        {
            stack s = new stack(10);
            s.push(3);
            s.push(5);
            s.push(7);
            Assert.AreEqual(3, s.count());
        }
        [TestMethod]
        public void TestPop()
        {
            stack s = new stack(10);
            s.push(3);
            s.push(5);
            s.push(7);
            Assert.AreEqual(7,s.pop());
            Assert.AreEqual(5, s.pop());
        }
        [TestMethod]
        public void TestPeek()
        {
            stack s = new stack(10);
            s.push(3);
            s.push(5);
            s.push(7);
            Assert.AreEqual(7, s.peek());
            Assert.AreEqual(3,s.count());
        }
        [TestMethod]
        public void TestClear()
        {
            stack s = new stack(10);
            s.push(3);
            s.push(5);
            s.push(7);
            s.clear();
            Assert.AreEqual(0, s.count());
        }
    }
}
