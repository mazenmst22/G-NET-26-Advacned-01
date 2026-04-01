using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_Advacned_01.Q2
{
    public class Pair<T, U>
        where T : struct
        where U : class
    {
        private T key;
        private U value;
        public Pair(T key, U value)
        {
            this.key = key;
            this.value = value;
        }
        public T GetKey()
        {
            return key;
        }

        public U GetValue()
        {
            return value;
        }
        public override string ToString()
        {
            return $"Key: {key}, Value: {value}";

        }
    }
}
