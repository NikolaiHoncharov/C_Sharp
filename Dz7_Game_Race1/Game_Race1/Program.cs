using System;
using static System.Console;

namespace Game_Race1
{
    class Program
    {
        static void Main(string[] args)
        {
            Game win = new Game();
            string name1, name2;
            int kol = 0, kol2 = 0;
            WriteLine("Введите имя 1 гонщика: ");
            name1 = ReadLine();
            SportsCar one = new SportsCar(name1);
            WriteLine("Введите имя 2 гонщика: ");
            name2 = ReadLine();
            PassengerCar two = new PassengerCar(name2);

            int mode, enter1;
            bool flag = true, temp = false;
            WriteLine("\nВведите 1 - для начала\nВведите 0 - для выхода программы");


            do
            {
                temp = Int32.TryParse(ReadLine(), out mode);
                if (temp == false || (mode < 0 || mode > 1)) WriteLine("Ошибка вводв данных! Повторите ввод.");
            } while (temp == false || (mode < 0 || mode > 1));

            if (mode == 1) flag = true;
            else if (mode == 0) flag = false;
            while (flag != false)
            {
                while (mode != 0)
                {
                    Write("\n Возможности данной прогаммы:\n" + " Введите: \n 1 - для начала гонки; \n 2 - для вывода победителя;");
                    Write("\nСделайте выбор: "); enter1 = Convert.ToInt32(ReadLine());
                    switch (enter1)
                    {
                        case 1:
                            {
                                Clear();
                                Start d1 = one.go;
                                kol = d1();
                                Start d2 = two.go;
                                kol2 = d2();
                            }
                            break;
                        case 2:
                            {
                                Clear();
                                if (kol > kol2)
                                {
                                    win.Finish += two.finish;
                                    ExamEventArgs eventArgs = new ExamEventArgs { Task = Convert.ToString(kol2) };
                                    win.finish(eventArgs);
                                }
                                else
                                {
                                    win.Finish += one.finish;
                                    ExamEventArgs eventArgs = new ExamEventArgs { Task = Convert.ToString(kol) };
                                    win.finish(eventArgs);
                                }
                            }
                            break;
                        default: Write("\nВы сделали некорректный выбор\n"); break;
                    }
                    Write("\nВведите 1 - для продолжения\nВведите 0 - чтобы выйти\n");

                    do
                    {
                        temp = Int32.TryParse(ReadLine(), out mode);
                        if (temp == false || (mode < 0 || mode > 1)) WriteLine("Ошибка вводв данных! Повторите ввод.");
                    } while (temp == false || (mode < 0 || mode > 1));

                    if (mode == 1) flag = true;
                    else if (mode == 0) flag = false;

                }
            }
        }
    }
}
