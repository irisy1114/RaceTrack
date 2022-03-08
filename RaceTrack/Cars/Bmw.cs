using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    public class Bmw : RaceCar
    {
        public Bmw()
        {
            Name = "BMW";
            TopSpeed = 100;
        }
        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} is ready to hit the road!");
        }

        public override void Brake()
        {
            Console.WriteLine($"The {Name} is ready to stop!");
            base.Brake();
        }

        public override void StopEngine()
        {
            Console.WriteLine($"The {Name} cuts the engine!");
        }
    }
}
