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

            if (alt.Contains(word[0]) && !alt.Contains(word[1]))
            {
                return true;
            }
            else if(!alt.Contains(word[0]) && alt.Contains(word[1]))
            {
                return true;
            }

            return false;
        }
    }
}
