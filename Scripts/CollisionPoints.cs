using UnityEngine;
using System.Collections;

public class CollisionPoints : MonoBehaviour {
	[SerializeField]
	AudioSource impactSound;
	//public int value = 50;
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
		//if(col.GetComponent<MeshCollider>().material.name.ToString = "alvo2-_0056_Yellow_.mat")
//		if(col.material.name == "alvo2-_0056_Yellow_.mat")
//
//		//if(col.material.GetInstanceID = "alvo2-_0056_Yellow_.mat")
//		//if(col.GetComponent<MeshCollider>().material = alvo2-_0056_Yellow_)
//			ScoreManager.instance.score += 10;
//		
//		if(col.material.name == "alvo2-_0020_Red_.mat")
//			ScoreManager.instance.score += 8;
//
//		if(col.material.name == "alvo2-_0097_DeepSkyBlue_.mat")
//			ScoreManager.instance.score += 6;
//
//		if(col.material.name == "alvo2-_0137_Black_.mat")
//			ScoreManager.instance.score += 4;
//
//		if (col.material.name == "alvo2-_0010_Snow_.mat")
//			ScoreManager.instance.score += 2;
//		else

		//Debug.Log ("Alvo:" + col.material.name);
	}
}
