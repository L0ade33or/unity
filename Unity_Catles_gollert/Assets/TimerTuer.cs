using UnityEngine;
using System.Collections;
using UnityEngine;
using System.Collections;

public class TimerTuer : MonoBehaviour {
	public bool Tuerauf;
	
	public BoxCollider DoorCollider;
	public MeshRenderer DoorRenderer;
	// Use this for initialization
	void Start () {
		DoorCollider = GetComponent<BoxCollider>();
		DoorRenderer = GetComponent<MeshRenderer>();
		
	}
	
	
	// Update is called once per frame
	void Update () {
		if (Tuerauf == true) {
			DoorCollider.enabled = false;
			DoorRenderer.enabled = false;
		} else { 
			DoorCollider.enabled = true;
			DoorRenderer.enabled = true;
		}
		
	} 
}
