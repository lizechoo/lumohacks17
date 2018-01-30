using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchHappyScene : MonoBehaviour {

	public AudioSource scaryAudio;
	public GameObject cardboard;
    public float distanceMove;
    public AudioSource happyAudio; 

	public void TriggerDown(){
		scaryAudio.mute = true;
        happyAudio.Play(); 
		cardboard.transform.rotation = new Quaternion (0,180,0,0);
		cardboard.transform.position = new Vector3 (cardboard.transform.position.x,
											cardboard.transform.position.y, 
												cardboard.transform.position.z - distanceMove);
		
	}
}
