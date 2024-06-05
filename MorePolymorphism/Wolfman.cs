using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePolymorphism
{
	internal class Wolfman : Wolf, IPerson
	{
		public Wolfman(string name, double weight, int age, int cutenessLevel, bool packLeader)
			: base(name, weight, age, cutenessLevel, packLeader) { }

		public string Talk()
		{
			return "Fear me I am the Wolfman!!";
		}
		public override string Stats()
		{
			return $"{base.Stats()}";
		}
	}
}
