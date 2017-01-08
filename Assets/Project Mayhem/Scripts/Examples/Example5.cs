using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example5 : MonoBehaviour {
	//Write a function that averages a given array of numbers
	List<int> arrayX = new List<int> () { 1, 2, 3, 4, 5, 6 };
	int results;

	// Use this for initialization
	void Start () {
		Debug.Log (avrgArray ());
		
	}

	public int avrgArray()
	{
		int avrgAmount = arrayX.Count;
		for (int i = 0; i <= arrayX.Count; i++) 
		{
			results = results + i;
		}
		results = results / avrgAmount;
		return results;
	}
}
