using System;
/*Using the appropriate data types in C#, create the following variables:

a variable that holds the string "Hello World"
a variable that holds the number 1492
a variable that holds if you have a dog at home
a variable that holds today's date as a string
a variable that holds the amount of $5.45
a variable that holds the single letter X			
*/

public class Program
{
	
	public static void Main()
	{
		
	string s = "Hello World";
	int n = 1492;
	bool ifdog = true;
	DateTime date = new DateTime(2016, 10, 24);
	float c = 5.45f;
	char letter = 'X';
	
		
		Console.WriteLine("{0}, my name is Josh!", s);
		Console.WriteLine("Columbus Sailed the World in {0}.", n); 
		Console.WriteLine("It is not {0} that I have a dog at home.", ifdog);
		Console.WriteLine("Today is {0}.", date);
		Console.WriteLine("I spent ${0} on a cheeseburger.", c);
		Console.WriteLine("{0} marks the spot.", letter);
		
	var b = new[] { new { band = "Led Zeppelin"}, new {band = "NWA"}, new {band = "Flight of the Conchords"}, new {band = "5FDP"}};
		
	var Josh = new { Age = 26, Birthdate = "22 May, 1990", Birthplace = "St. Louis, MO", Hometown = "Vidalia, LA"};
		
	var movies = new[] { new { name = "Pulp Fiction", year = 1994}, new { name = "Moonrise Kingdom", year = 2012}, 
		new { name = "Django Unchained", year = 2012}, new {name = "The Grand Budapest Hotel", year = 2014}};
	}
	
	
	
}