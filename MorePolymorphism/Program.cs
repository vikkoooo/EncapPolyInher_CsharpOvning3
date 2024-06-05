using System;
using static MorePolymorphism.Horse;

namespace MorePolymorphism
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

			/*
			// Create list of Dogs
			List<Dog> dogs = new List<Dog>();
			dogs.Add(new Horse("Golden Hornline", 500, 5, 7, BloodType.Warm)); // Compiler error

			Q: Try to add a horse to the list of dogs. Why does not it work?
			A: Because a Horse is a class of Horse, and the list can only contain Dogs or its siblings, it's what we declared in <>.

			Q: What type must the list be for all classes to be stored together?
			A: If all types of animals should be able to be in the same list, the list should be of type Animal or even more generic like 
			   Object (not a good solution tho!).

			Q: Print all Animals Stats() through a foreach loop. Explain what is happening.
			A: The most unique Stats() method is looked for, therefore all the Birds will print their Wingspan since we define that in Bird.cs
			   And when we use Stats() on ex. Flamingo we will add one more layer to it, in this case FeatherColor.
			*/

			// Print Stats() only for Dogs
			foreach (var animal in animals)
			{
				if (animal is Dog dog)
				{
					Console.WriteLine(dog.Stats());
				}
			}
			Console.WriteLine();

			/*
			 // Try to access GetMood() from Dog

			foreach (var animal in animals)
			{
				if (animal is Dog dog)
				{
					Console.WriteLine(dog.Stats());
					Console.WriteLine($"{dog.Name} is {dog.GetMood()} right now");
				}
			}

			 Q: Access not possible - why?
			 A: Well actually it is possible, I guess the trick here was to show that we need to cast it to dog?
			    We will not get access if we just do: 
			    if (animal is Dog) 
			    and then try to access the element through animal.GetMood();
			*/

			// Accessing Dogs current mood
			foreach (var animal in animals)
			{
				if (animal is Dog dog)
				{
					Console.WriteLine(dog.Stats());
					Console.WriteLine($"{dog.Name} is {dog.GetMood()} right now");
				}
			}
		}
	}
}