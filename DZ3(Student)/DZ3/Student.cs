using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DZ3
{
    public class Student
    {
        public string FName { get; set; }
        public string SName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Group { get; set; }
        int[] Programming;
        int[] Administration;
        int[] Web;

       public void AppraisalsProgr(int size) {
            Programming = new int[size];
            WriteLine("Введите оценки:\n");
            for (int i = 0; i < size; )
            {
                if (Int32.TryParse(ReadLine(), out Programming[i])) i++;
                else WriteLine(" Ошибка ввода! Повторите ввод данных\n");
            }
        }
        public void AppraisalsWeb(int size)
        {
            Web = new int[size];
            WriteLine("Введите оценки:\n");
            for (int i = 0; i < size;)
            {
                if (Int32.TryParse(ReadLine(), out Web[i])) i++;
                else WriteLine(" Ошибка ввода! Повторите ввод данных\n");
            }
        }

        public void AppraisalsAdminis(int size)
        {
            Administration = new int[size];
            WriteLine("Введите оценки:\n");
            for (int i = 0; i < size;)
            {
                if (Int32.TryParse(ReadLine(), out Administration[i])) i++;
                else WriteLine(" Ошибка ввода! Повторите ввод данных\n");
            }
        }

        public void ShowInfo() {
            WriteLine($" Имя: {FName}\n Отчество: {SName}\n Фамилия: {SName}\n Возраст: {Age}\n Группа: {Group}\n");
            if (Programming != null) {
                Write("Оценки по программированию: ");
                for (int i = 0; i < Programming.Length; i++)Write($"{Programming[i]} ");
            }
            if (Web != null)
            {
                Write("\nОценки по дизайну: ");
                for (int i = 0; i < Web.Length; i++) Write($"{Web[i]} ");
            }
            if (Administration != null)
            {
                Write("\nОценки по администрированию: ");
                for (int i = 0; i < Administration.Length; i++) Write($"{Administration[i]} ");
            }

        }
        public void Sred() {
            int sumPr = 0, sumWeb = 0, sumAdmin = 0;
            if (Web != null && Programming != null && Administration != null)
            {
                for (int i = 0; i < Programming.Length; i++) sumPr += Programming[i];
                WriteLine($"среднее арифметическое оценок по программированию :" + sumPr / Programming.Length);
                for (int i = 0; i < Web.Length; i++) sumWeb += Web[i];
                WriteLine($"\nсреднее арифметическое оценок по дизайну :" + sumWeb / Web.Length);
                for (int i = 0; i < Administration.Length; i++) sumAdmin += Administration[i];
                WriteLine($"\nсреднее арифметическое оценок по адинистрированию :" + sumAdmin / Administration.Length);
            }
            else WriteLine("Ошибка");
        }
    }
}
