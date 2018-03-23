using System;
using static System.Console;

namespace DZ6_Circle_delegate
{
    class Program
    {
        delegate void Operation(int x);
        static void Main()
        {
            Circle cr = new Circle();
            Operation op = new Operation(cr.Radius);
            
            int mode, enter1, buff=0;
            bool flag = true, temp = false;
            WriteLine("\nВведiть 1 - для початку\nВведiть 0 - для виходу з програми");
            do
            {
                temp = Int32.TryParse(ReadLine(), out mode);
                if (temp == false || (mode < 0 || mode > 1)) WriteLine("Помилка вводу! Повторiть введення даних.");
            } while (temp == false || (mode < 0 || mode > 1));
            if (mode == 1) flag = true;
            else if (mode == 0) flag = false;
            while (flag != false)
            {
                while (mode != 0)
                {
                    Write("\n Можливостi даної програми: \n " + " Введiть: \n 1 - для знаходження  радiуса; \n 2 - для знаходження  дiаметра;" +
                        "\n 3 - для знаходження довжини окружностi;\n 4 - для знаходження площi кола;");
                    Write("\nЗробiть вибiр: ");
                    do{
                        temp = Int32.TryParse(ReadLine(), out enter1);
                        if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                    } while (temp == false);
                    switch (enter1)
                    {
                        case 1:
                            {
                                Clear();
                                Write("Введiть дiаметр кола: ");
                                do
                                {
                                    temp = Int32.TryParse(ReadLine(), out buff);
                                    if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                } while (temp == false);
                                
                                op = cr.Radius;
                                op.Invoke(buff);
                            }
                            break;
                        case 2:
                            {
                                Clear();

                                Write("Введiть радiус кола: ");
                                do
                                {
                                    temp = Int32.TryParse(ReadLine(), out buff);
                                    if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                } while (temp == false);


                                op = cr.Diameter;
                                op.Invoke(buff);
                            }
                            break;
                        case 3:
                            {
                                Clear();
                                Write("Введiть радiус кола: ");
                                do
                                {
                                    temp = Int32.TryParse(ReadLine(), out buff);
                                    if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                } while (temp == false);
                                op = cr.Circumference;
                                op.Invoke(buff);
                            }
                            break;
                        case 4:
                            {
                                Clear();
                                Write("Введiть радiус кола: ");
                                do
                                {
                                    temp = Int32.TryParse(ReadLine(), out buff);
                                    if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                } while (temp == false);
                                op = cr.Area;
                                op.Invoke(buff);
                            }
                            break;
                        default: Write("\nВи зробили неправильний вибiр\n"); break;
                    }
                    Write("\nВведiть 1 - для початку\nВведiть 0 - для виходу з програми\n");
                    do
                    {
                        temp = Int32.TryParse(ReadLine(), out mode);
                        if (temp == false || (mode < 0 || mode > 1)) WriteLine("Помилка вводу! Повторiть введення даних.");
                    } while (temp == false || (mode < 0 || mode > 1));
                    if (mode == 1) flag = true;
                    else if (mode == 0) flag = false;
                }
            }
        }
    }
}
