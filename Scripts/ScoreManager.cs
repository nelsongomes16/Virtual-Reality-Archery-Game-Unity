using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public int score = 0;
	public static ScoreManager instance;
	public int total = 0;
	[SerializeField]
	Text scoreText;

//	public int nAmarelo =0;
//	public int nVermelho =0;
//	public int nAzul =0;
//	public int nPreto=0;
//	public int nBranco=0;

	// Use this for initialization
	void Start () {
		instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		total = total + score;
			
		if (instance.score == 10) 
			scoreText.color = Color.yellow;
			//nAmarelo=nAmarelo+1;
			scoreText.text = "Points: " + total.ToString ();
			
		

		if (instance.score == 8) 
			scoreText.color = Color.red;
			//nVermelho = nVermelho + 1;
			scoreText.text = "Points: " + total.ToString ();
			
		
		if (instance.score == 6) 
			scoreText.color = Color.blue;
			//nAzul = nAzul + 1;
			scoreText.text = "Points: " + total.ToString ();
			
		
		
		if (instance.score == 4)
			scoreText.color = Color.black;
			//nPreto = nPreto + 1;
			scoreText.text = "Points: " + total.ToString ();
			

	
		
		if (instance.score == 2)
			scoreText.color = Color.white;
			//nBranco = nBranco + 1;
			scoreText.text = "Points: " + total.ToString ();
			
		 
//		if (instance.score == 0)
//			scoreText.text = "Missed shot";
	
		score = 0;
	}
}
