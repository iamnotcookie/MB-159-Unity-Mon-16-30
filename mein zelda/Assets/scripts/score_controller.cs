using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_controller : MonoBehaviour 
{
	private game_controller gamecontroller;
	private Text scoretext;

	private void Start(){
		gamecontroller = GameObject.FindWithTag ("GameController").GetComponent<game_controller>();
		scoretext = GetComponent<Text> ();
	}
	// Update is called once per frame
	private void FixedUpdate () {
		scoretext.text = "Score: " +  gamecontroller.showScore();
	}
}
