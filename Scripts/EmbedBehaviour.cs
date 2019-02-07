using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EmbedBehaviour : MonoBehaviour {
	Rigidbody rigidB;
//	[SerializeField]
//	AudioSource impactSound;

	// Use this for initialization
	void Start () {
		rigidB = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider coll){
		Embed ();
		transform.parent = coll.transform.parent;
		Debug.Log ("Alvo:" + coll.name);
	}
	void Embed(){
		//impactSound.Play ();
		//GetComponent<Collider> ().enabled = false;
		transform.GetComponent<ProjectileAddForce> ().enabled = false;
		rigidB.velocity = Vector3.zero;
		//rigidB.GetComponent<MeshRenderer> ().enabled = false;
		rigidB.useGravity = false;
		rigidB.isKinematic = true;

	}
}
