using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RedKeyInv : MonoBehaviour {
	public Inventar invanzeige;
	Text text;
	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		invanzeige = GameObject.Find ("GameManager").GetComponent<Inventar> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(invanzeige.inventar[0] == true)
		{
			text.enabled = true;
			text.text = "Red Key!";
		}
}
}
