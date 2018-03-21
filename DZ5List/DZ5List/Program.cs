using System;
using System.Collections.Generic;
using static System.Console;

namespace DZ5List{
    class Program{
        static void Main(string[] args)
        {
            int mode, enter1, count=0;
            string name, manufacturer, model;
            int quantity, price, speed, buf;
            bool flag = true, temp = false;
            List<InformationCarrier> lis = new List<InformationCarrier>();
            WriteLine("\nВведiть 1 - для початку\nВведiть 0 - для виходу з програми");
            do{
                temp = Int32.TryParse(ReadLine(), out mode);
                if (temp == false || (mode < 0 || mode > 1)) WriteLine("Помилка вводу! Повторiть введення даних.");
            } while (temp == false || (mode < 0 || mode > 1));
            if (mode == 1) flag = true;
            else if (mode == 0) flag = false;
            while (flag != false)
            {
                while (mode != 0)
                {
                    Write("\n Можливостi даної програми: \n " + " Введiть: \n 1 - для заповнення даними; \n 2 - для виведення всiх даних;"+
                        "\n 3 - для пошуку носiя iнформацiї за заданим критерiєм;\n 4 - для змiни параметрiв носiя iнформацiї;");
                    Write("\nЗробiть вибiр: ");
                    do{
                        temp = Int32.TryParse(ReadLine(), out enter1);
                        if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                    } while (temp == false);
                    switch (enter1){
                        case 1:{
                                Clear();
                                count++;

                                int vr = 0;
                                WriteLine("Додавання нового iнформацiйного носiя: \n 1- Flash-пам'ять;\n 2- HDD;\n 3- DVD; ");
                                do{
                                    temp = Int32.TryParse(ReadLine(), out vr);
                                    if (temp == false || vr < 1 || vr > 3) WriteLine("Помилка вводу! Повторiть введення даних.");
                                } while (temp == false || vr < 1 || vr > 3); temp = false;
                                WriteLine("Введiть наступнi данi:");
                                Write("Найменування носiя: "); name = ReadLine();
                                Write("Iм'я виробника: "); manufacturer = ReadLine();
                                Write("Модель: "); model = ReadLine();
                                Write("Кiлькiсть: ");
                                do {
                                    temp = Int32.TryParse(ReadLine(), out quantity);
                                    if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                } while (temp == false ); temp = false;
                                Write("Цiна: ");
                                do {
                                    temp = Int32.TryParse(ReadLine(), out price);
                                    if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                } while (temp == false); temp = false;
                                //add Flash-пам'ять
                                if (vr==1)
                                {
                                    Write("Обсяг пам'ятi: ");
                                    do{
                                        temp = Int32.TryParse(ReadLine(), out speed);
                                        if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                    } while (temp == false); temp = false;
                                    Write("Швидкiсть USB: ");
                                    do{
                                        temp = Int32.TryParse(ReadLine(), out buf);
                                        if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                    } while (temp == false); temp = false;
                                    lis.Add(new Flash(name, manufacturer, model, quantity, price, speed, buf));
                                }
                                //add HDD
                                if (vr==2)
                                {
                                    Write("Розмiр диска: ");
                                    do{
                                        temp = Int32.TryParse(ReadLine(), out speed);
                                        if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                    } while (temp == false); temp = false;
                                    Write("Швидкiсть USB: ");
                                    do{
                                        temp = Int32.TryParse(ReadLine(), out buf);
                                        if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                    } while (temp == false); temp = false;
                                    lis.Add(new HDD(name, manufacturer, model, quantity, price, speed, buf));
                                }
                                //Add DVD
                                if (vr==3)
                                {
                                    Write("Швидкiсть читання: ");
                                    do{
                                        temp = Int32.TryParse(ReadLine(), out speed);
                                        if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                    } while (temp == false); temp = false;
                                    Write("Швидкiсть запису: ");
                                    do{
                                        temp = Int32.TryParse(ReadLine(), out buf);
                                        if (temp == false) WriteLine("Помилка вводу! Повторiть введення даних.");
                                    } while (temp == false); temp = false;
                                    lis.Add(new DVD(name, manufacturer, model, quantity, price, speed, buf));
                                }
                            }
                            break;
                        case 2:
                            {
                                Clear();
                                if (count != 0){for (int i = 0; i < count; i++) lis[i].Print();}
                                else WriteLine("Вибачте даних для виведення немає.");
                            }
                            break;
                        case 3:
                            {
                                Clear();
                                if (count != 0)
                                {
                                    Write("Введiть параметр для пошуку: ");
                                    string str = ReadLine();
                                    for (int i = 0; i < count; i++)lis[i].Search(str);  
                                }
                                else WriteLine("Вибачте даних для виведення немає.");
                            }
                            break;
                        case 4:
                            {
                                Clear();
                                if (count != 0)
                                {
                                    Write("Введiть параметр для пошуку: ");
                                    string str = ReadLine();
                                    Write("Введiть на що змiнити: ");
                                    string change = ReadLine();
                                    for (int i = 0; i < count; i++) lis[i].Change(str, change);
                                }
                                else WriteLine("Вибачте даних для виведення немає.");

                            } break;
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
