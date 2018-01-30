using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitMarker : MonoBehaviour {
	public GameObject spider;

	void onTriggerEnter(Collider other){
		if (other.gameObject.tag == "Spider")
			spider.transform.position = this.transform.position;

		Debug.Log ("hit!");
	}
}
