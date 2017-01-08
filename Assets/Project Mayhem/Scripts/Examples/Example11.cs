using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example11 : MonoBehaviour {
	//Please make a "cold caller" script that picks one of these people to call on, at random. Don't worry about duplicates.
	// Use this for initialization
	List<string> callerArray = new List<string> () {
	"Aaron Aves",
	"Alex Duda",
	"Colton Jett",
	"Elliott Birch",
	"Jamin Ewell",
	"Jane Vaden",
	"Jared Cairns",
	"Jason Sierra",
	"Joshua Peng",
	"Nick Partridge",
	"Rachel Noble",
	"Richard Mathera",
	"Robert Ballard",
	"Sammy Icaza",
	"Samy Kebaish",
	"Silvia Fernandez",
	"Vandeth Nop",
	"Vy Trinh" };
	string call;
	List<string> callerArrayDup = new List<string> ();

	void Start () {
		for (int i = 0; i <= callerArray.Count -1 ; i++) 
		{
			Debug.Log (coldCaller());
		}
			
	}

	public string coldCaller()
	{
		int myRandomInt = Random.Range (0, (callerArray.Count - 1));
		string myString = callerArray [myRandomInt];

		while (callerArrayDup.Contains(myString))
			{
				myRandomInt = Random.Range (0, (callerArray.Count - 1));
				myString = callerArray [myRandomInt];
				
				if (callerArray.Count == callerArrayDup.Count) 
				{
					callerArrayDup.RemoveRange (0, callerArrayDup.Count-1);
					return "Job is complete";
				}

				break;
			}

		callerArrayDup.Add (myString);
		call = myString;
		return call;
	}


}

