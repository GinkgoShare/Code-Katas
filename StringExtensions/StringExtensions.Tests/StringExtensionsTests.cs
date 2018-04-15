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
            var input = "1 3  6  9               ";
            Assert.AreEqual("1%203%20%206%20%209", input.ReplaceSpace20());
        }
    }
}
