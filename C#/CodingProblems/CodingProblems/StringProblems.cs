using System;
using System.Collections.Generic;

namespace PracticeEnvironment
{
    public class StringProblems
    {
        //Inspiration for problems: https://javarevisited.blogspot.com/2015/01/top-20-string-coding-interview-question-programming-interview.html

        public IEnumerable<string> GetPermutations(string value)
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

        public bool IsPalindrome(string value)
        {
            value = value.ToLower();

            for (int head = 0, tail = value.Length - 1; head < (value.Length/2); head++, tail--)
            {
                if (value[head] != value[tail])
                    return false;
            }

            return true;
        }

        public string LongestCommonSubstring(string value)
        {
            return string.Empty;
        }

        public List<char> FindDuplicateCharactersInString(string value)
        {
            return null;
        }

        public Dictionary<char, int> FindDuplicateCharactersInStringWithCounts(string value)
        {
            //Look at other data structures to use e.g. hashtable
            return null;
        }

        public bool AreAnagramsOfEachother(string stringOne, string stringTwo)
        {
            return false;
        }

        public char FirstNonRepeatingCharacter(string value)
        {
            return '0';
        }

        public string ReverseStringIteratively(string value)
        {
            return string.Empty;
        }

        public string ReverseStringRecursively(string value)
        {
            return string.Empty;
        }

        public bool StringContainsOnlyDigits(string value)
        {
            return false;
        }

        public void GetVowelAndConsonantCountsInString(string value)
        {
            //Determine return type
        }

        public int CharacterCountInString(char character, string value)
        {
            return 0;
        }

        public int GetIntFromString(string value)
        {
            return 0;
        }

        public float GetFloatFromString(string value)
        {
            return 0.0f;
        }

        public string ReplaceOccurencesInString(string baseString, string substringToReplace, string substringToReplaceWith)
        {
            return string.Empty;
        }

        public string ReverseWordsInSentence(string sentence)
        {
            return string.Empty;
        }

        public string RemoveDuplicatesFromString(string value)
        {
            return string.Empty;
        }

        public bool IsValidShuffleOfStrings(string first, string second, string shuffle)
        {
            return false;
        }

        public int IndexOfSubstring(string value, string target)
        {
            return -1;
        }

        public char GetHighestOccuringCharater(string value)
        {
            return '0';
        }

        public string RemoveCharFromStringIteratively(string value, char character)
        {
            return string.Empty;
        }

        public string RemoveCharFromStringRecursively(string value, char character)
        {
            return string.Empty;
        }

        public string FindLongestPalindrome(string value)
        {
            return string.Empty;
        }

        public IEnumerable<string> SortByLength(IEnumerable<string> strings)
        {
            return null;
        }
    }
}
