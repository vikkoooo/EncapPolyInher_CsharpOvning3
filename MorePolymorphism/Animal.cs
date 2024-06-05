using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePolymorphism
{
	internal abstract class Animal
	{
		// Animal propertys
		public abstract string Name { get; protected set; }
		public abstract double Weight { get; protected set; }
		public abstract int Age { get; protected set; }
		public abstract int CutnessLevel { get; protected set; }

		// Constructor
		public Animal() { }

		// Animal Functions
		public abstract string DoSound();

		public virtual string Stats()
		{
			return $"Name: {Name}, Weight: {Weight}, Age: {Age}, Cuteness Level: {CutnessLevel}";
		}
	}
}
