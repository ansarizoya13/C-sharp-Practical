using System;
class Series
{
	public void func()
	{
		int a = 0,b = 1;
		int c,n;
		int i;
		System.Console.WriteLine("Enter the term for the series");
		n = System.Convert.ToInt32(Console.ReadLine());
		System.Console.Write(" "+a);
		System.Console.Write(" "+b);
		for(i = 2;i<= n;i++)
		{
			c = a + b;
			System.Console.Write(" "+c);
			a = b;
			b = c;
		}
	}

}

class Fibonacci
{
	public static void Main(string[] args)
	{
		Series obj = new Series();
		obj.func();
	}
}