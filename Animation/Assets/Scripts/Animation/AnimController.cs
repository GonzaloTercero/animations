using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour {

	private Animator anim;	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		float verticalMovement = Input.GetAxisRaw ("Vertical");
		if (verticalMovement != 0.0f) {
			anim.SetBool ("esta_andando", true);
			anim.SetFloat ("speed", verticalMovement);

		} else {
			anim.SetBool ("esta_andando", false);
		}

		if (Input.GetKey ("space")) {
			anim.SetBool ("esta_saltando", true);
		} else {
			anim.SetBool ("esta_saltando", false);
		}
		
	}
}
