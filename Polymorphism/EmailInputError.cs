using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
	internal class EmailInputError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to use an invalid email address format. This fired an error!";
		}
	}
}
