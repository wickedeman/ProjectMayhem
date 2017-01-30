using UnityEngine;
using System.Collections;

[RequireComponent (typeof (Controller2D))]
public class PC : MonoBehaviour {

	float moveSpeed = 6;
	float gravity = -20;
	Vector3 velocity;

	Controller2D controller;

	void Start(){
		controller = GetComponent<Controller2D> ();
	}

	void Update() {

		Vector2 input = new Vector2 (Input.GetAxisRaw ("P1KeyboardHorizontal"), Input.GetAxisRaw ("P1KeyboardVertical"));

		velocity.x = input.x * moveSpeed;
		velocity.y += gravity * Time.deltaTime;
		controller.Move (velocity * Time.deltaTime);
	}
}