using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
	internal class NullInputError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to submit a null input. This fired an error!";
		}
	}
}
