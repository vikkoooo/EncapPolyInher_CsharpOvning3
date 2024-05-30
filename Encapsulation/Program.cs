using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				PersonHandler handler = new PersonHandler();

				// Create dummy person			
				Person viktor = handler.CreatePerson(34, "Viktor", "Lundberg", 177.5, 68.5);


				// Test props
				Console.WriteLine(viktor);
				handler.SetAge(viktor, 35);
				handler.SetFirstname(viktor, "Victor");
				handler.SetLastname(viktor, "Lundgren");
				handler.SetHeight(viktor, 180.0);
				handler.SetWeight(viktor, 70);
				Console.WriteLine(viktor);

				// Test edge cases
				//handler.SetAge(viktor, -10);
				//handler.SetFirstname(viktor, "V");
				//handler.SetFirstname(viktor, "Viktorvikto");
				//handler.SetLastname(viktor, "Lu");
				//handler.SetLastname(viktor, "Lundberglundberg");
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
		}
	}
}