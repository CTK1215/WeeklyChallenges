using System;
using System.Collections.Generic;
using System.Linq; 

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int current = startNumber + 1;

            while (current % n != 0)
            {
                current++;
            }

            return current;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
          
            if (numbers == null || numbers.Length == 0) return false;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1]) return false;
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2) return 0;

            int sum = 0;
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0) return "";

            var trimmedWords = words
                .Where(w => !string.IsNullOrWhiteSpace(w))
                .Select(w => w.Trim());

            if (!trimmedWords.Any()) return "";

            return string.Join(" ", trimmedWords) + ".";
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null) return new double[0];

            List<double> result = new List<double>();
            for (int i = 3; i < elements.Count; i += 4)
            {
                result.Add(elements[i]);
            }
            return result.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2) return false;

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == targetNumber) return true;
                }
            }
            return false;
        }
    }
}
