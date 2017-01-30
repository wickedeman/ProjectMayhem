using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example16 : MonoBehaviour {
	public MoveSetData myMoveSetData;
	//UFE Test code
	// Use this for initialization
	void Start () {
		OnGameBegin (UFE.GetPlayer1 (), UFE.GetPlayer2 ());
		myMoveSetData = UFE.GetCurrentMoveSet (UFE.GetPlayer1 ());
	}

	
	// Update is called once per frame
	void Update () {
		Debug.Log (myMoveSetData.basicMoves.dash.name);
	}

	public void OnGameBegin(CharacterInfo player1, CharacterInfo player2)
	{
		Debug.Log(player1.characterName + " - " + player1.playerNum);
		Debug.Log(player2.characterName + " - " + player2.playerNum);
	}
}
