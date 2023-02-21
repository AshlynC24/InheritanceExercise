using System;
namespace Inheritance
{
	public class Bird : Animal
	{
        public int HowManyLegs { get; set; }
        public int Age { get; set; }
        public string Breed { get; set; }
        public bool IsAlive { get; set; }


        public int WingSpan { get; set; }
		public string Color { get; set; }
		public string SquakSound { get; set; }
		public bool CanFly { get; set; }
	}


}

