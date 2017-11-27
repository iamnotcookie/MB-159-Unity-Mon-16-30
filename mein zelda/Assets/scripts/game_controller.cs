using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class game_controller : MonoBehaviour {

	[SerializeField]
	private int score = 0;

	// Use this for initialization
	private void Start () {
		
	}
	
	// Update is called once per frame
	private void Update () {
		
	}

	public void addScore(){
		score++;
	}
}
