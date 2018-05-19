using System;

namespace Test.Second
{
    public class LargestTwo
    {
        public int[] Largest(int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("Array should have at least 2 elements");
            }

            var first = int.MinValue;
            var second = int.MinValue;
            foreach (var num in arr)
            {
                if (first < num)
                {
                    second = first;
                    first = num;
                }
                else if (second < num)
                {
                    second = num;
                }
            }

            return new int[] { first, second };
        }
    }
}
