using UnityEngine;
using System.Collections;

public abstract class InputType {
	protected emum ControlState {
		WaitingForFirstInput, // No fingers down
		WaitingForSecondTouch, // One finger down waiting for seconds finger or movement 
		WaitingForMovement, // Two fingers down and waiting for zoom indication
		Draging, // User is dragging
		Pinching, // User is pinching in or out
		WaitingForNoInput, // Event is done and waiting for the user to stop input
		HoldingClick, // User has held the click down for HOLDMINSECONDS
	};
	
	protected float HOLDMINSECONDS = 2;
	
	protected bool PINCH_IN = true;
	protected bool PINCH_OUT = false;
	
	protected ControlState currentState;
	
	public InputType(){
		ResetControlState();
	}
	
	#region abstract functions
	public abstract void HandleInput();
	
	public abstract void ResetControlState();
	#endregion
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
