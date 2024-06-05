using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorePolymorphism
{
	internal class Dog : Animal
	{
		public override string Name { get; protected set; }
		public override double Weight { get; protected set; }
		public override int Age { get; protected set; }
		public override int CutnessLevel { get; protected set; }
		public string Breed { get; protected set; }

		public Dog(string name, double weight, int age, int cutenessLevel, string breed)
		{
			Name = name;
			Weight = weight;
			Age = age;
			CutnessLevel = cutenessLevel;
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
