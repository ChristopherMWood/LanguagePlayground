using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeEnvironment;

namespace PracticeEnvironmentTests.cs
{
    [TestClass]
    public class StringProblemsTests
    {
        [TestMethod]
        public void GetPermutationsReturnsCorrectListOfPermutations()
        {
            var actualPermutations = StringProblems.GetPermutations("aab");

            Assert.AreEqual(3, actualPermutations.Count());
            Assert.IsTrue(actualPermutations.Contains("aab"));
            Assert.IsTrue(actualPermutations.Contains("aba"));
            Assert.IsTrue(actualPermutations.Contains("baa"));
        }

        [TestMethod]
        public void GetPermutationsReturnsCorrectListOfPermutationsWithAllSeparateCharacters()
        {
            var actualPermutations = StringProblems.GetPermutations("abc");

            Assert.AreEqual(7, actualPermutations.Count());
        }

        [TestMethod]
        public void IsPalindromeReturnsTrueForEvenCharacterPalindrome()
        {
            Assert.IsTrue(StringProblems.IsPalindrome("redder"));
        }

        [TestMethod]
        public void IsPalindromeReturnsTrueForOddCharacterPalindrome()
        {
            Assert.IsTrue(StringProblems.IsPalindrome("racecar"));
        }

        [TestMethod]
        public void IsPalindromeReturnsFalseForInvalidPalindrome()
        {
            Assert.IsFalse(StringProblems.IsPalindrome("Notapalindrome"));
        }

        [TestMethod]
        public void IsPalindromeIgnoresCharacterCase()
        {
            Assert.IsTrue(StringProblems.IsPalindrome("Racecar"));
        }
    }
}
