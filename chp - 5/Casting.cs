class Main
{
	public void func()
	{
		float sum;
		int i;
		sum = 0.0F;
		for(i = 1; i <= 10; i++)
		{
			sum = sum + 1/ (float)i;
			System.Console.Write(" i = " + i);
			System.Console.WriteLine(" Sum = " + sum);
		}
	}
}

class Casting
{
	public static void Main(string[] args)
	{
		Main obj = new Main();
		obj.func();
	}
}