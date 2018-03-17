using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz5_point
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public char Name { get; private set; }
        static int count = 65;
        public Point()
        {
            Name = Convert.ToChar(count);
            count++;      
        }
    }
}
