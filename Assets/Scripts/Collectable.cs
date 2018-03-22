using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnTriggerEnter(Collider col)
	{
		print ("colliding");
		if (col.gameObject.tag == "Player") 
		{
			GameManager.coinsCollected ++;
			Timer.coinsCollected++;
			//Destroy (this.gameObject);
			this.gameObject.SetActive(false);


		}
	}
}
