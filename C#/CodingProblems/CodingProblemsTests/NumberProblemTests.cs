using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PracticeEnvironment;

namespace CodingProblemsTests
{
    [TestClass]
    public class NumberProblemTests
    {
        [TestMethod]
        public void FindMissingConsecutiveNumbersReturnsEmptyListWhenPassedEmptyList()
        {
            var missingNumbers = NumberProblems.FindMissingConsecutiveNumbers(new List<int>());

            Assert.AreEqual(0, missingNumbers.Count);
        }

        [TestMethod]
        public void FindMissingConsecutiveNumbersCorrectlyFindsSingleMissingValue()
        {
            var numbers = new List<int> { 1, 2, 3, 4, 6, 7, 8 };

            var missingNumbers = NumberProblems.FindMissingConsecutiveNumbers(numbers);

            Assert.AreEqual(1, missingNumbers.Count);
            Assert.AreEqual(5, missingNumbers.First());
        }

        [TestMethod]
        public void FindMissingConsecutiveNumbersCorrectlyFindsMultipleMissingValue()
        {
            var numbers = new List<int> { 1, 3, 4, 6, 7, 8 };

            var missingNumbers = NumberProblems.FindMissingConsecutiveNumbers(numbers);

            Assert.AreEqual(2, missingNumbers.Count);
            Assert.AreEqual(2, missingNumbers[0]);
            Assert.AreEqual(5, missingNumbers[1]);
        }

        [TestMethod]
        public void FindMissingConsecutiveNumbersReturnsEmptyListWhenPassedValidConsecutiveNumbers()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };

            var missingNumbers = NumberProblems.FindMissingConsecutiveNumbers(numbers);

            Assert.AreEqual(0, missingNumbers.Count);
        }
    }
}