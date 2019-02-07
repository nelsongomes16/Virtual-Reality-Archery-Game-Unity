using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.IO.Ports;
using System.Threading;

public class Sending : MonoBehaviour {
	
	//public static SerialPort sp = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
	public static SerialPort sp = new SerialPort("COM1", 9600);

	private string message;
	public Text buttonState;

	// Use this for initialization
	void Start () {
		OpenConnection();
	}
	
	// Update is called once per frame
	void Update () {
		try{	
			message = sp.ReadLine();
			buttonState.text = "Button: " + message;
		}
		catch
		{
		}

	}
	
	public void OpenConnection() 
	{
		if (sp != null) 
		{
			if (sp.IsOpen) 
			{
				sp.Close();
				print("Closing port, because it was already open!");
			}
			else 
			{
				sp.Open();  // opens the connection
				sp.ReadTimeout = 16;  // sets the timeout value before reporting error
				print("Port Opened!");
				//		message = "Port Opened!";
			}
		}
		else 
		{
			if (sp.IsOpen)
			{
				print("Port is already open");
			}
			else 
			{
				print("Port == null");
			}
		}
	}
	
	void OnApplicationQuit() 
	{
		sp.Close();
	}
	public static void liga(){
		sp.WriteLine ("5");
		Debug.Log ("Liga vento");
	}
	public static void desliga(){
			sp.WriteLine ("0");
		}
}

//	public static void sendYellow(){
//		sp.Write("y");
//	}
//	
//	public static void sendGreen(){
//		sp.Write("g");
//	}
//	
//	public static void sendRed(){
//		sp.Write("r");
//	}
