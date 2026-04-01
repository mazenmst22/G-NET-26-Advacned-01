using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_Advacned_01.Q5
{
    public class Q5
    {
        public static T FindMax<T>(T[] items) where T : IComparable<T>
        {
            if (items.Length == 0)
            {
                throw new Exception("The array is empty!");
            }
            T biggest = items[0];

            for (int i = 1; i < items.Length; i++)
            {
                if (items[i].CompareTo(biggest) > 0)
                {
                    biggest = items[i];
                }
            }
            return biggest;
        }
    }
}
