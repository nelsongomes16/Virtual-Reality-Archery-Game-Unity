using UnityEngine;
using System.Collections;

public class TurnWindOnOff : MonoBehaviour {
	[SerializeField]
	AudioSource windSound;
	[SerializeField]
	AudioSource changeWindModeSound;
	GameObject wind;
	public bool estadoVento;

	// Use this for initialization
	void Start () {
		var wind = gameObject.AddComponent<WindZone> ();
	}
	
	// Update is called once per frame
	void Update () {
		var wind = gameObject.GetComponent<WindZone> ();
		if (Input.GetKey (KeyCode.L)) {
			changeWindModeSound.Play ();
			windSound.Play ();
			wind.mode = WindZoneMode.Directional;	
			wind.windMain = 1.0f;
			ScoreManager.instance.total = 0;
			estadoVento = true;
			//ProjectileAddForce.instance.windvalue = 1;
			//ffs.instance.valorVento = 1;
			//ProjectileAddForce.instance.rigidbody.AddRelativeForce (Vector3.right * 250);
//			wind.transform.position= new Vector3 (357, -5, 195);
//			wind.transform.rotation= Quaternion.Euler(0,235,0);

			//ArrowWind ();
			Sending.liga ();
		}
		if (Input.GetKey (KeyCode.D)) {
			changeWindModeSound.Play ();
			windSound.Stop ();
			wind.mode = WindZoneMode.Directional;	
			wind.windMain = 0.0f;
			ScoreManager.instance.total = 0;
			estadoVento = false;
			//ProjectileAddForce.instance.windvalue = 0;
			//ffs.instance.valorVento = 0;
			Sending.desliga ();
	}
}
}