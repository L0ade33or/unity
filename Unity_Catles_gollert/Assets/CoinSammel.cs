using UnityEngine;
using System.Collections;

public class CoinSammel : MonoBehaviour {
	//public GamemanagerErhalt coinscript;
	//public GameObject gamemanager;
	public int score;
	// Use this for initialization
	void Start () {

	

	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {
		if(other.tag == "Muenze") {
			Destroy(other.gameObject);
			score = +100;
		}
	}
}
