using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringExtensions.Tests
{
    [TestClass]
    public class StringExtensionsTests
    {
        [TestMethod]
        public void HasAllUniqueChars()
        {
            var input = "qwertyuioasdfghjklzxcvbn";
            Assert.IsTrue(input.HasAllUniqueChars());
        }

        [TestMethod]
        public void DoesNotHaveAllUniqueChars()
        {
            var input = "aaasssdddfffggghhh";
            Assert.IsFalse(input.HasAllUniqueChars());
        }

        [TestMethod]
        public void IsStringInReverseOrderEven()
        {
            var input = "0123456789";
            Assert.AreEqual("9876543210", input.Reverse());
        }

        [TestMethod]
        public void IsStringInReverseOrderOdd()
        {
            var input = "123456789";
            Assert.AreEqual("987654321", input.Reverse());
        }

        [TestMethod]
        public void IsStringInReverseOrderChars()
        {
            var input = "abcdefghijklmnop";
            Assert.AreEqual("ponmlkjihgfedcba", input.Reverse());
        }

        [TestMethod]
        public void AreSpacesReplacedWithPercent20()
        {
            var input = "1 3  6  9";
            var output = input.ReplaceSpace20();
            Assert.AreEqual("1%203%20%206%20%209",  output);
        }

        [TestMethod]
        public void StringIsCompressed()
        {
            var input = "aabcccccaaa";
            var output = input.Compress();
            Assert.AreEqual("a2b1c5a3",  output);
        }

        [TestMethod]
        public void StringIsCompressed2()
        {
            var input = "aabcccccaaab";
            var output = input.Compress();
            Assert.AreEqual("a2b1c5a3b1",  output);
        }

        [TestMethod]
        public void CanNotCompressString()
        {
            var input = "abcabcabcabc";
            var output = input.Compress();
            Assert.AreEqual("abcabcabcabc",  output);
        }
    }
}
