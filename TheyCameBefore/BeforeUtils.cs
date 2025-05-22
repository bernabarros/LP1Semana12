using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheyCameBefore
{
    public static class BeforeUtils
    {
        public static IEnumerable<T> GetTheOnesBefore<T>(IEnumerable<T> nums, T other_num) where T : IComparable<T>
        {
            foreach (T num in nums)
            {
                if (num.CompareTo(other_num) < 0)
                {
                    yield return num;
                }
            }
        }
    }
}