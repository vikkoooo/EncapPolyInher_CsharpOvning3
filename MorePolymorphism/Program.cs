using System;
using static Inheritance.Horse;

namespace Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create list
			List<Animal> animals = new List<Animal>();

			// Add dummy animals to list
			animals.Add(new Dog("Lola", 4.8, 3, 10, "Sausage Dog")); // cutest of them all
			animals.Add(new Horse("Golden Hornline", 500, 5, 7, BloodType.Warm));
			animals.Add(new Hedgehog("Sonic", 1.0, 2, 4, 5000));
			animals.Add(new Worm("Boggy B", 0.1, 1, 1, false));
			animals.Add(new Bird("Scrooge McDuck", 0.5, 1, 4, 25.5));
			animals.Add(new Wolf("Ralph Wolf", 80.0, 4, 3, true));
			animals.Add(new Pelican("Monte the Pelican", 10, 3, 7, 200, 30));
			animals.Add(new Flamingo("Yo Yo Flamingo", 5, 4, 9, 150, "Pink"));
			animals.Add(new Swan("Whiteiy", 8, 2, 8, 180, "Norr Mälarstrand"));
			animals.Add(new Wolfman("Bela", 85.5, 18, 1, true));

			// Print out animals
			foreach (var animal in animals)
			{
				Console.WriteLine(animal.Stats());
				Console.WriteLine($"{animal.Name} ({animal.GetType().Name}) says: {animal.DoSound()}");

				// if element is something, cast to
				if (animal is IPerson person)
				{
					Console.WriteLine(person.Talk());
				}
				Console.WriteLine();
			}
		}
	}
}