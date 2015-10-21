using UnityEngine;
using System.Collections;
public class FallenUndSterben : MonoBehaviour {

	RaycastHit hit;
	public float height ;
	private float falldistance;
	public bool tot;
	private float maximumFallDistance = 7;
	
	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
		if (Physics.Raycast (transform.position, Vector3.down, out hit)) {
			if (height > hit.distance) {

				falldistance = (height - hit.distance) + falldistance;
				Debug.Log (falldistance);

				if (falldistance > maximumFallDistance) {

					tot = true;
				}

			} else if (height <= hit.distance){

				if (tot) {


					Application.LoadLevel ("Level1");
				}

				falldistance = 0 ;
			}
			height = hit.distance;
		}
	}
}
