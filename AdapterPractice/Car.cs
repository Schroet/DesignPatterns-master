using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPractice
{
   public class Car
    {
        public Car(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }


        public virtual int Drive(int speed)
        {
            return speed * 2;
        }
    }


    public class CarAdapter : Car
    {
        public string Model { get; set; }

        public CarAdapter(string name, string model) : base(name)
        {
            this.Model = model;
        }

        public int GetDistance(int speed, int time)
        {
            var maxSpeed = base.Drive(speed);
            return (speed * time);
        }
    }
}
