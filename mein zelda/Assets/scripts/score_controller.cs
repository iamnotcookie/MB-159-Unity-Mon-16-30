using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_controller : MonoBehaviour {


	public static score_controller instance;
	[SerializeField]
	private int score = 0;
	private Text scoreText;
	private GameObject winText;


	// Use this for initialization
	private void Awake () {
		if (instance == null)
		{
			instance = this;
		} else
		{
			Destroy (gameObject);
		}
		scoreText = GameObject.Find ("scoreText").GetComponent<Text> ();
		scoreText.text = "score: " + score.ToString ("D1");
		score = 0;
		winText = GameObject.Find ("winText");
		winText.SetActive (false);
	}
	
	// Update is called once per frame
	private void FixedUpdate () {
		if (!GameObject.FindWithTag ("Collectible"))
		{
			winText.SetActive (true);
		}
	}

	public void addScore(){
		score++;
		scoreText.text = "score: " + score.ToString ("D1");
	}
}
