using UnityEngine;
using System.Collections;

public class ParticleAus : MonoBehaviour {

	public bool particleOff;
	private BoxCollider box;
	private ParticleSystem part;
	private AudioSource sound;
	void Start()
	{
		box = GetComponent<BoxCollider>();
		part = GetComponent<ParticleSystem>();
		sound = GetComponent<AudioSource>();
	

	}
	void Update()
	{
		
		
		if (particleOff)
		{
			box.enabled = false;
			part.enableEmission = false;
			sound.enabled = false;
		} else {  
			box.enabled = true;
			part.enableEmission = true;
			sound.enabled = true;
		}
		
	}
}
