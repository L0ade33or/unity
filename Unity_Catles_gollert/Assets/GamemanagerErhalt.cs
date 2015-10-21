using UnityEngine;
using System.Collections;

public class GamemanagerErhalt : MonoBehaviour {
	public GameObject gamemanager;
	public int overallScore;
	void Awake() {
		gamemanager = GameObject.Find ("GameManager");
		DontDestroyOnLoad(gamemanager);
	}
	
	
}
