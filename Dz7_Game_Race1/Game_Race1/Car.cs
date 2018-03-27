using System;
using static System.Console;

namespace Game_Race1
{
    public delegate int Start();

    abstract class Car
    {
        protected int speed;
        protected string name;
        protected int round;

        public Car()
        {
            this.name = "John";
            round = 0;
        }
        public abstract void finish(object sender, ExamEventArgs e);
        public abstract int go();
    }
    class SportsCar : Car
    {
        Random random1;
        //     public event EventHandler Finish;
        public SportsCar(string name)
        {
            this.name = name;
            round = 0;
        }
        public SportsCar() : base() { }
        public override int go()
        {
            int round = 0;
            random1 = new Random();
            speed += random1.Next(3, 12);
            while (this.speed <= 100)
            {

                speed += random1.Next(3, 18);
                if (speed < 100)
                    Write($"Игрок  {name}  преодолел {speed}% всей гонки за {round + 1} круг\n");
                else Write($"Игрок  {name}  преодолел 100% всей гонки за {round + 1} круг\n");
                round++;
            }
            return round;
            //throw new NotImplementedException();
        }
        public override void finish(object sender, ExamEventArgs e)
        {
            WriteLine($"\nПОБЕДА!\n {name} прошел 100% с кол-вом кургов {e.Task} ");
        }
    }

    class PassengerCar : Car
    {
        //  public event EventHandler Finish;
        Random random;
        public PassengerCar(string name)
        {
            this.name = name;
            round = 0;
        }
        public PassengerCar() : base() { }
        public override int go()
        {
            int round = 0;
            random = new Random();
            speed += random.Next(1, 11);
            while (this.speed <= 100)
            {

                speed += random.Next(1, 17);
                if (speed < 100)
                    Write($"Игрок {name} преодолел {speed}% всей гонки за {round + 1} круг\n");
                else Write($"Игрок  {name}  преодолел 100% всей гонки за {round + 1} круг\n");
                round++;
            }
            return round;
            //throw new NotImplementedException();
        }
        public override void finish(object sender, ExamEventArgs e)
        {
            WriteLine($"\nПОБЕДА!\n {name} прошел 100% с кол-вом кургов {e.Task}");
        }
    }
    class ExamEventArgs : EventArgs
    {
        public string Task { get; set; }
    }
    class Game
    {
        public EventHandler<ExamEventArgs> Finish;
        public void finish(ExamEventArgs task)
        {
            if (Finish != null)
                Finish(this, task);
        }
    }
}
