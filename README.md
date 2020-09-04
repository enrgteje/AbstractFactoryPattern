Author: Enrique Tejeda
Program: AbstractFactoryPattern
Date: 9-4-2020
Description: Program reads in a file that the user provides the name for and calculates the standard deviation of the scores inside the file. Program also prints all
	     the scores and the standard deviation of the scores.

Files needed to run program: 
	Program.cs
	PhoneTypeChecker.cs
	PhoneFactory.cs
	NokiaFactory.cs
	HTCFactory.cs
	SamsungFactory.cs
	Dumb.cs
	Asha.cs
	Genio.cs
	Primo.cs
	Smart.cs
	Lumia.cs
	GalaxyS2.cs
	Titan.cs

Design Decisions:
	-PhoneTypeChecker.cs
		-In the parameterized constructor I set Manufacturers manu equal to Manufacturers m so that the public void function
		 CheckProducts() would be able to make a switch statement accessing the enum Manufacturers.
		-At each case, it will print the smart and dumb phone that is created by the corresponding Manufacturer
		-If the input doesn't match anything that is listed, then it will print to the console "Phone doesn't exist".
