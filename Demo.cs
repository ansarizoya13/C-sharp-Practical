using System;
class Demo
{
		public void Trial()
		{
		int reverse = 0;
		int value;
		System.Console.WriteLine("Enter the Number");
		int num = System.Convert.ToInt32(Console.ReadLine());
		while(num!= 0)
		{
			value = num % 10;
			reverse = reverse * 10 + value;
			num = num/10;
		}
		System.Console.WriteLine("The Reverse Number is : "+reverse);
		}
}    


class Operation
{
	public static void Main(string[] args)
	{
		Demo demo = new Demo();
		demo.Trial();	
	}
}                                                                                          