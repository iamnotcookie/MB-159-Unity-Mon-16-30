using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectible_controller : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(Vector3.up * Time.deltaTime * 100, Space.World);
		transform.Translate (Vector3.up * Time.deltaTime , Space.World);
		transform.Translate (Vector3.down * Time.deltaTime , Space.World);
	}
}
