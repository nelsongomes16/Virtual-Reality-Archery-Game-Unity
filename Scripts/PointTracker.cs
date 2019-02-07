using UnityEngine;
using System.Collections;

public class PointTracker : MonoBehaviour {
	[SerializeField]
	AudioSource impactSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider col)
	{
		impactSound.Play ();
		ScoreManager.instance.score += 2; 

		Debug.Log ("Alvo:" + col.material.name);
	}
//	void OnCollisionStay(Collision col)
//	{
//		impactSound.Play ();
//		ScoreManager.instance.score += 2;
//	}
}
