using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Odds
{
	public Odds()
	{

	}
    public static void displayOdds(String[] file) 
    {
        Console.WriteLine("Odds: ");
        foreach(String num in file)
        {
            if (Int32.Parse(num)% 2 != 0)
            {
                Console.WriteLine(num);
            }
        }
    }
    public static void displaySums(String[] file)
    {
        var sum = 0;
        foreach(String num in file)
        {
            sum += (Int16.Parse(num));
        }
        Console.WriteLine("Sum: " +sum);
    }
}
