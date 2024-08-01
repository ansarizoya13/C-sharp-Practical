using System;
class Consonant
{
	public void Func()
	{
		char Ch ;
		System.Console.WriteLine("Enter the alphabet to check");
		Ch = char.Parse(Console.ReadLine());
		if(Ch == 'a' || Ch == 'e'  || Ch == 'i'  || Ch == 'o' || Ch == 'u'  || Ch == 'A' || Ch == 'E' || Ch == 'I' || Ch == 'O' || Ch == 'U')
		{
			System.Console.WriteLine("The Alphabet is a vowel");
		}
		else
		{
			System.Console.WriteLine("The Alphabet is a Consonant");
		}
	}
}

class Vowels
{
	public static void Main(string[] args)
	{
		Consonant demo = new Consonant();
		demo.Func();
	}
} 