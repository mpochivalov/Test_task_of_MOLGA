using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_task_of_MOLGA
{
    class Program
    {
        static void Main(string[] args)
        {
            City Denver = new City("Денвер");
            Denver.Lanuch("Ford Denver Corp.");
            Console.WriteLine("В городе {0} работает завод {1}", Denver.NameOfCity, Denver.CarFactory.Name);

            Dealer[] dealer_line = { new Ford("Ford Sellers"), new Lincoln("Lincoln Sellers") };
            foreach (Dealer dealer in dealer_line)
            {
                Car car = dealer.Create();
                Console.WriteLine("Создан {0}", car.Info());
            }

            Console.ReadLine();
        }
    }
    
}
