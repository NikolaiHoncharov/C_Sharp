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
        static int count = 89;

        private Point()
        {
            Name = Convert.ToChar(count);
            count++;      
        }
       public static Point CreatePoint() {
            if (count <= 90)
            {
                return new Point();            
            }
            else {
                Console.WriteLine("Ошибка! Создание невозможно");
                Point p = null;
                return p; }
                //return new Point();

           
        }
    }
}
