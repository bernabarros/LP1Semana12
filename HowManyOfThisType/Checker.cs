using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowManyOfThisType
{
    public static class Checker
    {
        public static int HowManyOfType<T>(IEnumerable<object> items)
        {
            int item_num = 0;
            foreach (object item in items)
            {
                if (item is T)
                {
                    item_num++;
                }
            }
            return item_num;
        }
    }
}