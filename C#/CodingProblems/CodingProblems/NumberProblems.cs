using System.Collections.Generic;

namespace PracticeEnvironment
{
    public static class NumberProblems
    {
        public static List<int> FindMissingConsecutiveNumbers(List<int> numbers)
        {
            var missingNumbers = new List<int>();

            for (var i = 0; i < numbers.Count - 1; i++)
            {
                if (numbers[i] != (numbers[i + 1] - 1))
                    missingNumbers.Add(numbers[i] + 1);
            }

            return missingNumbers;
        }
    }
}
