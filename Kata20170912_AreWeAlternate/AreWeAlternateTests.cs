using System;
using System.Linq;
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

        [TestMethod]
        public void input_ab_should_return_true()
        {
            IsAltShouldBeTrue("ab");
        }

        [TestMethod]
        public void input_ba_should_return_true()
        {
            IsAltShouldBeTrue("ba");
        }

        [TestMethod]
        public void input_abb_should_return_false()
        {
            IsAltShouldBeFalse("abb");
        }

        [TestMethod]
        public void input_baa_should_return_false()
        {
            IsAltShouldBeFalse("baa");
        }

        [TestMethod]
        public void input_amazon_should_return_true()
        {
            IsAltShouldBeTrue("amazon");
        }

        [TestMethod]
        public void input_banana_should_return_true()
        {
            IsAltShouldBeTrue("banana");
        }

        [TestMethod]
        public void input_apple_should_return_false()
        {
            IsAltShouldBeFalse("apple");
        }

        private static void IsAltShouldBeTrue(string word)
        {
            var kata = new Kata();
            var actual = kata.IsAlt(word);
            Assert.IsTrue(actual);
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
            var alt = new [] {'a', 'e', 'i', 'o', 'u'};

            for (int i = 1; i < word.Length; i++)
            {
                if (alt.Contains(word[i]) == alt.Contains(word[i - 1]))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
