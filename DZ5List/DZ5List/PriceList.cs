using System;
using static System.Console;

namespace DZ5List
{
   public abstract class InformationCarrier
    { 
        public string name { get; set; }
        public string manufacturer{ get; set; }
        public string model { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public InformationCarrier(string name, string manufacturer, string model, int quantity, int price) {
            this.name = name;
            this.manufacturer = manufacturer;
            this.model = model;
            this.quantity = quantity;
            this.price = price;
        }
        public abstract void Print();
        public abstract void Save();
        public abstract void Download();
        public abstract void Search(string str);
        public abstract void Change(string str, string change);

    }
    public class Flash : InformationCarrier
    {
        
        public int amount { get; set; }
        public int speed { get; set; }
        public Flash(string name, string manufacturer, string model, int quantity, int price, int amount, int speed) :base( name, manufacturer, model, quantity, price) {
            this.amount = amount;
            this.speed = speed;
        }
        public override void Download()
        {
            Write("Завантаження з файла\n");
        }

        public override void Print()
        {
            WriteLine("\nНайменування носiя: " + name + " Iм'я виробника: " +  manufacturer + 
                " Модель: " + model + " Кiлькiсть: " + quantity + "\nЦiна: " + price + " Обсяг пам'ятi: " + amount + " Швидкiсть USB: " + speed + "\n");
        }

        public override void Save()
        {
            Write("Збереження в файл\n");
        }
        public override void Search(string str) {
            int temp = 0;
            Int32.TryParse(str, out temp);
            if((name==str) || (manufacturer == str) || (model == str) || (quantity == temp) || (price == temp) || (amount == temp) ||(speed==temp))
            {
                Print();
            }
        }

        public override void Change(string str, string change)
        {
            int temp = 0, chan = 0; ;
            Int32.TryParse(str, out temp);
            Int32.TryParse(str, out chan);
            if(name == str) name = str;
            if (manufacturer == str) manufacturer = str;
            if (model == str) model = str;
            if (quantity == temp) quantity = chan;
            if (price == temp) price = chan;
            if (amount == temp) amount = chan;
            if (speed == temp) speed = chan;
            Print();
            
        }
    }

    public class HDD : InformationCarrier
    {

        public int diskSize { get; set; }
        public int speed { get; set; }

        public HDD(string name, string manufacturer, string model, int quantity, int price, int diskSize, int speed) :base( name, manufacturer, model, quantity, price) {
            this.diskSize = diskSize;
            this.speed = speed;
        }

        public override void Download()
        {
            Write("Завантаження з файла\n");
        }

        public override void Print()
        {
            WriteLine("\nНайменування носiя: " + name + " Iм'я виробника: " + manufacturer +
                " Модель: " + model + " Кiлькiсть: " + quantity + "\nЦiна: " + price + " Розмiр диска: " + diskSize + " Швидкiсть USB: " + speed + "\n");
        }

        public override void Save()
        {
            Write("Збереження в файл\n");
        }
        public override void Search(string str)
        {
            int temp = 0;
            Int32.TryParse(str, out temp);
            if ((name == str) || (manufacturer == str) || (model == str) || (quantity == temp) || (price == temp) || (diskSize == temp) || (speed == temp))
            {
                Print();
            }
        }

        public override void Change(string str, string change)
        {
            int temp = 0, chan = 0; ;
            Int32.TryParse(str, out temp);
            Int32.TryParse(str, out chan);
            if (name == str) name = str;
            if (manufacturer == str) manufacturer = str;
            if (model == str) model = str;
            if (quantity == temp) quantity = chan;
            if (price == temp) price = chan;
            if (diskSize == temp) diskSize = chan;
            if (speed == temp) speed = chan;
        }
    }

    public class DVD : InformationCarrier
    {
        public int ReadingSpeed { get; set; }
        public int RecordSpeed { get; set; }

        public DVD(string name, string manufacturer, string model, int quantity, int price, int ReadingSpeed, int RecordSpeed) :base( name, manufacturer, model, quantity, price) {
            this.ReadingSpeed = ReadingSpeed;
            this.RecordSpeed = RecordSpeed;
        }
        public override void Download()
        {
            Write("Завантаження з файла\n");
        }

        public override void Print()
        {
            WriteLine("\nНайменування носiя: " + name + " Iм'я виробника: " + manufacturer +
                " Модель: " + model + " Кiлькiсть: " + quantity + "\nЦiна: " + price + " Швидкiсть читання: " + ReadingSpeed + " Швидкiсть запису: " + RecordSpeed + "\n");
        }

        public override void Save()
        {
            Write("Збереження в файл\n");
        }
        public override void Search(string str)
        {
            int temp = 0;
            Int32.TryParse(str, out temp);
            if ((name == str) || (manufacturer == str) || (model == str) || (quantity == temp) || (price == temp) || (ReadingSpeed == temp) || (RecordSpeed == temp))
            {
                Print();
            }
        }
        public override void Change(string str, string change)
        {
            int temp = 0, chan = 0; ;
            Int32.TryParse(str, out temp);
            Int32.TryParse(str, out chan);
            if (name == str) name = str;
            if (manufacturer == str) manufacturer = str;
            if (model == str) model = str;
            if (quantity == temp) quantity = chan;
            if (price == temp) price = chan;
            if (ReadingSpeed == temp) ReadingSpeed = chan;
            if (RecordSpeed == temp) RecordSpeed = chan;
        }
    }
}
