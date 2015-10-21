using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Scoreout : MonoBehaviour {

	public GamemanagerErhalt gmscript;
	Text text;

	// Use this for initialization
	void Awake () {
		text = GetComponent<Text> ();
		gmscript = GameObject.Find ("GameManager").GetComponent<GamemanagerErhalt> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score:" + gmscript.overallScore.ToString();

	}
}
