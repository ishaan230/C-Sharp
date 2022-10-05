using System;

public class Test
{
	public static void Main()
	{
		int test = Convert.ToInt32(Console.ReadLine());
		while(test>0)
		{
		    int x = Convert.ToInt32(Console.ReadLine());
		    if(x<=4 && x>=1)
		    Console.WriteLine("YES");
		    else
		    Console.WriteLine("NO");
		    test--;
		}
	}
}
