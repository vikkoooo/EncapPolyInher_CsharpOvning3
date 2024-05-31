using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Horse : Animal
	{
		public override string Name { get; protected set; }
		public override double Weight { get; protected set; }
		public override int Age { get; protected set; }
		public override int CutnessLevel { get; protected set; }
		public enum BloodType { Warm, Cold };
		public BloodType Type { get; protected set; }


		public Horse(string name, double weight, int age, int cutenessLevel, int speed, BloodType type)
		{
			Name = name;
			Weight = weight;
			Age = age;
			CutnessLevel = cutenessLevel;
			Type = type;
		}

		public override string DoSound()
		{
			return "neigh";
		}
	}
}
