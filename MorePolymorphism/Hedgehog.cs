using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePolymorphism
{
	internal class Hedgehog : Animal
	{
		public int NrOfSpikes { get; protected set; }

		public Hedgehog(string name, double weight, int age, int cutenessLevel, int nrOfSpikes)
			: base(name, weight, age, cutenessLevel)
		{
			NrOfSpikes = nrOfSpikes;
		}

		public override string DoSound()
		{
			return "hedgehogging";
		}

		public override string Stats()
		{
			return $"{base.Stats()}, NrOfSpikes: {NrOfSpikes}";
		}
	}
}
