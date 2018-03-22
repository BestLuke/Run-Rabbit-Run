using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpJump : MonoBehaviour {

	static public float timeLeft = 5f;
	static public bool powerUpOn = false;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (timeLeft <= 0) {
			powerUpOn = false;
			//Character.jumpHeight = 1f;
			timeLeft = 5f;
		}
		if (powerUpOn = true) {
			timeLeft += Time.deltaTime;
			//Character.jumpHeight = 2f;
		}

	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			print ("jump big");
			powerUpOn = true;
			//Character.jumpHeight = 2;

		}
	}



}
