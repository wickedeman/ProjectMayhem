using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Example13 : MonoBehaviour {
	// Perform a search and replace on the sentence using the arg provided and return the new sentence 
	// Use this for initialization
	void Start () {
		Debug.Log(myReplace ("Let us go to the store", "store", "mall"));
		Debug.Log(myReplace ("He is Sleeping on the couch", "Sleeping", "sitting"));

		
	}

	public string myReplace(string str, string before, string after)
	{
		//after.IsLower (after);
		after = after.ToUpper ();
		str = str.Replace (before, after);
		return str;
	}

}
