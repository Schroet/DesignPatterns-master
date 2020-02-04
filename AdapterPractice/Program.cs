using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Structural Pattern

            Car car = new Car("BWM");
            var res = car.Drive(50);

            Console.WriteLine($"Max speed is {res}");

            CarAdapter adapter = new CarAdapter("Audi", "A6");

            var dist = adapter.GetDistance(25, 10);


            Console.WriteLine($"The distance is {dist}");

            Console.ReadKey();


        }
    }
}
