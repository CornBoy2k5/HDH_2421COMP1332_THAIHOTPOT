using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HDH_2c
{
    public static class Extensions
    {
        public static Queue<T> SetFirstTo<T>(this Queue<T> q, T value)
        {
            T[] array = q.ToArray();
            array[0] = value;
            return new Queue<T>(array);
        }
    }
}
