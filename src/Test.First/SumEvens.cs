using System;

namespace Test.First
{
    public class SumEvens
    {
        public int Sum(int[] arr)
        {
            var sum = 0;
            foreach (var number in arr)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            return sum;
        }
    }
}
