using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGenericClass
{
    public class Guarda3<T>
    {
        private T v1, v2, v3 = default;
        public T GetItem(int i)
        {
            T titem = default;
            switch (i)
            {
                case 0:
                    {
                        titem = v1;
                        break;
                    }
                case 1:
                    {
                        titem = v2;
                        break;
                    }
                case 2:
                    {
                        titem = v3;
                        break;
                    }
                default:
                    {
                        throw new IndexOutOfRangeException();
                    }
            }
            return titem;
        }
        public void SetItem(int i, T item)
        {
            {
                switch (i)
                {
                    case 0:
                        {
                            v1 = item;
                            break;
                        }
                    case 1:
                        {
                            v2 = item;
                            break;
                        }
                    case 2:
                        {
                            v3 = item;
                            break;
                        }
                    default:
                        {
                            throw new IndexOutOfRangeException();
                        }
                }
            }
        }
    }
}