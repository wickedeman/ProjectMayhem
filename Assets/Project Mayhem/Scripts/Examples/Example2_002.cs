using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example2_002 : MonoBehaviour {
	List<int> array = new List<int> () { 1, 2, 3 };
	List<string> storage = new List<string> ();

	// Use this for initialization
	void Start () {
		multiplyByNine();
		//storage.ForEach (Debug.Log); //Prints each element in the array.
		Debug.Log( storage[0] + "," + storage[1] + "," + storage[2]);
	}

	public List<string> multiplyByNine()
	{
		for (int i = 0; i <= array.Count-1; i++) 
		{
			int myInt = array [i];
			int myNewInt = (array [i] * 9);
			string myString = "[" + myInt.ToString() + "," + myNewInt.ToString() + "]";
			//Debug.Log (myString);
			storage.Add (myString);
		}
		return storage;
	}
}
