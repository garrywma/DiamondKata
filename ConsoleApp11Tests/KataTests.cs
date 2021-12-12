using ConsoleApp11;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ConsoleApp11.Tests
{
    [TestFixture()]
    public class KataTests
    {
        private Kata kata;

        public KataTests()
        {
            kata = new Kata();
        }

        [TestCase(0, ExpectedResult = 'A')]
        [TestCase(3, ExpectedResult = 'D')]
        [TestCase(5, ExpectedResult = 'F')]
        public char GetCharAtLevelTest(int level)
        {
            kata.Level = level;
            return kata.GetCharAtCurrentLevel();
        }

        [TestCase('A', ExpectedResult = "")]
        [TestCase('C', ExpectedResult = "C")]
        [TestCase('G', ExpectedResult = "G")]
        public string GetEndStringForCurrentCharTest(char currentChar)
        {
            return kata.GetEndStringForCurrentChar(currentChar);
        }

        [TestCase(0, ExpectedResult = "")]
        [TestCase(3, ExpectedResult = "     ")]
        [TestCase(5, ExpectedResult = "         ")]
        public string GetGapAtLevelTest(int level)
        {
            kata.Level = level;
            return kata.GetGapAtCurrentLevel();
        }

        [TestCase(0, 'D', ExpectedResult = "   ")]
        [TestCase(3, 'D', ExpectedResult = "")]
        public string GetPaddingAtLevelTest(int level, char endChar)
        {
            kata.Level = level;
            return kata.GetPaddingAtCurrentLevel(endChar);
        }

        [TestCase(0, 'C', ExpectedResult = "  A")]
        [TestCase(1, 'C', ExpectedResult = " B B")]
        [TestCase(2, 'C', ExpectedResult = "C   C")]
        public string GetKataLevelTest(int level, char endChar)
        {
            kata.Level = level;
            return kata.GetKataLevel('C');
        }

        [Test()]
        public void GetKataTest()
        {
            List<string> expected = new List<string>()
            {
                "   A",
                "  B B",
                " C   C",
                "D     D",
                " C   C",
                "  B B",
                "   A",

            };
            Assert.AreEqual(expected, kata.GetKata('D'));
        }

        [Test()]
        public void CallGetKataTwiceTest()
        {
            Assert.AreEqual(kata.GetKata('D'), kata.GetKata('D'));
        }
    }
}