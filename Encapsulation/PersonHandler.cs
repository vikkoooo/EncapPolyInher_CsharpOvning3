using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
	internal class PersonHandler
	{
		public Person CreatePerson(int age, string fName, string lName, double height, double weight)
		{
			return new Person(age, fName, lName, height, weight);
		}

		public void SetAge(Person pers, int age)
		{
			pers.Age = age;
		}

		public void SetFirstname(Person pers, string fName)
		{
			pers.FName = fName;
		}

		public void SetLastname(Person pers, string lName)
		{
			pers.LName = lName;
		}

		public void SetHeight(Person pers, double height)
		{
			pers.Height = height;
		}

		public void SetWeight(Person pers, double weight)
		{
			pers.Weight = weight;
		}
	}
}
