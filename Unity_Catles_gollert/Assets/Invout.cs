using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Invout : MonoBehaviour {
	public Inventar invanzeige;
	public Text text;
	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		invanzeige = GameObject.Find ("GameManager").GetComponent<Inventar> ();

	}
	
	// Update is called once per frame
	void Update () {

		if(invanzeige.inventar[1] == true )
		{
			text.enabled = true;
			text.text = "Blue Key!";
		
		} else {
			text.enabled = false;
		}
	}
}
