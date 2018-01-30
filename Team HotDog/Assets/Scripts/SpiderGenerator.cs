using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// WORK IN PROGRESS
public class SpiderGenerator : MonoBehaviour {
	private List<GameObject> spiders = new List<GameObject>();

	public GameObject templateSpider;

	private Vector3 position;
	private Quaternion rotation;
	private int count;
	private int currentSpider;

	void Start(){
		this.position = templateSpider.transform.position;
		this.rotation = templateSpider.transform.rotation;

		GameObject spider = Instantiate (templateSpider, position, rotation);
		spider.SetActive (true);
		spiders.Add (spider);
	}

	void Update(){
		if (spiders [currentSpider].GetComponent<MakeSpiderWalk> ().hitLine) {
			Destroy (spiders [currentSpider].GetComponent<MakeSpiderWalk> ());
			CreateSpider ();
		}
	}

	public void CreateSpider(){
		if (spiders.Count == 7)
			return;

		GameObject spiderLeft = templateSpider;
		GameObject spiderRight = templateSpider;

		spiderLeft.transform.position = new Vector3 (position.x - 0.5f, position.y, position.z);
		spiderRight.transform.position = new Vector3 (position.x + 0.5f, position.y, position.z);
			
		spiders.Add (spiderLeft);
		spiders.Add (spiderRight);

		while (count != spiders.Count) {
			GameObject newSpider = Instantiate (spiders [count], 
				                    spiders [count].transform.position, 
									spiders [count].transform.rotation);

			newSpider.SetActive (true);
			count++;
		}

		count = 0;
		currentSpider += 2;
	}
}
