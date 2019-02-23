using System;
using System.Collections.Generic;

namespace PracticeEnvironment
{
    public static class StringProblems
    {
        //Currently does not work. Needs to work recursively since this only cover one set of the permutations
        public static IEnumerable<string> GetPermutations(string value)
        {
            var stringPermutations = new List<string>();

            for (var i = 0; i < value.Length; i++)
            {
                var rootCharacter = Convert.ToString(value[i]);

                for (var j = 0; j < value.Length; j++)
                {
                    var swappingCharacter = Convert.ToString(value[j]);
                    var permutation = value;
                    permutation = permutation.Remove(i, 1);
                    permutation = permutation.Insert(i, swappingCharacter);
                    permutation = permutation.Remove(j, 1);
                    permutation = permutation.Insert(j, rootCharacter);

                    if (!stringPermutations.Contains(permutation))
                        stringPermutations.Add(permutation);
                }
            }

            return stringPermutations;
        }

        public static bool IsPalindrome(string value)
        {
            value = value.ToLower();

            for (int head = 0, tail = value.Length - 1; head < (value.Length/2); head++, tail--)
            {
                if (value[head] != value[tail])
                    return false;
            }

            return true;
        }
    }
}
