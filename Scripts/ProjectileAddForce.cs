using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ProjectileAddForce : MonoBehaviour {
	Rigidbody rigidB;
	public float shootForce = 500;
//	public int windvalue=1;
	public static ProjectileAddForce instance;
    public int windSet=1;


	// Use this for initialization
//	void Start () {
//
//	}

	void OnEnable()
	{
		instance = this;
		//		windvalue = 1;
		// verificar se exixte vento ou não
		if (GameObject.Find ("Terrain").GetComponent<TurnWindOnOff> ().estadoVento)
			windSet = 1;
		if (!GameObject.Find ("Terrain").GetComponent<TurnWindOnOff> ().estadoVento)
			windSet = 0;
		Debug.Log ("WindSet está a: " + windSet);

		if (windSet == 0) {
			rigidB = GetComponent<Rigidbody> ();
			rigidB.velocity = Vector3.zero;
			ApplyForce ();
		}
		if (windSet == 1) {
			rigidB = GetComponent<Rigidbody> ();
			rigidB.velocity = Vector3.zero;
			ApplyForce ();
			ArrowWind ();
		}
	}
//		Debug.Log ("Vento_script: " + windSet);
//		if (instance.windvalue == 0) {
//			windSet = 0;
//			{
//				if (windSet == 0) {
//					rigidB = GetComponent<Rigidbody> ();
//					rigidB.velocity = Vector3.zero;
//					ApplyForce ();
//				}
//				if (windSet == 1) {
//					rigidB = GetComponent<Rigidbody> ();
//					rigidB.velocity = Vector3.zero;
//					ApplyForce ();
//					ArrowWind ();
//				}
//			}
//		}
//	
//
//		if (instance.windvalue == 1) {
//			windSet = 1;
//			{
//				if (windSet == 0) {
//					rigidB = GetComponent<Rigidbody> ();
//					rigidB.velocity = Vector3.zero;
//					ApplyForce ();
//				}
//				if (windSet == 1) {
//					rigidB = GetComponent<Rigidbody> ();
//					rigidB.velocity = Vector3.zero;
//					ApplyForce ();
//					ArrowWind ();
//				}
//			}
//		}
//	}

//		if (Input.GetKey (KeyCode.D)) {
//			rigidB.AddRelativeForce (Vector3.right * 0);
//		}
//		if (Input.GetKey (KeyCode.L)) {
//			rigidB.AddRelativeForce (Vector3.right * 250);
//		}
		//ArrowWind ();
	
	// Update is called once per frame
	void Update () {
		SpinObjectInAir ();
	}

	void ApplyForce()
	{
		rigidB.AddRelativeForce (Vector3.up * shootForce);

		//rigidB.velocity = transform.forward * shootForce;
	}

	void SpinObjectInAir()
	{	
//		rigidB.transform.LookAt (transform.position + rigidB.velocity);
//		transform.rotation = Quaternion.LookRotation (Vector3.forward);
//
		//"certo"
//		float _yVelocity = rigidB.velocity.y;
//		float _zVelocity = rigidB.velocity.z;
//		float _xVelocity = rigidB.velocity.x;
//		float _combinedVelocity = Mathf.Sqrt (_yVelocity * _yVelocity + _zVelocity * _zVelocity);
//		float _fallAngle = -1*Mathf.Atan2(_xVelocity, _combinedVelocity)*180/Mathf.PI;
//		transform.eulerAngles = new Vector3 (transform.eulerAngles.x, _fallAngle, transform.eulerAngles.z);


		//original
//		float _yVelocity = rigidB.velocity.y;
//		float _zVelocity = rigidB.velocity.z;
//		float _xVelocity = rigidB.velocity.x;
//		float _combinedVelocity = Mathf.Sqrt (_xVelocity * _xVelocity + _zVelocity * _zVelocity);
//		float _fallAngle = -1*Mathf.Atan2(_yVelocity, _combinedVelocity)*180/Mathf.PI;
//
//		transform.eulerAngles = new Vector3 (_fallAngle, transform.eulerAngles.y,transform.eulerAngles.z);
	}
	void ArrowWind()
	{
		//rigidB.AddRelativeForce (Vector3.up * shootForce);
		rigidB.AddRelativeForce (Vector3.right * 100);

	}
}