using UnityEngine;
using System.Collections;

public class LeiterErklimmen : MonoBehaviour {

	public float Height = 15;
	private bool Climb;
	// Update is called once per frame
	void FixedUpdate () 
	{
		if (Input.GetMouseButton(0) && Climb)
		{
			transform.position += new Vector3(0, Height * Time.deltaTime, 0);   
		}
	}
	
	void OnTriggerEnter(Collider other)
	{
		Climb = true;
	}
	
	void OnTriggerExit(Collider other)
	{
		Climb = false;  
	}
}



	
