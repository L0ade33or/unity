using UnityEngine;
using System.Collections;

public class TimerScript : MonoBehaviour {
	
	public GameObject Tuer;
	public BoxCollider TuerCollider;
	public MeshRenderer TuerRenderer;
	public TimerTuer Tuerscript;
	private bool Tueroffen;
	public float zeit;
	
	void Start () {
		Tuerscript = Tuer.GetComponent <TimerTuer> ();
		TuerCollider = Tuer.GetComponent <BoxCollider> ();
		TuerRenderer = Tuer.GetComponent <MeshRenderer> ();

	}
	
	void OnTriggerStay (Collider target) {
		if (target.tag == "Player" && Input.GetMouseButton (0)) {
			Debug.Log ("Klappt");
			Tuerscript.Tuerauf = true;
			zeit = 500;
		}
	}
	
	void Update () {
		
		if (Tuerscript.Tuerauf == true) {
			zeit -= 1f;}
		if (Tuerscript.Tuerauf == true && zeit < 1) {
			Tuerscript.Tuerauf = false;
		}
		
		//Debug.Log (zeit);
	}
}