using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Bird : Animal
	{
		public override string Name { get; protected set; }
		public override double Weight { get; protected set; }
		public override int Age { get; protected set; }
		public override int CutnessLevel { get; protected set; }
		public double WingSpan { get; protected set; }

		public Bird(string name, double weight, int age, int cutenessLevel, double wingSpan)
		{
			Name = name;
			Weight = weight;
			Age = age;
			CutnessLevel = cutenessLevel;
			WingSpan = wingSpan;
		}

		public override string DoSound()
		{
			return "chick-a-dee-dee-dee";
		}
	}
}
