using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpriteFactory;

public class Walk : MonoBehaviour {
	private SpriteFactory.Sprite mySprite;



	// Use this for initialization
	void Start () {
		mySprite = GetComponent<SpriteFactory.Sprite> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			mySprite.Play ("Walk");
			Vector3 pos = transform.position;
			pos.x += Time.deltaTime * 2;
			transform.position = pos;
		} else
		{
			mySprite.Stop ();
		}
			
		
	}
}
