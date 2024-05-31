﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal abstract class Animal
	{
		// Animal propertys
		public abstract string Name { get; protected set; }
		public abstract string Weight { get; protected set; }
		public abstract int Age { get; protected set; }
		public abstract int CutnessLevel { get; protected set; }

		// Constructor
		public Animal() { }

		// Animal Functions
		public abstract string DoSound();
	}
}