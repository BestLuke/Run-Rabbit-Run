using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitFallTrap : MonoBehaviour {

	public GameObject pitBlock;

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
		if (col.gameObject.tag == "Player") {
			
			StartCoroutine (PitDelay ());
		}
	}

	IEnumerator PitDelay()
	{
		pitBlock.SetActive (false);
		yield return new WaitForSeconds (2f);
		pitBlock.SetActive (true);

	}
}
