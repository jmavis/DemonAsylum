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
	
	#region Notifications
	protected void NotifyNoObjectClickedOn(Vector2 inputScreenPos){
		EventManager.instance.RiseOnClickedNoObjectEvent(new ClickPositionArgs(inputScreenPos));
	}

	protected void NotifyObjectClickedOn(GameObject objectClicked){
		EventManager.instance.RiseOnClickedObjectEvent(new ClickedObjectArgs(objectClicked));
	}
	#endregion
	
	protected void SingleClickEvent(Vector2 inputScreenPos){
		// TODO check if on a menu
		DelegateClickForObjects(inputScreenPos);	
	}
	
	private void DelegateClickForObjects(Vector2 inputScreenPos) {
		Ray ray = Camera.main.ScreenPointToRay (inputScreenPos);
		
		RaycastHit hit;
		
		if (Physics.Raycast(ray, out hit, 25) && !hit.transform.CompareTag("Untagged")) {
			NotifyObjectClickedOn(hit.transform.gameObject);
		} else {
			NotifyNoObjectClickedOn(inputScreenPos);
		}
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
