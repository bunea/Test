using System;
using System.Linq;

namespace Test.First
{
    public class SumEvens
    {
        public int Sum(int[] arr)
        {
            return arr.Where(IsEven).Sum();
        }

        private Boolean IsEven(int num)
        {
            return num % 2 == 0;
        }
    }
}
