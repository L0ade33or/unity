using UnityEngine;
using System.Collections;

public class OnLadder : MonoBehaviour {
	public bool onLadder;
	void OnTriggerEnter(Collider other) {
		onLadder = true;
	}
	void OnTriggerExit(Collider other) {
		onLadder = false;
	}

}
