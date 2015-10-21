using UnityEngine;
using System.Collections;

public class TuerBoolOffen : MonoBehaviour {

   public bool TuerZustand;
	public BoxCollider box;
	public MeshRenderer mesh;
    
	void Start()
	{
		box = GetComponent<BoxCollider>();
		mesh = GetComponent<MeshRenderer>();
	}
    void Update()
    {


        if (TuerZustand)
        {
			box.enabled = false;
			mesh.enabled = false;
		} else {  
			box.enabled = true;
			mesh.enabled = true;
		}
                         
    }
}

