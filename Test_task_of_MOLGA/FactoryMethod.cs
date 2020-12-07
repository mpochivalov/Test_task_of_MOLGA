using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_of_MOLGA
{
    // абстрактный класс автомобильной компании
    abstract class Dealer
    {
        public string Name { get; set; }

        public Dealer(string name)
        {
            Name = name;
        }
        // фабричный метод
        abstract public Car Create();
    }
    // Выпускает Navigator
    class Ford : Dealer
    {
        public Ford(string name) : base(name)
        { }

        public override Car Create()
        {
            return new Mustang();
        }
    }
    // Выпускает Navigator
    class Lincoln : Dealer
    {
        public Lincoln(string name) : base(name)
        { }

        public override Car Create()
        {
            return new Navigator();
        }
    }

    abstract class Car
    {
        //метод, у которого есть своя реализация в сабклассе
        public abstract string Info();
    }

    class Mustang : Car
    {
        //реализация метода, определенного в суперклассе
        public override string Info() { return "Это Mustang"; }
    }
    class Navigator : Car
    {
        //реализация метода, определенного в суперклассе
        public override string Info() { return "Это Lincoln"; }
    }
}
