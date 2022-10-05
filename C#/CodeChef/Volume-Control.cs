using System;

public class Test
{
	public static void Main()
	{
		int test = Convert.ToInt32(Console.ReadLine());
		while(test>0)
		{
		    string[] s;
		    string[] line = Console.ReadLine().Split(' ');
		    int a = int.Parse(line[0]);
		    int b = int.Parse(line[1]);
		    if(b>a)
		    Console.Write(b-a+ "\n");
		    else
		    Console.Write(a-b+ "\n");
		    test--;
		}
	}
}
