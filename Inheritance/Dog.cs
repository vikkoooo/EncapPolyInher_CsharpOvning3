using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Dog : Animal
	{
		public string Breed { get; protected set; }

		public Dog(string name, double weight, int age, int cutenessLevel, string breed)
			: base(name, weight, age, cutenessLevel)
		{
			Breed = breed;
		}

		public override string DoSound()
		{
			return "woff";
		}
	}
}
