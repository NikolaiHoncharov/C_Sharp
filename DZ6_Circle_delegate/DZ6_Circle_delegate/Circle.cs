using System;
using static System.Console;

namespace DZ6_Circle_delegate
{
    class Circle
    {
        public void Radius(int d)
        {
            WriteLine($"Радiус = {Convert.ToDouble(d/2)}");  
        }
        public void Diameter(int r)
        {
            WriteLine($"Дiаметр = {2*r}");
        }
        public void Circumference(int r)
        {
           WriteLine($"Довжина = {Convert.ToDouble(2 * Math.PI * r)}");
        }
        public void Area(int r)
        {
            WriteLine($"Площa кола = {Convert.ToDouble(Math.PI * Math.Pow(r, 2))}");
        }

    }
}
