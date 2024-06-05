using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePolymorphism
{
	internal class Flamingo : Bird
	{
		public string FeatherColor { get; protected set; }

		public Flamingo(string name, double weight, int age, int cutenessLevel, double wingSpan, string featherColor)
			: base(name, weight, age, cutenessLevel, wingSpan)
		{
			FeatherColor = featherColor;
		}

		public override string Stats()
		{
			return $"{base.Stats()}, FeatherColor: {FeatherColor}";
		}
	}
}
