using UnityEngine;
using System.Collections;

public class Log : MonoBehaviour {
	public static void d(string tag, string message){
		Debug.Log (tag + ": " + message);	
	}
}
