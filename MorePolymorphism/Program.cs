using System;
using static Inheritance.Horse;

namespace Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Dummy instances
			Dog dog = new Dog("Lola", 4.8, 3, 10, "Sausage Dog"); // cutest of them all
			Horse horse = new Horse("Golden Hornline", 500, 5, 7, BloodType.Warm);
			Hedgehog hedgehog = new Hedgehog("Sonic", 1.0, 2, 4, 5000);
			Worm worm = new Worm("Boggy B", 0.1, 1, 1, false);
			Bird bird = new Bird("Scrooge McDuck", 0.5, 1, 4, 25.5);
			Wolf wolf = new Wolf("Ralph Wolf", 80.0, 4, 3, true);
			Pelican pelican = new Pelican("Monte the Pelican", 10, 3, 7, 200, 30);
			Flamingo flamingo = new Flamingo("Yo Yo Flamingo", 5, 4, 9, 150, "Pink");
			Swan swan = new Swan("Whiteiy", 8, 2, 8, 180, "Norr Mälarstrand");
			Wolfman wolfman = new Wolfman("Bela", 85.5, 18, 1, true);

			// Stats
			Console.WriteLine(dog.Stats());
			Console.WriteLine(horse.Stats());
			Console.WriteLine(hedgehog.Stats());
			Console.WriteLine(worm.Stats());
			Console.WriteLine(bird.Stats());
			Console.WriteLine(wolf.Stats());
			Console.WriteLine(pelican.Stats());
			Console.WriteLine(flamingo.Stats());
			Console.WriteLine(swan.Stats());
			Console.WriteLine(wolfman.Stats());
		}
	}
}
