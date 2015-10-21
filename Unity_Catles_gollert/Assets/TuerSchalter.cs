using UnityEngine;
using System.Collections;

public class TuerSchalter : MonoBehaviour {
	public TuerBoolOffen script;
	public GameObject door;
	public bool tuerauf;


	
	// Use this for initialization
	void Start () {
		script = door.GetComponent <TuerBoolOffen> ();
	}
	void OnMouseDown ()
	{

		if (tuerauf == false) {
			tuerauf = true;
	
		}
		else if (tuerauf == true) {
			tuerauf = false;
		}
		
		
	}

	void Update () {
		if (tuerauf == true) {
			script.TuerZustand = true;
		} else {
			script.TuerZustand = false;
		}
	}
}

