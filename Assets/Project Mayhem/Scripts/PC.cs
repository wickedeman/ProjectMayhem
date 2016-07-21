using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Controller2D))]
public class PC : MonoBehaviour {

	Controller2D controller;

	void Start(){

		controller = GetComponent<Controller2D> ();
	}
}
