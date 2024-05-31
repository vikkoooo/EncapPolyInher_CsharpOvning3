using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Swan : Bird
	{
		public string Location { get; protected set; }

		public Swan(string name, double weight, int age, int cutenessLevel, double wingSpan, string location)
			: base(name, weight, age, cutenessLevel, wingSpan)
		{
			Location = location;
		}
		public override string Stats()
		{
			return $"{base.Stats()}, Location: {Location}";
		}
	}
}
