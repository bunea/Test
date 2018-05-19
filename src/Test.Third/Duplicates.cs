using System;
using System.Collections.Generic;

namespace Test.Third
{
    public class Duplicates
    {
        public Boolean HasDuplicates(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int index = Math.Abs(arr[i]) - 1;
                if (arr[index] >= 0)
                {
                    arr[index] = -arr[index];
                }
                else
                {
                    return true;
                }
            }

            return false;
        }
    }
}
