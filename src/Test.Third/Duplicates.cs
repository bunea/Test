using System;
using System.Collections.Generic;

namespace Test.Third
{
    public class Duplicates
    {
        public Boolean HasDuplicates(int[] arr)
        {
            var hashSet = new HashSet<int>();
            foreach (var num in arr)
            {
                if (!hashSet.Contains(num))
                {
                    hashSet.Add(num);
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
