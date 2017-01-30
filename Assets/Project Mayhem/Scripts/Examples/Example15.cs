using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example15 : MonoBehaviour {

	// Example using the "?" operator
	public int direction = 25;

	// Use this for initialization
	void Start () {
		test ();
	}

	public void test()
	{
		
	direction = direction < 1 ? 1 : 0;
	Debug.Log (" results: " + direction);
		//Logs Returns: 0 Direction is greater than 1 return 0 
		// ? operator returns the X value if true otherwise value Y ( ? X : Y ) 
	}
}
