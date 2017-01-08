using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example3 : MonoBehaviour {

	List<int> arrayX = new List<int> () { 1, 2, 3 };
	List<int> arrayY = new List<int> () { 4, 5, 6 };
	List<string> results = new List<string> ();

	// Use this for initialization
	void Start () {
		addArray ();
		//results.ForEach (Debug.Log); //Prints each element in the array.
		Debug.Log( "[" + results[0] + "," + results[1] + "," + results[2] + "]");
	}

	public List<string>  addArray ()
	{
		for (int i = 0; i <= arrayX.Count - 1; i++) 
		{
			int myInt = arrayX [i] + arrayY [i];
			string myString = myInt.ToString();
			results.Add (myString);
		}
		return results;
	}
}
