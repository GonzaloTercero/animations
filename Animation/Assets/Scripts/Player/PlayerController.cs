using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

	void Update () {
		float verticalMovement = Input.GetAxis ("Vertical");
		if (verticalMovement != 0.0f) {
			transform.Translate (transform.forward * verticalMovement * Time.deltaTime);
		}
	}

	public void moveForward(){
	}
}
