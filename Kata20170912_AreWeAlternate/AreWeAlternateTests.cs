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

            var evenChars = word.Select((c, i) => i % 2 == 0 ? c : ' ').Where(a => a != ' ');
            var oddChars = word.Select((c, i) => i % 2 == 1 ? c : ' ').Where(a => a != ' ');

            if (alt.Contains(word[0]))
            {
                return evenChars.All(alt.Contains) && oddChars.All(c => !alt.Contains(c)); 
            }
            if(!alt.Contains(word[0]))
            {
                return evenChars.All(c => !alt.Contains(c)) && oddChars.All(c => alt.Contains(c));
            }

            return false;
        }
    }
}
