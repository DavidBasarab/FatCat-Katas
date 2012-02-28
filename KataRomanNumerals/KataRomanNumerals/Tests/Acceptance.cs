using NUnit.Framework;
using Solution;

namespace Tests
{
    [TestFixture]
    public class Acceptance
    {
        [Test]
        [Ignore]
        public void TheNumber1999InRomanNumerals()
        {
            // For Kata http://codingdojo.org/cgi-bin/wiki.pl?KataRomanNumerals

            var value = RomanNumeralConverter.ToRomanNumeral("m cm xc ix");

            Assert.That(value, Is.EqualTo(1999));
        }
    }
}