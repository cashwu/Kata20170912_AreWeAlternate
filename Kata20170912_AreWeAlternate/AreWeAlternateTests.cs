using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170912_AreWeAlternate
{
    [TestClass]
    public class AreWeAlternateTests
    {
        [TestMethod]
        public void input_bcd_should_return_false()
        {
            IsAltShouldBeFalse("bcd");
        }

        private static void IsAltShouldBeFalse(string word)
        {
            var kata = new Kata();
            var actual = kata.IsAlt(word);
            Assert.IsFalse(actual);
        }
    }

    public class Kata
    {
        public bool IsAlt(string word)
        {
            return false;
        }
    }
}
