using UnityEngine;
using System.Collections;

public class LevelWechsel : MonoBehaviour {
	public GameObject level2;
	// Use this for initialization
	void Start () {

	}
	
	void OnTriggerEnter(Collider other){
		Application.LoadLevel("Level2");
	}
}
