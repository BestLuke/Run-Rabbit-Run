using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	static public float timeTaken;
	public Text timerText;
	static public bool isDead = false;
	public float lastTime;
	public Text lastTimeText;
	public float startTime;
	public Text coinText;
	static public int coinsCollected;
	//static public int lives = 0;


	// Use this for initialization
	void Awake()
	{
		timeTaken = 0f;
	}
	void Start () 
	{

		startTime = Time.time;

	}
	
	// Update is called once per frame
	void Update ()
	{
		//timeTaken++;
		//timeTaken = Time.deltaTime;
		startTime = Time.time;
		coinText.text = (coinsCollected + " WindBacks");
		lastTimeText.text = (lastTime + " Seconds");
		timerText.text = (timeTaken + " Seconds");
		if (isDead == true) {
			print ("time resetting");
			lastTime = timeTaken;
			timeTaken = 0f;
			isDead = false;

		}



	}
	void LateUpdate()
	{
		StartCoroutine (TimeKeeper ());
	}


	IEnumerator TimeKeeper()
	{
		yield return new WaitForSeconds (1f);

		if (Time.time >= timeTaken + 1f) {
			timeTaken += Time.deltaTime;
}
	}
}
