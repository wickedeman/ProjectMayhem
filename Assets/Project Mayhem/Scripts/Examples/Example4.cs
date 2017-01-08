using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example4 : MonoBehaviour {
	//Write a functtion that finds the maximum value in a given array. (without using the math.max() method)


	List<int> arrayX = new List<int> () { 1, 2, 3, 4, 5, 6 };
	int results;
	// Use this for initialization
	void Start () {
		Debug.Log(findMaxValue ());
	}

	public int findMaxValue ()
	{
		for (int i = 0; i <= arrayX.Count; i++) 
		{
			if (i > results) 
			{
				results = i;
			}
		}
		return results;
	}

}
