using UnityEngine;
using System.Collections;

public class ArrowWind : MonoBehaviour {
	Rigidbody rigidB;
	// Use this for initialization
	void Start () {
		rigidB.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		cenas ();
 }
	void cenas(){
	if (Input.GetKey (KeyCode.S)) 
		rigidB.AddRelativeForce (Vector3.right * 250);
	
	if (Input.GetKey (KeyCode.N)) 
		rigidB.AddRelativeForce (Vector3.right * 0);
}
}