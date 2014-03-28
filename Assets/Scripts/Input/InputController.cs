using UnityEngine;
using System.Collections;

public class InputController : MonoBehaviour{
	private InputType typeOfInput;
	
	void Start(){
		typeOfInput = DetermineTypeOfInput();
	}
	
	private InputType DetermineTypeOfInput(){
		if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer){
			
		} else {
			return (new MouseInput());
		}
	}
	
	void Update () {
		typeOfInput.HandleInput();
	}
}
