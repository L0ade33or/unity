using UnityEngine;
using System.Collections;

public class BefördernaufBand : MonoBehaviour {
	
	public int strength;
	private Rigidbody rb;
	public GameObject magnet;
	public GameObject cap;
	void Start () {
		cap = GameObject.Find ("Capsule");
		magnet = GameObject.Find ("Magnet");
		rb = cap.GetComponent<Rigidbody> ();
	}
	
	void OnCollisionStay (Collision col) {

		rb.AddForce((magnet.transform.position - transform.position) * strength * Time.smoothDeltaTime);
	}
}
