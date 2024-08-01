class Number
{
	private int fact;
	private int num;
	public void Fact()
	{
		System.Console.WriteLine("Enter the Number : ");
		num = System.Convert.ToInt32(System.Console.ReadLine());
		fact = 1;
		for(int i = 1; i<=num; i++)
		{
			fact = fact * i;
		}
		System.Console.WriteLine("Factorial of Number is : "+fact);
	}
}

class Factorial
{
	public static void Main(string[] args)
	{
		Number obj = new Number();
		obj.Fact();
	}
}