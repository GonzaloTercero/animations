using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpButton : MonoBehaviour {


	private bool advance;
	public GameObject obj;
	// Use this for initialization
	void Start () {
		advance = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(advance)
			obj.GetComponent<PlayerController>().moveForward();
	}

	void IsPressed(){
		Debug.Log ("entramos MouseDown");
		obj.GetComponent<PlayerController>().moveForward();
	}

	void OnClick(){
		Debug.Log ("entramos OnClick");
	}

	void OnPointerDown(){
		Debug.Log ("entramos MouseDown");
	}
}
