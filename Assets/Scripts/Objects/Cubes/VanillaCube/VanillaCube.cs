using UnityEngine;
using System.Collections;

public class VanillaCube : Cube {
	string cubeName;
	string TAG = "VanillaCube";

	// Use this for initialization
	void Start () {
		cubeName = this.gameObject.name;
		TAG += "-" + cubeName;
		Log.d (TAG, "Start");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
