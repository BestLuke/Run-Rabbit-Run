using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	static public int coinsCollected = 0;

	// Use this for initialization
	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (coinsCollected > 0) {
			print (coinsCollected);
		}
		coinsCollected = Timer.coinsCollected;
	}
}
