using UnityEngine;
using System.Collections;

public class VanillaDemon : Demon {
	string demonName;
	string TAG = "VanillaDemon";

	// Use this for initialization
	void Start () {
		demonName = this.gameObject.name;
		TAG += "-" + demonName;
		Log.d (TAG, "Start");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
