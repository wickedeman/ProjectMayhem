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
		Debug.Log(myReplace ("This has a spellngi error", "spellngi", "spelling"));
		Debug.Log(myReplace ("His name is Tom", "Tom", "john"));
		Debug.Log(myReplace ("Let us get back to more Coding", "Coding", "algorithms"));
	}

	public string myReplace(string str, string before, string after)
	{
		if ( char.IsLower(before[0]) && char.IsLower(after[0]) )
			{
			//Debug.Log ("Lowercase and Lowercase");
				if (before.Length == 5) 
				{
					if (before.Substring (5) == "ngi") 
					{
						after = after.Replace (before.Substring (5), "ing");
					}
				}				
			}
		if (char.IsUpper(before[0]) && char.IsLower(after[0])) 
			{
			//Debug.Log ("Uppercase and Lowercase");
			after = char.ToUpper(after[0]) + after.Substring(1);
			}

		str = str.Replace (before, after);
		return str;
	}

}
