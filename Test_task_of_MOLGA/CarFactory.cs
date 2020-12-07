using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_of_MOLGA
{
    //Реализация паттерна Singleton.
    //В городе можно иметь только один завод по производству машин
    //Class  CarFactory является реализацией паттерна, проверяется наличие завода в городе
    //и осуществляется проверка на единственность экземпляра
    class City
    {
        public string NameOfCity { get; }
        public City(string city)
        {
            this.NameOfCity = city;
        }
        public CarFactory CarFactory { get; set; }
        public void Lanuch(string factoryName)
        {
            CarFactory = CarFactory.getFactory(factoryName);
        }
    }
    class CarFactory
    {
        private static CarFactory factory;

        public string Name { get; private set; }

        protected CarFactory(string name)
        {
            this.Name = name;
        }

        public static CarFactory getFactory(string name)
        {
            if (factory == null)
                factory = new CarFactory(name);
            return factory;
        }
    }
}
