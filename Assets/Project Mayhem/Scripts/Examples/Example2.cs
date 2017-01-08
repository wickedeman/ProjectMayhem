using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2 : MonoBehaviour {
	//List<int> multipleByNineA = new List<int> ();
	// Use this for initialization
	List<int> myArray = new List<int> ();
	List<int[]> myResults = new List<int[]> ();

	void Start () {
		multipleByNine (1, 2, 3);

		//myResults.ForEach (i => Debug.Log ("{0}/t", i));
		//Debug.Log(myResults[1][1]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public List<int[]> multipleByNine(int x, int y, int z)
	{
		myArray.Add (x);
		myArray.Add (y);
		myArray.Add (z);
		//Debug.Log (myArray [0]);

		for (int i = 0; i < myArray.Count; i++) 
		{
			int[] myIntArray = {myArray[i], (myArray [i] * 9) };
			Debug.Log (myIntArray[0]);
			myResults.Add (myIntArray);
		}

		//int[] newArray = myResults.ToArray ();
		return myResults;

	}
}
