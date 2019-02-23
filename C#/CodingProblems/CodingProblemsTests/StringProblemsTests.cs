using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeEnvironment;

namespace CodingProblemsTests
{
    [TestClass]
    public class StringProblemsTests
    {
        private StringProblems stringProblems;

        [TestInitialize]
        public void Initialize()
        {
            stringProblems = new StringProblems();
        }

        [TestMethod]
        public void GetPermutationsReturnsCorrectListOfPermutations()
        {
            var actualPermutations = stringProblems.GetPermutations("aab");

            Assert.AreEqual(3, actualPermutations.Count());
            Assert.IsTrue(actualPermutations.Contains("aab"));
            Assert.IsTrue(actualPermutations.Contains("aba"));
            Assert.IsTrue(actualPermutations.Contains("baa"));
        }

        [TestMethod]
        public void GetPermutationsReturnsCorrectListOfPermutationsWithAllSeparateCharacters()
        {
            var actualPermutations = stringProblems.GetPermutations("abc");

            Assert.AreEqual(7, actualPermutations.Count());
        }

        [TestMethod]
        public void IsPalindromeReturnsTrueForEvenCharacterPalindrome()
        {
            Assert.IsTrue(stringProblems.IsPalindrome("redder"));
        }

        [TestMethod]
        public void IsPalindromeReturnsTrueForOddCharacterPalindrome()
        {
            Assert.IsTrue(stringProblems.IsPalindrome("racecar"));
        }

        [TestMethod]
        public void IsPalindromeReturnsFalseForInvalidPalindrome()
        {
            Assert.IsFalse(stringProblems.IsPalindrome("Notapalindrome"));
        }

        [TestMethod]
        public void IsPalindromeIgnoresCharacterCase()
        {
            Assert.IsTrue(stringProblems.IsPalindrome("Racecar"));
        }
    }
}
