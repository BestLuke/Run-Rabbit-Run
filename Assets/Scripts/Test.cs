using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct PlayerState
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

public class Test : MonoBehaviour 
{
	[SerializeField] TimeController timeController;
	[SerializeField] Test player;
	Dictionary<int, PlayerState> recording;
	Dictionary<int,PlayerState> states = new Dictionary<int, PlayerState>();

	Animator _animator;
	Rigidbody _rigidbody;

	bool isPlaying = false;

	bool isRecording = true;

	void Start()
	{
		_animator = GetComponent<Animator> ();
		//_rigidbody = GetComponent<Rigidbody> ();
		StartCoroutine(RecordLastSeconds());
	}

	public void SetRecording(Dictionary<int, PlayerState> recording)
	{
		this.recording = new Dictionary<int, PlayerState> (recording);
		isPlaying = true;
		//_rigidbody.isKinematic = true;
	}

	void Update()
	{
		/*if(recording != null)
		print ("Record count = " + recording.Count);
		
		print ("State count = " + states.Count);
		if (Input.GetKeyDown (KeyCode.P)) 
		{
			isRecording = false;
			player.SetRecording (states);
			//timeController.time = 0;
		}*/
	}

	void FixedUpdate()
	{
		if (isRecording) 
		{
			states.Add (timeController.time, new PlayerState (transform.position,
				_animator.GetCurrentAnimatorStateInfo (0).shortNameHash, 
				transform.localScale.x > 0));
		}
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

	IEnumerator RecordLastSeconds()
	{
		while (true) 
		{	
			if (Input.GetKeyDown (KeyCode.Q) && GameManager.coinsCollected >= 1) 
			{
				GameManager.coinsCollected--;
				Timer.coinsCollected--;
				isRecording = false;
				player.SetRecording (states);
				timeController.windBack = true;
			}

			if (timeController.time <= 0) 
			{
				ResetRecording ();
			}

			if (Input.GetKeyUp (KeyCode.Q) ) 
			{
				
				ResetRecording ();
			
			}
			yield return null;
		}

	}

	void ResetRecording()
	{
		Debug.Log ("Finsihed playing the recording");
		states.Clear ();
		if(recording != null)
			recording.Clear ();
		timeController.windBack = false;
		isRecording = true;
		timeController.time = 0;

	}
}

