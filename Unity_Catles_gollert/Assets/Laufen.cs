using UnityEngine;
using System.Collections;

public class Laufen : MonoBehaviour
{
	public float moveSpeed;
	public int zaehler;
	public GamemanagerErhalt punkt;
	public GameObject manager;
	
	void Start ()
	{
		manager = GameObject.Find ("GameManager");
		punkt = manager.GetComponent<GamemanagerErhalt> ();
		
	}
	// Update is called once per frame
	void Update()
	{
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		
		transform.Translate(new Vector3(h, 0, v) * Time.deltaTime * moveSpeed);
	}

	void OnTriggerEnter (Collider geld){
		if (geld.tag == "Muenze")
			Destroy (geld.gameObject);
		zaehler += 1;
		punkt.overallScore += 100;
	}
	
}
