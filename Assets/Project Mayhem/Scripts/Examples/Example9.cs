using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example9 : MonoBehaviour {
	// Create a function called getFirstAnimals that returns an array of all the first animals in ther
	// Use this for initialization
	List<string> mammals = new List<string> () {"bears", "lions", "whales", "otters" };
	List<string> birds = new List<string> () {"penguins", "ducks", "swans", "chicken" };
	List<string> cats = new List<string> () {"panther", "mountain lion", "leopard", "snow tiger" };
	List<string> insects = new List<string> () {"flea", "mosquito", "beetle", "fly", "grasshopper" };
	List<string> results = new List<string> ();
	string getFirstAnimalsStr;
	string getLastAnimalsStr;


	void Start () {
		getFirstAnimals ();
		Debug.Log (getFirstAnimalsStr);
		getLastAnimals ();
		Debug.Log (getLastAnimalsStr);
	}

	public List<string> getFirstAnimals ()
	{
		getFirstAnimalsStr = ("[" + mammals [0] + ", " + birds [0] + ", " + cats [0] + ", " + insects [0] + "]");
		results.Add (mammals [0]);
		results.Add (birds [0]);
		results.Add (cats [0]);
		results.Add (insects [0]);

		return results;
	}

	public List<string> getLastAnimals ()
	{
		getLastAnimalsStr = ("[" + ( mammals[mammals.Count -1] ) + ", " + ( birds[birds.Count -1] ) + ", " + ( cats[cats.Count -1] ) + ", " + ( insects[insects.Count -1] ) + "]");
		results.Add (mammals[mammals.Count -1]);
		results.Add (birds[birds.Count -1]);
		results.Add (cats[cats.Count -1]);
		results.Add (insects[insects.Count -1]);

		return results;
	}




}
