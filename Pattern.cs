using System;
class Pattern
{
	public void Func()
	{		
		int n = 5;
		int i,j;
		for (i = 1; i <= n; i++)
		{
			for(j = 1; j<=i; j++)
			{
				System.Console.Write(i + " ");
			}
			Console.WriteLine();
		}
	}                     
}


class Print
{
	public static void Main(string[] args)
	{
		Pattern demo = new Pattern();
		demo.Func();
	}
}