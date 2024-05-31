using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Dog : Animal
	{
		public override string Name { get; protected set; }
		public override string Weight { get; protected set; }
		public override int Age { get; protected set; }
		public override int CutnessLevel { get; protected set; }
		public string Breed { get; protected set; }

		public Dog(string name, string weight, int age, int cutenessLevel, string breed)
		{
			Name = name;
			Weight = weight;
			Age = age;
			CutnessLevel = cutenessLevel;
			Breed = breed;
		}

		public override string DoSound()
		{
			return "woff";
		}
	}
}
