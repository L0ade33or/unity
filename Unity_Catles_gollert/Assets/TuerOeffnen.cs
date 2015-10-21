using UnityEngine;
using System.Collections;

public class TuerOeffnen : MonoBehaviour {


	void OnTriggerEnter (Collider other)
	{
		Animation anime = GetComponentInChildren<Animation> ();
		anime.Play("TuerOeffnen");

	}
	void OnTriggerExit (Collider other)
	{
	
		Animation anime = GetComponentInChildren<Animation> ();
		anime.Play("TuerSchliessen");
			
	}
}
