using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePolymorphism
{
	internal class Wolf : Animal
	{
		public bool PackLeader { get; protected set; }

		public Wolf(string name, double weight, int age, int cutenessLevel, bool packLeader)
			: base(name, weight, age, cutenessLevel)
		{
			PackLeader = packLeader;
		}

		public override string DoSound()
		{
			return "awoo";
		}
		public override string Stats()
		{
			return $"{base.Stats()}, PackLeader: {PackLeader}";
		}
	}
}
