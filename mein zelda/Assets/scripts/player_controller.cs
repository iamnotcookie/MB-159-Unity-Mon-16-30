using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour {

	[SerializeField]
	private float pushforce = 3000;
	private Rigidbody rb;
	private GameObject gameController;
	private float move_horizontal;
	private float move_vertical;
	private Vector3 movement;

	// Use this for initialization
	private void Start () {
		rb = GetComponent<Rigidbody> ();
		gameController = GameObject.FindWithTag ("GameController");
	}
		
	// Update is called once per frame
	private void FixedUpdate () {
		move_horizontal = Input.GetAxisRaw ("Horizontal");
		move_vertical = Input.GetAxisRaw ("Vertical");
		movement = new Vector3 (move_horizontal, 0f, move_vertical);
		rb.AddForce(movement * pushforce);
    }
	void OnTriggerEnter(Collider other) {
		Destroy(other.gameObject);
		gameController.GetComponent<score_controller>().addScore ();
		score_controller.instance.addScore ();
	}
}
