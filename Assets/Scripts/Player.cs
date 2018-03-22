using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Player : MonoBehaviour 
{
	[SerializeField] TimeController timeController;
	Dictionary<int, PlayerState> recording;

	Animator _animator;
	Rigidbody _rigidbody;

	bool isPlaying = false;

	void Start()
	{
		_animator = GetComponent<Animator> ();
		_rigidbody = GetComponent<Rigidbody> ();
	}

	public void SetRecording(Dictionary<int, PlayerState> recording)
	{
		this.recording = new Dictionary<int, PlayerState> (recording);
		isPlaying = true;
		_rigidbody.isKinematic = true;
	}

	void Update()
	{
		
	}

	void FixedUpdate()
	{
		if (isPlaying) 
		{
			if (recording.ContainsKey (timeController.time)) 
			{
				PlayState (recording [timeController.time]);
			}
		}
	}

	void PlayState(PlayerState playerState)
	{
		transform.position = playerState.position;
		_animator.Play (playerState.animState);
		Vector3 localScale = transform.localScale;
		localScale.x = playerState.direction ? Mathf.Abs (localScale.x) : -Mathf.Abs (localScale.x);
		transform.localScale = localScale;

	}
}
*/