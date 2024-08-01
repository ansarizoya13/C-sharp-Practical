class PrimeNum
{
	public void Func(string[] args)
	{
		int num = System.Convert.ToInt32(args[0]);
		int a = 0;
		for(int i = 1 ; i <= num ; i++)
		{
			if(num % i == 0)
			{
				a++;                                                                                                                                                                                                                                                                                
			}
		}
			if(a == 2)
			{
				System.Console.WriteLine("The number is a prime number");
			}
			else
			{
				System.Console.WriteLine("The number is not a prime number");
			}
		
	}
}

class PrimeNumbers
{
	public static void Main(string[] args)
	{
		PrimeNum obj = new PrimeNum();
		obj.Func(args);
	}
}