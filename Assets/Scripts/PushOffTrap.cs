using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushOffTrap : MonoBehaviour 
{
	public AnimationClip anim;

	Animator pushAnim;

	// Use this for initialization
	void Start () 
	{
		pushAnim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider hit)
	{
		pushAnim.SetTrigger("Play");
	}
}
