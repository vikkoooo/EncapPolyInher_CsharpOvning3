using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Hedgehog : Animal
	{
		public override string Name { get; protected set; }
		public override double Weight { get; protected set; }
		public override int Age { get; protected set; }
		public override int CutnessLevel { get; protected set; }
		public int NrOfSpikes { get; protected set; }

		public Hedgehog(string name, double weight, int age, int cutenessLevel, int nrOfSpikes)
		{
			Name = name;
			Weight = weight;
			Age = age;
			CutnessLevel = cutenessLevel;
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
