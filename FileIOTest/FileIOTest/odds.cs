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
    public void displayOdds(String[] file) 
    {
        foreach(String num in file)
        {
            if (Int32.Parse(num)% 2 != 0)
            {
                Console.WriteLine(num);
            }
        }
    }
}
