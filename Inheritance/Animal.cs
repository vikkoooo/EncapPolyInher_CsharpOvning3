using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal abstract class Animal
	{
		// Animal properties
		public string Name { get; protected set; }
		public double Weight { get; protected set; }
		public int Age { get; protected set; }
		public int CutnessLevel { get; protected set; }

		// Constructor
		protected Animal(string name, double weight, int age, int cutnessLevel)
		{
			Name = name;
			Weight = weight;
			Age = age;
			CutnessLevel = cutnessLevel;
		}

		// Animal Functions
		public abstract string DoSound();
	}
}
