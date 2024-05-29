internal class Person
{
	// Fields
	private int age;
	private string fName;
	private string lName;
	private int height;
	private int weight;

	// Getters & setters
	public int Age
	{
		get { return age; }
		set
		{
			if (value <= 0)
			{
				throw new ArgumentException("Age can not be less than or equal to zero");
			}
			else
			{
				age = value;
			}
		}
	}

	public string FName
	{
		get { return fName; }
		set
		{
			if (value.Length < 2 || value.Length > 10)
			{
				throw new ArgumentException("First name can not be less than two characters long or more than ten characters long");
			}
			else
			{
				fName = value;
			}
		}
	}

	public string LName
	{
		get { return lName; }
		set { lName = value; } // todo implement check
	}


	public Person(string fName, string lName)
	{
		FName = fName;
		LName = lName;
	}
}