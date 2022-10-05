using System;

public class Test
{
	public static void Main()
	{
		int test = Convert.ToInt32(Console.ReadLine());
            while (test>0)
            {
                string[] s;
                string[] lines = Console.ReadLine().Split(' ');
                int a = int.Parse(lines[0]);
                int b = int.Parse(lines[1]);
                int c = int.Parse(lines[2]);
                if (b+(2*c)> a)
                    Console.WriteLine("NO");
                else
                    Console.WriteLine("YES");
                test--;
            }
		}
	}
