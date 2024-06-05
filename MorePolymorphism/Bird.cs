using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePolymorphism
{
	internal class Bird : Animal
	{
		public double WingSpan { get; protected set; }

		public Bird(string name, double weight, int age, int cutenessLevel, double wingSpan)
			: base(name, weight, age, cutenessLevel)
		{
			WingSpan = wingSpan;
		}

		public override string DoSound()
		{
			return "chick-a-dee-dee-dee";
		}

		public override string Stats()
		{
			return $"{base.Stats()}, WingSpan: {WingSpan}";
		}
	}
}
