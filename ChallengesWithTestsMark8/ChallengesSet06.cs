using System;
using System.Collections.Generic;
using System.Linq; 

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            if (words == null) return false;

            StringComparison comparison = ignoreCase
                ? StringComparison.OrdinalIgnoreCase
                : StringComparison.Ordinal;

            foreach (string w in words)
            {
                if (w != null && w.Equals(word, comparison)) return true;
            }
            return false;
        }

        public bool IsPrimeNumber(int num)
        {
            if (num < 2) return false;
            if (num == 2) return true;
            if (num % 2 == 0) return false;

            // Only need to check odd divisors up to sqrt(num)
            int limit = (int)Math.Sqrt(num);
            for (int i = 3; i <= limit; i += 2)
            {
                if (num % i == 0) return false;
            }
            return true;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str)) return -1;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                bool isUnique = true;
                for (int j = 0; j < str.Length; j++)
                {
                    if (i != j && str[j] == str[i])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique) return i;
            }
            return -1;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0) return 0;

            int maxRun = 1;
            int currentRun = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentRun++;
                    if (currentRun > maxRun) maxRun = currentRun;
                }
                else
                {
                    currentRun = 1;
                }
            }
            return maxRun;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || n <= 0) return new double[0];

            List<double> result = new List<double>();
            for (int i = n - 1; i < elements.Count; i += n)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }
    }
}
