using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_of_MOLGA
{
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
