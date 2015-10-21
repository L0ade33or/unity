using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class KeyUse : MonoBehaviour {
	public Inventar inv;
	public Text output;

	// Use this for initialization
	void Start () {
		inv = GameObject.Find ("GameManager").GetComponent<Inventar> ();
		output = GetComponent<Text>();

	}
	
	void OnTriggerEnter (Collider other){
		if (inv.inventar[1] == true){
			gameObject.SetActive(false);

			inv.inventar[1] = false;
		}else{
			Debug.Log("Nope");
		}
	}

}
