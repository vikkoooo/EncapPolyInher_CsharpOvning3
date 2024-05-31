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

			// Sounds
			Console.WriteLine($"{horse.Name} the {horse.GetType().Name} says: {horse.DoSound()}");
			Console.WriteLine($"{dog.Name} the {dog.GetType().Name} says: {dog.DoSound()}");
			Console.WriteLine($"{hedgehog.Name} the {hedgehog.GetType().Name} says: {hedgehog.DoSound()}");
			Console.WriteLine($"{worm.Name} the {worm.GetType().Name} says: {worm.DoSound()}");
			Console.WriteLine($"{bird.Name} the {bird.GetType().Name} says: {bird.DoSound()}");
			Console.WriteLine($"{wolf.Name} the {wolf.GetType().Name} says: {wolf.DoSound()}");
		}
	}
}
