using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerButtonController : MonoBehaviour {


	public Text lifeText;
	private int life;

	public Text scoreText;
	private int score;

	private int speed;
	private Vector3 movement;
	private int active;
	// Use this for initialization
	void Start () {
		movement = transform.position;
		this.speed = 1;
		active = 0;

		this.lifeText.text = "100";

		life = 100;
		score = 0;
	}


	void Update () {
		//float verticalMovement = Input.GetAxis ("Vertical");
		//if (verticalMovement != 0.0f) {
		if(active == 1){
			transform.Translate (movement *speed* Time.deltaTime);
		}

		PintarScoreYLife ();
	}

	private void PintarScoreYLife(){
		Text objs = GameObject.Find ("Life").GetComponent<Text>();

		objs.text = "" + life.ToString();
		scoreText.text = "Score: " + score.ToString ();
	}

	public void moveForward(){
		this.movement = transform.forward;
		this.lifeText.text = "me estoy moviendo hacia delante";
		//transform.Translate (transform.forward * speed * Time.deltaTime);
	}

	public void moveBack(){
		this.lifeText.text = "me estoy moviendo hacia atrás";
		this.movement = -transform.forward;
		//transform.Translate (-transform.forward * speed * Time.deltaTime);
	}


	public void moveLeft(){

		this.movement = -transform.right;
		this.life--;
		//transform.Translate (-transform.right * speed * Time.deltaTime);
	}

	public void moveRight(){
		this.movement = transform.right;
		//transform.Translate (transform.right * speed * Time.deltaTime);
	}

	public void ActivateMovement(){
		this.active = 1;
	}

	public void StopMovement(){
		this.active = 0;
		this.lifeText.text = "estoy parado";
	}





}
