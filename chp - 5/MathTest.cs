class Main
{
	public void func()
	{
		 double math;
		System.Console.WriteLine("sines of angles from 0 to 90 degrees");
		for(double theta = 0.0; theta <= 90.00; theta += 15)
		{
			double x = math.Sin (theta * math.PI/180);
			System.Console.WriteLine("Sin" + theta);
			System.Console.WriteLine(" ={0:F4}" + x);
		}
	}
}

class MathTest
{
	public static void Main(string[] args)
	{
		Main obj = new Main();
		obj.func();
	}	
}