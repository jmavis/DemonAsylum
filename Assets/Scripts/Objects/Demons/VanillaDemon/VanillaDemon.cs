using UnityEngine;
using System.Collections;

public class VanillaDemon : Demon {
	string name;
	string TAG = "VanillaDemon";

	// Use this for initialization
	void Start () {
		name = this.gameObject.name;
		TAG += "-" + name;
		Log.d (TAG, "Start");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
