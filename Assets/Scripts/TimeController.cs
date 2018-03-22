using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour 
{
	public static TimeController instance;
	public int time;

	public bool windBack = true; //Time is forwards by default

	void Awake()
	{
		instance = this;
	}

	void Update()
	{
		
	}

	void FixedUpdate()
	{
		if (!windBack) { //if time is moving forwards, then 'add time'. 
			time++;
		} 
		else
		{
			time--;
			if (time <= 0) 
			{
				time = 0; // Safty net
			}
		}
	}

}
