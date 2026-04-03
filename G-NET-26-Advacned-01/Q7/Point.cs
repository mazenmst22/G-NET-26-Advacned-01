using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_26_Advacned_01.Q7
{
    public class Point<T> where T : struct
     {
         public T X { get; set; }
         public T Y { get; set; }
        public T Z { get; set; }
       
        public Point(T x, T y, T z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        public void DisplayCoordinates()
        {
            Console.WriteLine($"Point coordinates: ({X}, {Y}, {Z})");
        }
    }
}
