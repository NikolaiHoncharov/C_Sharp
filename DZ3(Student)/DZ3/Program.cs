using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DZ3
{
    class Program
    {
        static Student std;
        static void Main()
        {
            std = new Student();
            int Enter = 0;

            while (true)
            {
                WriteLine("\t\t**Меню программы**\nВведите:\n1 - для ввода даных о студенте;\n2 - для вывода информации о студенте;\n3 - для вывода среднего арифметического;\n4 - для выхода.\n");
                bool isint = Int32.TryParse(ReadLine(), out Enter);
                if (isint && Enter > 0 || Enter <5)
                { 
                    if (Enter == 1)
                    {
                        //Ввод дынных о студентне и оценках
                        InputInfoStud();
                    }
                    if (Enter == 2)
                    {
                        Clear();
                        WriteLine("\nВывод данных о студенте:\n");
                        std.ShowInfo();
                    }
                    if (Enter == 3)
                    {
                        Clear();
                        std.Sred();
                    }
                    WriteLine("\n");
                    if (Enter == 4)
                    {
                        break;
                    }
                }
                else { Clear(); WriteLine("Ошибка! Неправильный ввод\n"); }
            }
            ReadKey();
        }

        static void InputInfoStud() {
            int temp = 0;
            Write(" Введите имя студента: ");
            std.FName = ReadLine();
            Write(" Введите отчество студента: ");
            std.SName = ReadLine();
            Write(" Введите фамилию студента: ");
            std.LName = ReadLine();
            Write(" Введите возраст студента: ");
            while (temp == 0) temp = Checking(ReadLine());
            std.Age = temp;
            Write(" Введите номер группу: ");
            std.Group = ReadLine();
            temp = 0;
            Write(" Введите кол-во оценок по программированию: ");
            while (temp == 0) temp = Checking(ReadLine());
            std.AppraisalsProgr(temp);
            temp = 0;
            Write(" Введите кол-во оценок по администрированию: ");
            while (temp == 0) temp = Checking(ReadLine());
            std.AppraisalsAdminis(temp);
            temp = 0;
            Write(" Введите кол-во оценок по дизайну: ");
            while (temp == 0) temp = Checking(ReadLine());
            std.AppraisalsWeb(temp);

        }
        static int Checking(string str) {
            int count = 0;
            if (Int32.TryParse(str, out count)==false)
            {
                Write(" Ошибка ввода! Повторите\n");
                return 0;
            }
            else return count;
        }

    }
}
