using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_Advacned_01
{
    public class Container<T>
    {
        private T val;
        public void Add(T val)
        {
                       this.val = val;
        }
        public T Get()
        {
            return val;
        }
    }
}
