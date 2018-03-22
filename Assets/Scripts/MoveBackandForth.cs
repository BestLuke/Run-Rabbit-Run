using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackandForth : MonoBehaviour {

	public Transform a, b;
	[Range(0, 1)]
	public float speed = 1;
	float myTime;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {



		if (!TimeController.instance.windBack) 
		{
			myTime += Time.deltaTime;
			float pingPong = Mathf.PingPong (myTime * speed, 1);
			transform.position = Vector3.Lerp (a.position, b.position, pingPong);
		}
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Player") {
			col.transform.parent = transform;
		}
	}

	void OnCollisionExit(Collision col)
	{
		if (col.gameObject.tag == "Player") {
			col.transform.parent = null;
		}
	}
}
