using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example7 : MonoBehaviour {
	// Write a function that returns a horizontal line of asterisks of a specified length. Don't just write this out to the log -- 
	//a ctually return the string. Why? So you can unit-test it. It's harder to unit-test output going to the console log 
	List<int> arrayX = new List<int> () { 1, 2, 3, 4, 5 };
	string results;

	// Use this for initialization
	void Start () {
		Debug.Log (unitTest (7));
	}
	public string unitTest (int num)
	{
		for (int i = 0; i <= num-1; i++) 
		{
			results = results + "#";
		}
		return results;
	}
}
