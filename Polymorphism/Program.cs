using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<UserError> errors = new List<UserError>();

			// Create dummy data
			Random rand = new Random();
			for (int i = 0; i < 15; i++)
			{
				int error = rand.Next(1, 6); // will generate 1 - 5

				switch (error)
				{
					case 1:
						errors.Add(new EmailInputError());
						break;
					case 2:
						errors.Add(new NullInputError());
						break;
					case 3:
						errors.Add(new NumericInputError());
						break;
					case 4:
						errors.Add(new RequiredFieldError());
						break;
					case 5:
						errors.Add(new TextInputError());
						break;
				}
			}

			// Print errors
			foreach (UserError error in errors)
			{
				Console.WriteLine(error.UEMessage());
			}
		}
	}
}