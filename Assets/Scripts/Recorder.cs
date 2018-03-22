using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public struct PlayerState
{
	public Vector3 position;
	public int animState;
	public bool direction;

	public PlayerState(Vector3 position, int animState, bool direction)
	{
		this.position = position;
		this.animState = animState;
		this.direction = direction;
	}
}


public class Recorder : MonoBehaviour 
{
	[SerializeField] TimeController timeController;
	[SerializeField] Player player;

	Dictionary<int,PlayerState> states = new Dictionary<int, PlayerState>();

	Animator _animator;



	void Start () 
	{
		_animator = GetComponent<Animator> ();
		
	}

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			isRecording = false;
			player.SetRecording (states);
			timeController.time = 0;
		}
	}

	bool isRecording = true;
	
	
	void FixedUpdate () 
	{
		if (isRecording) 
		{
			states.Add (timeController.time, new PlayerState (transform.position,
				_animator.GetCurrentAnimatorStateInfo (0).shortNameHash, 
				transform.localScale.x > 0));
		}

	}
}
*/