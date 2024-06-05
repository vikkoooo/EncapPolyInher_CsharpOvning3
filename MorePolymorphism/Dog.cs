using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePolymorphism
{
	internal class Dog : Animal
	{
		public string Breed { get; protected set; }

		public Dog(string name, double weight, int age, int cutenessLevel, string breed)
			: base(name, weight, age, cutenessLevel)
		{
			Breed = breed;
		}

		public override string DoSound()
		{
			return "woff";
		}

		public override string Stats()
		{
			return $"{base.Stats()}, Breed: {Breed}";
		}

		public string GetMood()
		{
			// Define possible moods
			string[] moods = { "sleepy", "playful", "cozy", "scared", "proud", "hungry" };
			Random rand = new Random(); // import random instance

			return moods[rand.Next(0, moods.Length)];
		}
	}
}
