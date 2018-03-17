using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace Dz5_point
{
    class Program
    {

        static void Main()
        {
            Title = "Point";
            int mode, enter1, count = 0, buff=0, buff1=0;
            bool flag = true, temp= false, temp1 = false;
            List<Point> points = new List<Point>();
            WriteLine("\nВведите 1 - для начала\nВведите 0 - для выхода программы");
            do
            {
                temp = Int32.TryParse(ReadLine(), out mode);
                if (temp == false || (mode < 0 || mode > 1)) WriteLine("Ошибка ввода! Пвоторите ввод данных.");
            } while (temp == false || (mode < 0 || mode > 1));
            if (mode == 1) flag = true;
            else if (mode == 0) flag = false;
            while (flag != false){
                while (mode != 0){
                    Write("\n Возможности данной прогаммы:\n" + " Введите: \n 1 - для Заполнения данными; \n 2 - для вывода всех данных;");
                    Write("\nСделайте выбор: ");
                    do{
                        temp = Int32.TryParse(ReadLine(), out enter1);
                        if (temp == false ) WriteLine("Ошибка ввода! Пвоторите ввод данных.");
                    } while (temp == false);
                    switch (enter1)
                    {
                        case 1:{
                                Clear();
                                count++;
                                if (count <= 26){
                                    points.Add(new Point());
                                    WriteLine("Введите координаты:");
                                    do
                                    {
                                        temp = Int32.TryParse(ReadLine(), out buff);
                                        temp1 = Int32.TryParse(ReadLine(), out buff1);
                                        if (temp == false || temp1 == false) WriteLine("Ошибка ввода! Пвоторите ввод данных.");
                                    } while (temp == false || temp1 == false);
                                    points[count - 1].X = buff;
                                    points[count - 1].Y = buff1;
                                }
                                else { WriteLine("Ошибка!Перевышен лимит объектов\n"); }
                            }break;
                        case 2:{
                                Clear();
                                for (int i = 0; i < points.Count; i++)
                                    WriteLine($" Name = {points[i].Name}: X = {points[i].X} Y = {points[i].Y}");
                            } break;
                        default: Write("\nВы сделали некорректный выбор\n"); break;
                    }
                    Write("\nВведите 1 - для продолжения\nВведите 0 - чтобы выйти\n");
                    do{
                        temp = Int32.TryParse(ReadLine(), out mode);
                        if (temp == false || (mode < 0 || mode > 1)) WriteLine("Ошибка ввода! Пвоторите ввод данных.");
                    } while (temp == false || (mode < 0 || mode > 1));
                    if (mode == 1) flag = true;
                    else if (mode == 0) flag = false;    
                }
            }
        }
    }
}
