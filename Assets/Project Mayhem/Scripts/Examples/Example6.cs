using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example6 : MonoBehaviour {
	//Write a function that adds and subtracts a given array of number, in alternation and returns the results. For Example given [1,2,3,4,5]
	//it should return -1, because 1+2+4-5= -1
	List<int> arrayX = new List<int> () { 1, 2, 3, 4, 5 };
	int results;
	// Use this for initialization
	void Start () {
		Debug.Log (addSubArrayy ());
	}
	public int addSubArrayy()
	{
		for (int i = 0; i <= arrayX.Count-2; i++) 
		{
			results = results + i;
		}

		results = arrayX [4] - results;
		return results;
	}
}
