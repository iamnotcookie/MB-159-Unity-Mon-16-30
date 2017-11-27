using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_controller : MonoBehaviour {
	
	//[SerializeField]
	private Transform target;
    private  Vector3 offset;
	
    // Use this for initialization
	void Start () {
		target = GameObject.FindWithTag ("Player").GetComponent<Transform>();
		offset = transform.position - target.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = target.transform.position + offset;
	}
}
