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

			// Sounds
			Console.WriteLine($"{horse.Name} the {horse.GetType().Name} says: {horse.DoSound()}");
			Console.WriteLine($"{dog.Name} the {dog.GetType().Name} says: {dog.DoSound()}");
			Console.WriteLine($"{hedgehog.Name} the {hedgehog.GetType().Name} says: {hedgehog.DoSound()}");
			Console.WriteLine($"{worm.Name} the {worm.GetType().Name} says: {worm.DoSound()}");
			Console.WriteLine($"{bird.Name} the {bird.GetType().Name} says: {bird.DoSound()}");
			Console.WriteLine($"{wolf.Name} the {wolf.GetType().Name} says: {wolf.DoSound()}");

			Console.WriteLine($"{pelican.Name} the {pelican.GetType().Name} says: {pelican.DoSound()} with a mouth size of {pelican.MouthSize} cubic");
			Console.WriteLine($"{flamingo.Name} the {flamingo.GetType().Name} says: {flamingo.DoSound()} with feather color {flamingo.FeatherColor}");
			Console.WriteLine($"{swan.Name} the {swan.GetType().Name} says: {swan.DoSound()} and lives at {swan.Location}");

			Console.WriteLine($"{wolfman.Name} the {wolfman.GetType().Name} sounds {wolfman.DoSound()} and then says {wolfman.Talk()}");

			/*
			Q: If we during development come to the conclusion that all birds need a new attribute, in which class should we put it?
			A: I believe we should put the new attribute in Bird.cs, hence all the underlying Birds will have to implement it.
			*/

			/*
			Q: If all animals need the new attribute, where should we put it then?
			A: If all animals need a new attribute we should put it in Animal.cs because all animals will have to implement it.
			*/

		}
	}
}
