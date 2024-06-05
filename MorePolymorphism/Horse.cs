using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePolymorphism
{
	internal class Horse : Animal
	{
		public enum BloodType { Warm, Cold };
		public BloodType Type { get; protected set; }

		public Horse(string name, double weight, int age, int cutenessLevel, BloodType type)
			: base(name, weight, age, cutenessLevel)
		{
			Type = type;
		}

		public override string DoSound()
		{
			return "neigh";
		}

		public override string Stats()
		{
			return $"{base.Stats()}, BloodType: {Type}";
		}
	}
}
