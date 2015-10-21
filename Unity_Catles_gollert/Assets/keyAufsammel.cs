using UnityEngine;
using System.Collections;

public class keyAufsammel : MonoBehaviour {
	Inventar inv;
	GameObject manager;
	// Use this for initialization
	void Start () {

		manager = GameObject.Find ("GameManager");
		inv = manager.GetComponent<Inventar>();
		gameObject.tag = this.tag;
	}

	
	// Update is called once per frame
	void OnTriggerEnter (Collider other) {
		gameObject.SetActive(false);
		if (this.tag == "RedKey"){
		inv.inventar[0] = true;

		} else {  
			inv.inventar[1] = true;
		}
	}
}