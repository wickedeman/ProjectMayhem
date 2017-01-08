using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example10 : MonoBehaviour {
	//Write a function called generateFizzBuzz that returns an object with all the numbers from 1 to 100 as keys and values, 
	//with two exceptions. For numbers divisible by 3, the value should be "Fizz" instead of the number, 
	//and for numbers divisible by 5 (and not 3), the value should be "Buzz" instead. Example: 
	// Use this for initialization
	void Start () {

		generateFizzBuzz ();
		
	}
	
	public void generateFizzBuzz()
	{
		for (int i = 1; i <= 100; i++) 
		{
			bool fizz = i % 3 == 0;
			bool buzz = i % 5 == 0;

			if (fizz && buzz) 
			{
				Debug.Log ("fizzBuzz");
			}
			else if (fizz) 
			{
				Debug.Log ("fizz");
			}
			else if (buzz) {
				Debug.Log ("buzz");
			} 
			else 
			{
				Debug.Log (i);	
			}
		}
	}


}
