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
                if (IsEven(number))
                {
                    sum += number;
                }
            }

            return sum;
        }

        private Boolean IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
