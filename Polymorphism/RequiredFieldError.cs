using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
	internal class RequiredFieldError : UserError
	{
		public override string UEMessage()
		{
			return "You tried to submit the form without filling out a required field. This fired an error!";
		}
	}
}