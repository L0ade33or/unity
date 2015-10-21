using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public Transform starttrans;
	public GameObject Ziel;
	public GameObject Capsule;
	void OnTriggerEnter(Collider other) {

		AudioSource sound = gameObject.GetComponent<AudioSource>();
		sound.Play();

		Capsule = GameObject.Find ("Capsule");
		Capsule.transform.position = Ziel.GetComponent<Transform>().position;

			}
}
