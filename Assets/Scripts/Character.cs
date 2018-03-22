using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour 
{
	public float movementSpeed;
	//changed to static to use as a jump powerup also added value
	public float jumpHeight;
	public bool isJumping = false;
	public float timeLeft = 1f;
	public bool pUJump = false;
	public GameObject player;
	public GameObject cameraMain;
	public GameObject[] coins;

	void Start () 
	{
		timeLeft = 1f;
	}

	void Update () 
	{
		
		if (Input.GetKey(KeyCode.W))
			{
				transform.Translate(Vector3.forward * movementSpeed / 10);
			}
		if (Input.GetKey(KeyCode.S))
		{
			transform.Translate(Vector3.back * movementSpeed / 10);
		}
		if (Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left * movementSpeed / 10);
		}
		if (Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right * movementSpeed / 10);
		}

		if (Input.GetKeyDown (KeyCode.Space) && isJumping == false) 
		{
			
			print ("jump responding");
			isJumping = true;
			print ("jump responding 2");
			GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpHeight);
			print ("jump responding 3");
			//StartCoroutine (Jumping());
		}
		if (Input.GetKeyDown (KeyCode.Escape)) {
			Application.Quit();
		}




		if (pUJump == true) {
			timeLeft -= Time.deltaTime;
			isJumping = false;

		}

		if (timeLeft <= 0) {
			pUJump = false;

		}
		
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Ground") {
			isJumping = false;
		}
		if (col.gameObject.tag == "PUJump") {
			timeLeft = 1f;
			pUJump = true;
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "Death") 
		{
			//Application.LoadLevel ("Matt");
			player.transform.position = new Vector3 (62.1f,7.28f,42.81f);
			cameraMain.transform.position = new Vector3 (62.1f,9.983f,37.53f);
			Timer.isDead = true;
			print ("isDead = true");
			foreach (GameObject obj in coins) {
				obj.SetActive (true);
				GameManager.coinsCollected = 0;
				Timer.coinsCollected = 0;
			}
		}
	}

	//IEnumerator Jumping()
	//{
		
		//GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpHeight);
	//	yield return new WaitForSeconds (0.75f);
	//	isJumping = false;
	//}
}
