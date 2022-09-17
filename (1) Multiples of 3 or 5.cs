using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		List<int> multfive = new List<int>();
		List<int> multthree = new List<int>();
		List<int> allints = new List<int>();
		
		int sum = 0;
		string three = "mult of 3: ";
		string five = "mult of 5: ";
		
		for(int i = 1; i < 1000; i++)
		{
			if((i % 3) == 0) multthree.Add(i);
			if((i % 5) == 0 && (i % 3) != 0) multfive.Add(i);
		}
		
		for(int i = 0; i < multfive.Count; i++)
		{
			allints.Add(multfive[i]);	
			five += $"{multfive[i]},";
		}
		
		for(int i = 0; i < multthree.Count; i++)
		{
			
			allints.Add(multthree[i]);	
			three += $"{multthree[i]},";	
		}
		
		
		
		for(int i = 0; i < allints.Count; i++)
		{
			sum += allints[i];
		}
		
		Console.WriteLine(three);
		Console.WriteLine(five);
		Console.WriteLine(sum);
	}
}
