using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Example1.
/// This Examples to test the use of List<T> over default array.
/// Count is the same as using Length.
/// </summary>
public class Example1 : MonoBehaviour {
	List<int> zeroToTwentyA = new List<int> ();
	List<int> twentyToZeroA = new List<int> ();

	// Use this for initialization
	void Start () {		
		generateZeroToTwenty (); // Write a function called generateZeroToTwenty that retuns an array of int from 0 - 20
		generateTwentyToZero (); // Write a function called generateTwentyToZero that retuns an array of int from 20 - 0
	}

	void Update ()
	{

	}

	public void generateZeroToTwenty()
	{		
		for (int i = 0; i < 21; i++) 
		{
			zeroToTwentyA.Add (i);
		}
	}
	public void generateTwentyToZero()
	{		
		for (int i = 20; i >= 0; i--) 
		{
			twentyToZeroA.Add (i);
			Debug.Log (i);
		}
	}
}