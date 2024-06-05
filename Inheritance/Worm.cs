using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Worm : Animal
	{
		public bool IsPoisonous { get; protected set; }

		public Worm(string name, double weight, int age, int cutenessLevel, bool isPoisonous)
			: base(name, weight, age, cutenessLevel)
		{
			IsPoisonous = isPoisonous;
		}

		public override string DoSound()
		{
			return "exists";
		}
	}
}
