using System;
class WhileTest1
{
	public void func()
	{
		int n = 1;
		while(n<=10)
		{
			if(n%2==0)
			{
				n++;
			}
			else
			{
				System.Console.WriteLine(" "+n);
				n++;
			}
		}
	}
}

class WhileTest
{
	public static void Main(string[] args)
	{
	WhileTest1 obj = new WhileTest1();
	obj.func();
	} 	
}