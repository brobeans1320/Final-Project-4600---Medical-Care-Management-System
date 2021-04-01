using System;

public class createAccount
{
	public string name_;
	public string dayOfBirth_;
	public string monthOfBirth_;
	public string yearOfBirth_;
	public string DOB_ = dayOfBirth + monthOfBirth + yearOfBirth;

	public createAccount(string name, string dob)
	{
		Console.Write("Name: ");
		name = Console.ReadLine();
		name_ = name;

		Console.Write("Date of Birth: ");
		dob = Console.ReadLine();
		DOB_ = dob;
	}

	//public void setName(string n)
	//{
	//	name_ = n;
	//}

	//public string getName()
	//{
	//	return name_;
	//}
}
