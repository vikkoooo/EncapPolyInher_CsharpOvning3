using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Pelican : Bird
	{
		public double MouthSize { get; protected set; }

		public Pelican(string name, double weight, int age, int cutenessLevel, double wingSpan, double mouthSize)
			: base(name, weight, age, cutenessLevel, wingSpan)
		{
			MouthSize = mouthSize;
		}
		public override string Stats()
		{
			return $"{base.Stats()}, MouthSize: {MouthSize}";
		}
	}
}
