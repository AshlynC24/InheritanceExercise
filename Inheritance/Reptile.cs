using System;
namespace Inheritance
{
    public class Reptile : Animal
    {
        public int HowManyLegs { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public bool IsAlive { get; set; }

        public bool IsFourLegged { get; set; }
        public string MakesNoise { get; set; }
        public int HowManySpotsOrScale { get; set; }
        public bool WarmBlooded { get; set; }
    }
}

