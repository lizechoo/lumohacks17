using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchHappyScene : MonoBehaviour {

	public AudioSource scaryAudio;
	public GameObject cardboard;

	public void TriggerDown(){
		scaryAudio.mute = true;
		SceneManager.LoadScene ("HappyScene");
	}
}
