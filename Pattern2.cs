using System;
class Pattern2
{
	public static void Main(string[] args)
	{
		int i,j;
		int num = System.Convert.ToInt32(args[0]);	
		for(i = 1; i <= num; i++)
		{
			for(j = 1; j <= num - i; j++)
			{
				System.Console.Write(i + " ");	
			}
			for(j = 1; j <= i; j++)
			{
				System.Console.Write(i);
				if(j < i)
				{
					System.Console.Write("    ");
				}
			}
			System.Console.WriteLine();
			Console.ReadKey();
		}

	}
}