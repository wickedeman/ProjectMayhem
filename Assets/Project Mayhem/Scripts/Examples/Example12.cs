using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example12 : MonoBehaviour {
	// Write a function that determines which of the next n years is a leap year. If the caller passes in 300, 
	//then the program should return the leap years between 2016 and 2316.

	//For reference, see:
	//https://www.mathsisfun.com/leap-years.html
	// Use this for initialization

	void Start () {
		Debug.Log(leapYear (300));
	}

	public string leapYear( int num)
	{
		int year = 2016;
		int range = num + year;
		List<int> leapYearArray = new List<int> ();

		for (int i = year; i <= range; i++) 
		{
			bool byFour = i % 4 == 0;
			bool byHun = i % 100 == 0;
			bool byFourHun = i % 400 == 0;

			if (byFour || byFourHun) 
			{
				if (byHun) 
				{
					//do nothing.
				} 
				else 
				{
					leapYearArray.Add (i);
					Debug.Log (i);
				}					
			}
		}

		string results = ( "leap years between " + year.ToString() + " and " + range.ToString() + " are: " );
		return results;
	}
}
