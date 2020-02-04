using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Non-adapted
            Meat unknown = new Meat("Beef", 25);
            unknown.LoadData();
            Console.ReadKey();

            //Adapted
            MeatDetails beef = new MeatDetails("Beef", 25);
            beef.LoadData();
            Console.ReadKey();

            MeatDetails turkey = new MeatDetails("Turkey", 25);
            turkey.LoadData();

            MeatDetails chicken = new MeatDetails("Chicken", 25);
            chicken.LoadData();

            Console.ReadKey();
        }
    }
}
