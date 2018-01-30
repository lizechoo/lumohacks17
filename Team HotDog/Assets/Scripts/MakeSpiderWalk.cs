using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSpiderWalk : MonoBehaviour {

	public float distanceMove = 0.01f;
	public AudioSource audio;
	public GameObject invisibleMarker;
	public float speed;
	public GameObject spider;
	public GameObject spiderGen;

	private Animator anim;
	private float stop;
	public bool hitLine;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();		// get Animator controller if there is one
		stop = invisibleMarker.transform.position.z;
	}


	// Update is called once per frame
	void Update () {
		MoveSpider ();
	}

	void MoveSpider(){
		playAudio ();
		if (checkStop ()) {
			hitLine = true;
			return;
		}

		anim.SetTrigger ("Walk");
		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	}

	void playAudio(){
		if(!audio.isPlaying)
			audio.Play ();				// if the audio is not playing, play the audio
	}

	bool checkStop(){
		if (transform.position.z <= stop) 
			return true;
		
		return false;
	}
}
