class Main
{
	private int m;
	private int n; 
	public void func()
	{
		m = 10;
	        n = 20;
		System.Console.WriteLine("m = "+m);
		System.Console.WriteLine("n = "+n);
		System.Console.WriteLine("++m = "+ (++m));
		System.Console.WriteLine("n++ = "+ n++);
		System.Console.WriteLine("m = "+m);
		System.Console.WriteLine("n = "+n);
	}
}

class IncrementOperator
{
	public static void Main(string[] args)
	{
		Main obj = new Main();
		obj.func();
	}
}










			
	